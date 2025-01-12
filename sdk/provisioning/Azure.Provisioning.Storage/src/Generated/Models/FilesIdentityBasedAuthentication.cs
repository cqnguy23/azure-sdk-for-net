// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// Settings for Azure Files identity based authentication.
/// </summary>
public partial class FilesIdentityBasedAuthentication : ProvisionableConstruct
{
    /// <summary>
    /// Indicates the directory service used. Note that this enum may be
    /// extended in the future.
    /// </summary>
    public BicepValue<DirectoryServiceOption> DirectoryServiceOptions { get => _directoryServiceOptions; set => _directoryServiceOptions.Assign(value); }
    private readonly BicepValue<DirectoryServiceOption> _directoryServiceOptions;

    /// <summary>
    /// Required if directoryServiceOptions are AD, optional if they are
    /// AADKERB.
    /// </summary>
    public BicepValue<StorageActiveDirectoryProperties> ActiveDirectoryProperties { get => _activeDirectoryProperties; set => _activeDirectoryProperties.Assign(value); }
    private readonly BicepValue<StorageActiveDirectoryProperties> _activeDirectoryProperties;

    /// <summary>
    /// Default share permission for users using Kerberos authentication if
    /// RBAC role is not assigned.
    /// </summary>
    public BicepValue<DefaultSharePermission> DefaultSharePermission { get => _defaultSharePermission; set => _defaultSharePermission.Assign(value); }
    private readonly BicepValue<DefaultSharePermission> _defaultSharePermission;

    /// <summary>
    /// Creates a new FilesIdentityBasedAuthentication.
    /// </summary>
    public FilesIdentityBasedAuthentication()
    {
        _directoryServiceOptions = BicepValue<DirectoryServiceOption>.DefineProperty(this, "DirectoryServiceOptions", ["directoryServiceOptions"]);
        _activeDirectoryProperties = BicepValue<StorageActiveDirectoryProperties>.DefineProperty(this, "ActiveDirectoryProperties", ["activeDirectoryProperties"]);
        _defaultSharePermission = BicepValue<DefaultSharePermission>.DefineProperty(this, "DefaultSharePermission", ["defaultSharePermission"]);
    }
}
