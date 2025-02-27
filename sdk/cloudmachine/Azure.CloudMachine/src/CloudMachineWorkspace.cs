﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;
using Azure.Core;
using Azure.Identity;
using Microsoft.Extensions.Configuration;

namespace Azure.CloudMachine;

public class CloudMachineWorkspace : ClientWorkspace
{
    private TokenCredential Credential { get; } = new ChainedTokenCredential(
        new AzureCliCredential(),
        new AzureDeveloperCliCredential()
    );

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string Id { get; }

    [SuppressMessage("Usage", "AZC0007:DO provide a minimal constructor that takes only the parameters required to connect to the service.", Justification = "<Pending>")]
    public CloudMachineWorkspace(TokenCredential credential = default, IConfiguration configuration = default)
    {
        if (credential != default)
        {
            Credential = credential;
        }

        string cmid;
        if (configuration == default)
        {
            cmid = ReadOrCreateCmid();
        }
        else
        {
            cmid = configuration["CloudMachine:ID"];
            if (cmid == null)
                throw new Exception("CloudMachine:ID configuration value missing");
        }

        Id = cmid!;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ClientConnectionOptions GetConnectionOptions(Type clientType, string instanceId = default)
    {
        string clientId = clientType.FullName;
        switch (clientId)
        {
            case "Azure.Security.KeyVault.Secrets.SecretClient":
                return new ClientConnectionOptions(new($"https://{this.Id}.vault.azure.net/"), Credential);
            case "Azure.Messaging.ServiceBus.ServiceBusClient":
                return new ClientConnectionOptions(new($"https://{this.Id}.servicebus.windows.net"), Credential);
            case "Azure.Messaging.ServiceBus.ServiceBusSender":
                if (instanceId == default)
                    instanceId = "cm_servicebus_subscription_private";
                return new ClientConnectionOptions(instanceId);
            case "Azure.Storage.Blobs.BlobContainerClient":
                if (instanceId == default)
                    instanceId = "default";
                return new ClientConnectionOptions(new($"https://{this.Id}.blob.core.windows.net/{instanceId}"), Credential);
            case "Azure.AI.OpenAI.AzureOpenAIClient":
                return new ClientConnectionOptions(new($"https://{this.Id}.openai.azure.com"), Credential);
            case "OpenAI.Chat.ChatClient":
                return new ClientConnectionOptions(Id);
            case "OpenAI.Embeddings.EmbeddingClient":
                return new ClientConnectionOptions($"{Id}-embedding");
            default:
                throw new Exception($"unknown client {clientId}");
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object obj) => base.Equals(obj);
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => base.GetHashCode();
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override string ToString() => Id;

    // TODO: Decide if this should live here.
    internal static string ReadOrCreateCmid()
    {
        string appsettings = Path.Combine(".", "appsettings.json");

        string cmid;
        if (!File.Exists(appsettings))
        {
            cmid = GenerateCloudMachineId();

            using FileStream file = File.OpenWrite(appsettings);
            Utf8JsonWriter writer = new Utf8JsonWriter(file);
            writer.WriteStartObject();
            writer.WritePropertyName("CloudMachine"u8);
            writer.WriteStartObject();
            writer.WriteString("ID"u8, cmid);
            writer.WriteEndObject();
            writer.WriteEndObject();
            writer.Flush();
            return cmid;
        }

        using FileStream json = File.OpenRead(appsettings);
        using JsonDocument jd = JsonDocument.Parse(json);
        JsonElement je = jd.RootElement;
        // attempt to read CM configuration from existing configuration file
        if (je.TryGetProperty("CloudMachine"u8, out JsonElement cm))
        {
            if (!cm.TryGetProperty("ID"u8, out JsonElement id))
            {
                throw new NotImplementedException();
            }
            cmid = id.GetString();
            if (cmid == null)
                throw new NotImplementedException();
            return cmid;
        }
        else
        {   // add CM configuration to existing file
            json.Seek(0, SeekOrigin.Begin);
            JsonNode root = JsonNode.Parse(json);
            json.Close();
            if (root is null || root is not JsonObject obj)
                throw new InvalidOperationException("Existing appsettings.json is not a valid JSON object");

            var cmProperties = new JsonObject();
            cmid = GenerateCloudMachineId();
            cmProperties.Add("ID", cmid);
            obj.Add("CloudMachine", cmProperties);

            using FileStream file = File.OpenWrite(appsettings);
            JsonWriterOptions writerOptions = new()
            {
                Indented = true,
            };
            Utf8JsonWriter writer = new(file, writerOptions);
            JsonSerializerOptions options = new()
            {
                WriteIndented = true,
            };
            root.WriteTo(writer, options);
            writer.Flush();
        }

        return cmid;

        static string GenerateCloudMachineId()
        {
            var guid = Guid.NewGuid();
            var guidString = guid.ToString("N");
            var cnId = "cm" + guidString.Substring(0, 15); // we can increase it to 20, but the template name cannot be that long
            return cnId;
        }
    }
}
