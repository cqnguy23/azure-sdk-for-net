// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// A tag of the LegalHold of a blob container.
/// </summary>
public partial class LegalHoldTag : ProvisionableConstruct
{
    /// <summary>
    /// The tag value.
    /// </summary>
    public BicepValue<string> Tag { get => _tag; }
    private readonly BicepValue<string> _tag;

    /// <summary>
    /// Returns the date and time the tag was added.
    /// </summary>
    public BicepValue<DateTimeOffset> Timestamp { get => _timestamp; }
    private readonly BicepValue<DateTimeOffset> _timestamp;

    /// <summary>
    /// Returns the Object ID of the user who added the tag.
    /// </summary>
    public BicepValue<string> ObjectIdentifier { get => _objectIdentifier; }
    private readonly BicepValue<string> _objectIdentifier;

    /// <summary>
    /// Returns the Tenant ID that issued the token for the user who added the
    /// tag.
    /// </summary>
    public BicepValue<Guid> TenantId { get => _tenantId; }
    private readonly BicepValue<Guid> _tenantId;

    /// <summary>
    /// Returns the User Principal Name of the user who added the tag.
    /// </summary>
    public BicepValue<string> Upn { get => _upn; }
    private readonly BicepValue<string> _upn;

    /// <summary>
    /// Creates a new LegalHoldTag.
    /// </summary>
    public LegalHoldTag()
    {
        _tag = BicepValue<string>.DefineProperty(this, "Tag", ["tag"], isOutput: true);
        _timestamp = BicepValue<DateTimeOffset>.DefineProperty(this, "Timestamp", ["timestamp"], isOutput: true);
        _objectIdentifier = BicepValue<string>.DefineProperty(this, "ObjectIdentifier", ["objectIdentifier"], isOutput: true);
        _tenantId = BicepValue<Guid>.DefineProperty(this, "TenantId", ["tenantId"], isOutput: true);
        _upn = BicepValue<string>.DefineProperty(this, "Upn", ["upn"], isOutput: true);
    }
}
