namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.Snmp;

/// <summary>
/// Device properties for the SNMP driver.
/// </summary>
internal sealed class SnmpDevice : DeviceBase, ISnmpDevice
{
    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_SNMP_VERSION")]
    public SnmpVersionType SnmpVersion { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_COMMUNICATIONS_PORT")]
    public int Port { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_COMMUNICATIONS_PROTOCOL")]
    public SnmpProtocolType Protocol { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_COMMUNITY")]
    public SnmpCommunityType Community { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_CUSTOM_COMMUNITY")]
    public string? CustomCommunity { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_ITEMS_PER_REQUEST")]
    public int ItemsPerRequest { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_LOG_ERROR_MESSAGE_FOR_NON_EXISTENT_TAGS")]
    public bool LogErrorForMissingTag { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_USE_GETBULK_COMMAND")]
    public bool UseGetBulkCommand { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_DEACTIVATE_TAGS_ON_NOSUCHOBJECT_INSTANCE_NOSUCHNAME_ERRORS")]
    public bool DeactivateTagsOnErrors { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_USERNAME")]
    public string? Username { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_CONTEXT_NAME")]
    public string? ContextName { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_SECURITY_LEVEL")]
    public SnmpSecurityLevelType SecurityLevel { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_AUTHENTICATION_STYLE")]
    public SnmpAuthenticationProtocolType AuthenticationStyle { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_AUTHENTICATION_PASSPHRASE")]
    public string? AuthenticationPassphrase { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_ENCRYPTION_STYLE")]
    public SnmpPrivacyProtocolType EncryptionStyle { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_PRIVACY_PASSPHRASE")]
    public string? PrivacyPassphrase { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_TEMPLATE")]
    public SnmpTemplateType Template { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_MIB_IMPORT_NUMBER_OF_PORTS")]
    public int NumberOfPorts { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_INCLUDED_MIB_MODULES")]
    public string? IncludedMibModules { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_ENABLE_SNMP_TRAP_INFORM_SUPPORT")]
    public bool EnableTrapInformSupport { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_TRAP_INFORM_PORT")]
    public int TrapInformPort { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_TRAP_INFORM_PROTOCOL")]
    public SnmpProtocolType TrapInformProtocol { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_TRAP_NOTIFICATION_COMMUNITY")]
    public SnmpCommunityType TrapNotificationCommunity { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_TRAP_NOTIFICATION_CUSTOM_COMMUNITY")]
    public string? TrapNotificationCustomCommunity { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_NUMBER_OF_EVENTS")]
    public int NumberOfEvents { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_NUMBER_OF_FIELDS")]
    public int NumberOfFields { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_TRAP_ASCII_ENCODING")]
    public bool TrapAsciiEncoding { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_ENABLE_NETWORK_ANALYST_TAGS")]
    public bool EnableNetworkAnalystTags { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_NETWORK_ANALYST_NUMBER_OF_PORTS")]
    public int NetworkAnalystNumberOfPorts { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_PORT_OFFSET")]
    public int PortOffset { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_PORT_STATUS_0_LIMIT")]
    public int PortStatus0Limit { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_PORT_STATUS_1_LIMIT")]
    public int PortStatus1Limit { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_POINTS_IN_MOVING_AVERAGE")]
    public int PointsInMovingAverage { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("snmp.DEVICE_EXCLUDE_PORTS")]
    public string? ExcludePorts { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(SnmpVersion)}: {SnmpVersion}, {nameof(Port)}: {Port}";
}
