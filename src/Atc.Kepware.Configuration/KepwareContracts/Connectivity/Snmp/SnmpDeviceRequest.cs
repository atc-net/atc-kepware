namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.Snmp;

/// <summary>
/// Device request properties for the SNMP driver.
/// </summary>
internal sealed class SnmpDeviceRequest : DeviceRequestBase, ISnmpDeviceRequest
{
    public SnmpDeviceRequest()
        : base(DriverType.Snmp)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_SNMP_VERSION")]
    public SnmpVersionType SnmpVersion { get; set; } = SnmpVersionType.V2c;

    /// <inheritdoc />
    [Range(1, 65535)]
    [JsonPropertyName("snmp.DEVICE_COMMUNICATIONS_PORT")]
    public int Port { get; set; } = 161;

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_COMMUNICATIONS_PROTOCOL")]
    public SnmpProtocolType Protocol { get; set; } = SnmpProtocolType.Udp;

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_COMMUNITY")]
    public SnmpCommunityType Community { get; set; } = SnmpCommunityType.Public;

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_CUSTOM_COMMUNITY")]
    public string? CustomCommunity { get; set; } = "public";

    /// <inheritdoc />
    [Range(1, 25)]
    [JsonPropertyName("snmp.DEVICE_ITEMS_PER_REQUEST")]
    public int ItemsPerRequest { get; set; } = 25;

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_LOG_ERROR_MESSAGE_FOR_NON_EXISTENT_TAGS")]
    public bool LogErrorForMissingTag { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_USE_GETBULK_COMMAND")]
    public bool UseGetBulkCommand { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_DEACTIVATE_TAGS_ON_NOSUCHOBJECT_INSTANCE_NOSUCHNAME_ERRORS")]
    public bool DeactivateTagsOnErrors { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_USERNAME")]
    public string? Username { get; set; } = string.Empty;

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_CONTEXT_NAME")]
    public string? ContextName { get; set; } = string.Empty;

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_SECURITY_LEVEL")]
    public SnmpSecurityLevelType SecurityLevel { get; set; } = SnmpSecurityLevelType.NoAuthNoPriv;

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_AUTHENTICATION_STYLE")]
    public SnmpAuthenticationProtocolType AuthenticationStyle { get; set; } = SnmpAuthenticationProtocolType.HmacMd5;

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_AUTHENTICATION_PASSPHRASE")]
    public string? AuthenticationPassphrase { get; set; } = string.Empty;

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_ENCRYPTION_STYLE")]
    public SnmpPrivacyProtocolType EncryptionStyle { get; set; } = SnmpPrivacyProtocolType.Des;

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_PRIVACY_PASSPHRASE")]
    public string? PrivacyPassphrase { get; set; } = string.Empty;

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_TEMPLATE")]
    public SnmpTemplateType Template { get; set; } = SnmpTemplateType.OtherDevice;

    /// <inheritdoc />
    [Range(0, 99)]
    [JsonPropertyName("snmp.DEVICE_MIB_IMPORT_NUMBER_OF_PORTS")]
    public int NumberOfPorts { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_INCLUDED_MIB_MODULES")]
    public string? IncludedMibModules { get; set; } = "RFC1213-MIB;";

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_ENABLE_SNMP_TRAP_INFORM_SUPPORT")]
    public bool EnableTrapInformSupport { get; set; }

    /// <inheritdoc />
    [Range(1, 65535)]
    [JsonPropertyName("snmp.DEVICE_TRAP_INFORM_PORT")]
    public int TrapInformPort { get; set; } = 162;

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_TRAP_INFORM_PROTOCOL")]
    public SnmpProtocolType TrapInformProtocol { get; set; } = SnmpProtocolType.Udp;

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_TRAP_NOTIFICATION_COMMUNITY")]
    public SnmpCommunityType TrapNotificationCommunity { get; set; } = SnmpCommunityType.Custom;

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_TRAP_NOTIFICATION_CUSTOM_COMMUNITY")]
    public string? TrapNotificationCustomCommunity { get; set; } = string.Empty;

    /// <inheritdoc />
    [Range(1, 100)]
    [JsonPropertyName("snmp.DEVICE_NUMBER_OF_EVENTS")]
    public int NumberOfEvents { get; set; } = 10;

    /// <inheritdoc />
    [Range(1, 20)]
    [JsonPropertyName("snmp.DEVICE_NUMBER_OF_FIELDS")]
    public int NumberOfFields { get; set; } = 10;

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_TRAP_ASCII_ENCODING")]
    public bool TrapAsciiEncoding { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_ENABLE_NETWORK_ANALYST_TAGS")]
    public bool EnableNetworkAnalystTags { get; set; }

    /// <inheritdoc />
    [Range(1, 99)]
    [JsonPropertyName("snmp.DEVICE_NETWORK_ANALYST_NUMBER_OF_PORTS")]
    public int NetworkAnalystNumberOfPorts { get; set; } = 1;

    /// <inheritdoc />
    [Range(0, 65436)]
    [JsonPropertyName("snmp.DEVICE_PORT_OFFSET")]
    public int PortOffset { get; set; }

    /// <inheritdoc />
    [Range(0, 100)]
    [JsonPropertyName("snmp.DEVICE_PORT_STATUS_0_LIMIT")]
    public int PortStatus0Limit { get; set; } = 10;

    /// <inheritdoc />
    [Range(0, 100)]
    [JsonPropertyName("snmp.DEVICE_PORT_STATUS_1_LIMIT")]
    public int PortStatus1Limit { get; set; } = 15;

    /// <inheritdoc />
    [Range(1, 200)]
    [JsonPropertyName("snmp.DEVICE_POINTS_IN_MOVING_AVERAGE")]
    public int PointsInMovingAverage { get; set; } = 30;

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_EXCLUDE_PORTS")]
    public string? ExcludePorts { get; set; } = string.Empty;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(SnmpVersion)}: {SnmpVersion}, {nameof(Port)}: {Port}";
}