// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.Sql;

/// <summary>
/// ManagedInstance.
/// </summary>
public partial class ManagedInstance : ProvisionableResource
{
    /// <summary>
    /// The name of the managed instance.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Administrator username for the managed instance. Can only be specified
    /// when the managed instance is being created (and is required for
    /// creation).
    /// </summary>
    public BicepValue<string> AdministratorLogin { get => _administratorLogin; set => _administratorLogin.Assign(value); }
    private readonly BicepValue<string> _administratorLogin;

    /// <summary>
    /// The administrator login password (required for managed instance
    /// creation).
    /// </summary>
    public BicepValue<string> AdministratorLoginPassword { get => _administratorLoginPassword; set => _administratorLoginPassword.Assign(value); }
    private readonly BicepValue<string> _administratorLoginPassword;

    /// <summary>
    /// The Azure Active Directory administrator of the instance. This can only
    /// be used at instance create time. If used for instance update, it will
    /// be ignored or it will result in an error. For updates individual APIs
    /// will need to be used.
    /// </summary>
    public BicepValue<ManagedInstanceExternalAdministrator> Administrators { get => _administrators; set => _administrators.Assign(value); }
    private readonly BicepValue<ManagedInstanceExternalAdministrator> _administrators;

    /// <summary>
    /// Collation of the managed instance.
    /// </summary>
    public BicepValue<string> Collation { get => _collation; set => _collation.Assign(value); }
    private readonly BicepValue<string> _collation;

    /// <summary>
    /// The Azure Active Directory identity of the managed instance.
    /// </summary>
    public BicepValue<ManagedServiceIdentity> Identity { get => _identity; set => _identity.Assign(value); }
    private readonly BicepValue<ManagedServiceIdentity> _identity;

    /// <summary>
    /// The Id of the instance pool this managed server belongs to.
    /// </summary>
    public BicepValue<ResourceIdentifier> InstancePoolId { get => _instancePoolId; set => _instancePoolId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _instancePoolId;

    /// <summary>
    /// Whether or not the public data endpoint is enabled.
    /// </summary>
    public BicepValue<bool> IsPublicDataEndpointEnabled { get => _isPublicDataEndpointEnabled; set => _isPublicDataEndpointEnabled.Assign(value); }
    private readonly BicepValue<bool> _isPublicDataEndpointEnabled;

    /// <summary>
    /// Whether or not the multi-az is enabled.
    /// </summary>
    public BicepValue<bool> IsZoneRedundant { get => _isZoneRedundant; set => _isZoneRedundant.Assign(value); }
    private readonly BicepValue<bool> _isZoneRedundant;

    /// <summary>
    /// A CMK URI of the key to use for encryption.
    /// </summary>
    public BicepValue<Uri> KeyId { get => _keyId; set => _keyId.Assign(value); }
    private readonly BicepValue<Uri> _keyId;

    /// <summary>
    /// The license type. Possible values are &apos;LicenseIncluded&apos;
    /// (regular price inclusive of a new SQL license) and
    /// &apos;BasePrice&apos; (discounted AHB price for bringing your own SQL
    /// licenses).
    /// </summary>
    public BicepValue<ManagedInstanceLicenseType> LicenseType { get => _licenseType; set => _licenseType.Assign(value); }
    private readonly BicepValue<ManagedInstanceLicenseType> _licenseType;

    /// <summary>
    /// Specifies maintenance configuration id to apply to this managed
    /// instance.
    /// </summary>
    public BicepValue<ResourceIdentifier> MaintenanceConfigurationId { get => _maintenanceConfigurationId; set => _maintenanceConfigurationId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _maintenanceConfigurationId;

    /// <summary>
    /// The resource id of another managed instance whose DNS zone this managed
    /// instance will share after creation.
    /// </summary>
    public BicepValue<ResourceIdentifier> ManagedDnsZonePartner { get => _managedDnsZonePartner; set => _managedDnsZonePartner.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _managedDnsZonePartner;

    /// <summary>
    /// Specifies the mode of database creation.
    /// Default: Regular instance creation.
    /// Restore: Creates an instance by restoring a
    /// set of backups to specific point in time. RestorePointInTime and
    /// SourceManagedInstanceId must be specified.
    /// </summary>
    public BicepValue<ManagedServerCreateMode> ManagedInstanceCreateMode { get => _managedInstanceCreateMode; set => _managedInstanceCreateMode.Assign(value); }
    private readonly BicepValue<ManagedServerCreateMode> _managedInstanceCreateMode;

    /// <summary>
    /// Minimal TLS version. Allowed values: &apos;None&apos;, &apos;1.0&apos;,
    /// &apos;1.1&apos;, &apos;1.2&apos;.
    /// </summary>
    public BicepValue<string> MinimalTlsVersion { get => _minimalTlsVersion; set => _minimalTlsVersion.Assign(value); }
    private readonly BicepValue<string> _minimalTlsVersion;

    /// <summary>
    /// The resource id of a user assigned identity to be used by default.
    /// </summary>
    public BicepValue<ResourceIdentifier> PrimaryUserAssignedIdentityId { get => _primaryUserAssignedIdentityId; set => _primaryUserAssignedIdentityId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _primaryUserAssignedIdentityId;

    /// <summary>
    /// Connection type used for connecting to the instance.
    /// </summary>
    public BicepValue<ManagedInstanceProxyOverride> ProxyOverride { get => _proxyOverride; set => _proxyOverride.Assign(value); }
    private readonly BicepValue<ManagedInstanceProxyOverride> _proxyOverride;

    /// <summary>
    /// The storage account type to be used to store backups for this instance.
    /// The options are Local (LocallyRedundantStorage), Zone
    /// (ZoneRedundantStorage), Geo (GeoRedundantStorage) and
    /// GeoZone(GeoZoneRedundantStorage).
    /// </summary>
    public BicepValue<SqlBackupStorageRedundancy> RequestedBackupStorageRedundancy { get => _requestedBackupStorageRedundancy; set => _requestedBackupStorageRedundancy.Assign(value); }
    private readonly BicepValue<SqlBackupStorageRedundancy> _requestedBackupStorageRedundancy;

    /// <summary>
    /// Specifies the point in time (ISO8601 format) of the source database
    /// that will be restored to create the new database.
    /// </summary>
    public BicepValue<DateTimeOffset> RestorePointInTime { get => _restorePointInTime; set => _restorePointInTime.Assign(value); }
    private readonly BicepValue<DateTimeOffset> _restorePointInTime;

    /// <summary>
    /// The managed instance&apos;s service principal.
    /// </summary>
    public BicepValue<SqlServicePrincipal> ServicePrincipal { get => _servicePrincipal; set => _servicePrincipal.Assign(value); }
    private readonly BicepValue<SqlServicePrincipal> _servicePrincipal;

    /// <summary>
    /// Managed instance SKU. Allowed values for sku.name: GP_Gen5, GP_G8IM,
    /// GP_G8IH, BC_Gen5, BC_G8IM, BC_G8IH.
    /// </summary>
    public BicepValue<SqlSku> Sku { get => _sku; set => _sku.Assign(value); }
    private readonly BicepValue<SqlSku> _sku;

    /// <summary>
    /// The resource identifier of the source managed instance associated with
    /// create operation of this instance.
    /// </summary>
    public BicepValue<ResourceIdentifier> SourceManagedInstanceId { get => _sourceManagedInstanceId; set => _sourceManagedInstanceId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _sourceManagedInstanceId;

    /// <summary>
    /// Storage size in GB. Minimum value: 32. Maximum value: 16384. Increments
    /// of 32 GB allowed only. Maximum value depends on the selected hardware
    /// family and number of vCores.
    /// </summary>
    public BicepValue<int> StorageSizeInGB { get => _storageSizeInGB; set => _storageSizeInGB.Assign(value); }
    private readonly BicepValue<int> _storageSizeInGB;

    /// <summary>
    /// Subnet resource ID for the managed instance.
    /// </summary>
    public BicepValue<ResourceIdentifier> SubnetId { get => _subnetId; set => _subnetId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _subnetId;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Id of the timezone. Allowed values are timezones supported by Windows.
    /// Windows keeps details on supported timezones, including
    /// the id, in registry under
    /// KEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows
    /// NT\CurrentVersion\Time Zones.             You can get those registry
    /// values via SQL Server by querying SELECT name AS timezone_id FROM
    /// sys.time_zone_info.             List of Ids can also be obtained by
    /// executing [System.TimeZoneInfo]::GetSystemTimeZones() in PowerShell.
    /// An example of valid timezone id is &quot;Pacific Standard
    /// Time&quot; or &quot;W. Europe Standard Time&quot;.
    /// </summary>
    public BicepValue<string> TimezoneId { get => _timezoneId; set => _timezoneId.Assign(value); }
    private readonly BicepValue<string> _timezoneId;

    /// <summary>
    /// The number of vCores. Allowed values: 8, 16, 24, 32, 40, 64, 80.
    /// </summary>
    public BicepValue<int> VCores { get => _vCores; set => _vCores.Assign(value); }
    private readonly BicepValue<int> _vCores;

    /// <summary>
    /// The storage account type used to store backups for this instance. The
    /// options are Local (LocallyRedundantStorage), Zone
    /// (ZoneRedundantStorage), Geo (GeoRedundantStorage) and
    /// GeoZone(GeoZoneRedundantStorage).
    /// </summary>
    public BicepValue<SqlBackupStorageRedundancy> CurrentBackupStorageRedundancy { get => _currentBackupStorageRedundancy; }
    private readonly BicepValue<SqlBackupStorageRedundancy> _currentBackupStorageRedundancy;

    /// <summary>
    /// The Dns Zone that the managed instance is in.
    /// </summary>
    public BicepValue<string> DnsZone { get => _dnsZone; }
    private readonly BicepValue<string> _dnsZone;

    /// <summary>
    /// The fully qualified domain name of the managed instance.
    /// </summary>
    public BicepValue<string> FullyQualifiedDomainName { get => _fullyQualifiedDomainName; }
    private readonly BicepValue<string> _fullyQualifiedDomainName;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// List of private endpoint connections on a managed instance.
    /// </summary>
    public BicepList<ManagedInstancePecProperty> PrivateEndpointConnections { get => _privateEndpointConnections; }
    private readonly BicepList<ManagedInstancePecProperty> _privateEndpointConnections;

    /// <summary>
    /// Gets the provisioning state.
    /// </summary>
    public BicepValue<ManagedInstancePropertiesProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<ManagedInstancePropertiesProvisioningState> _provisioningState;

    /// <summary>
    /// The state of the managed instance.
    /// </summary>
    public BicepValue<string> State { get => _state; }
    private readonly BicepValue<string> _state;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Creates a new ManagedInstance.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ManagedInstance resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ManagedInstance.</param>
    public ManagedInstance(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Sql/managedInstances", resourceVersion ?? "2021-11-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _administratorLogin = BicepValue<string>.DefineProperty(this, "AdministratorLogin", ["properties", "administratorLogin"]);
        _administratorLoginPassword = BicepValue<string>.DefineProperty(this, "AdministratorLoginPassword", ["properties", "administratorLoginPassword"]);
        _administrators = BicepValue<ManagedInstanceExternalAdministrator>.DefineProperty(this, "Administrators", ["properties", "administrators"]);
        _collation = BicepValue<string>.DefineProperty(this, "Collation", ["properties", "collation"]);
        _identity = BicepValue<ManagedServiceIdentity>.DefineProperty(this, "Identity", ["identity"]);
        _instancePoolId = BicepValue<ResourceIdentifier>.DefineProperty(this, "InstancePoolId", ["properties", "instancePoolId"]);
        _isPublicDataEndpointEnabled = BicepValue<bool>.DefineProperty(this, "IsPublicDataEndpointEnabled", ["properties", "publicDataEndpointEnabled"]);
        _isZoneRedundant = BicepValue<bool>.DefineProperty(this, "IsZoneRedundant", ["properties", "zoneRedundant"]);
        _keyId = BicepValue<Uri>.DefineProperty(this, "KeyId", ["properties", "keyId"]);
        _licenseType = BicepValue<ManagedInstanceLicenseType>.DefineProperty(this, "LicenseType", ["properties", "licenseType"]);
        _maintenanceConfigurationId = BicepValue<ResourceIdentifier>.DefineProperty(this, "MaintenanceConfigurationId", ["properties", "maintenanceConfigurationId"]);
        _managedDnsZonePartner = BicepValue<ResourceIdentifier>.DefineProperty(this, "ManagedDnsZonePartner", ["properties", "dnsZonePartner"]);
        _managedInstanceCreateMode = BicepValue<ManagedServerCreateMode>.DefineProperty(this, "ManagedInstanceCreateMode", ["properties", "managedInstanceCreateMode"]);
        _minimalTlsVersion = BicepValue<string>.DefineProperty(this, "MinimalTlsVersion", ["properties", "minimalTlsVersion"]);
        _primaryUserAssignedIdentityId = BicepValue<ResourceIdentifier>.DefineProperty(this, "PrimaryUserAssignedIdentityId", ["properties", "primaryUserAssignedIdentityId"]);
        _proxyOverride = BicepValue<ManagedInstanceProxyOverride>.DefineProperty(this, "ProxyOverride", ["properties", "proxyOverride"]);
        _requestedBackupStorageRedundancy = BicepValue<SqlBackupStorageRedundancy>.DefineProperty(this, "RequestedBackupStorageRedundancy", ["properties", "requestedBackupStorageRedundancy"]);
        _restorePointInTime = BicepValue<DateTimeOffset>.DefineProperty(this, "RestorePointInTime", ["properties", "restorePointInTime"]);
        _servicePrincipal = BicepValue<SqlServicePrincipal>.DefineProperty(this, "ServicePrincipal", ["properties", "servicePrincipal"]);
        _sku = BicepValue<SqlSku>.DefineProperty(this, "Sku", ["sku"]);
        _sourceManagedInstanceId = BicepValue<ResourceIdentifier>.DefineProperty(this, "SourceManagedInstanceId", ["properties", "sourceManagedInstanceId"]);
        _storageSizeInGB = BicepValue<int>.DefineProperty(this, "StorageSizeInGB", ["properties", "storageSizeInGB"]);
        _subnetId = BicepValue<ResourceIdentifier>.DefineProperty(this, "SubnetId", ["properties", "subnetId"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _timezoneId = BicepValue<string>.DefineProperty(this, "TimezoneId", ["properties", "timezoneId"]);
        _vCores = BicepValue<int>.DefineProperty(this, "VCores", ["properties", "vCores"]);
        _currentBackupStorageRedundancy = BicepValue<SqlBackupStorageRedundancy>.DefineProperty(this, "CurrentBackupStorageRedundancy", ["properties", "currentBackupStorageRedundancy"], isOutput: true);
        _dnsZone = BicepValue<string>.DefineProperty(this, "DnsZone", ["properties", "dnsZone"], isOutput: true);
        _fullyQualifiedDomainName = BicepValue<string>.DefineProperty(this, "FullyQualifiedDomainName", ["properties", "fullyQualifiedDomainName"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _privateEndpointConnections = BicepList<ManagedInstancePecProperty>.DefineProperty(this, "PrivateEndpointConnections", ["properties", "privateEndpointConnections"], isOutput: true);
        _provisioningState = BicepValue<ManagedInstancePropertiesProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _state = BicepValue<string>.DefineProperty(this, "State", ["properties", "state"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported ManagedInstance resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";
    }

    /// <summary>
    /// Creates a reference to an existing ManagedInstance.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ManagedInstance resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ManagedInstance.</param>
    /// <returns>The existing ManagedInstance resource.</returns>
    public static ManagedInstance FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this ManagedInstance resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 1, maxLength: 63, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen);
}
