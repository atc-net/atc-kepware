namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.Snmp;

/// <summary>
/// Defines the SNMP device request properties.
/// </summary>
public interface ISnmpDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the SNMP protocol version.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_SNMP_VERSION.
    /// Supported versions: V1, V2c, V3.
    /// Default: V2c (1).
    /// </remarks>
    SnmpVersionType SnmpVersion { get; set; }

    /// <summary>
    /// Gets or sets the port number for SNMP communications.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_COMMUNICATIONS_PORT.
    /// Valid range: 1-65535. Default: 161.
    /// </remarks>
    int Port { get; set; }

    /// <summary>
    /// Gets or sets the IP protocol type.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_COMMUNICATIONS_PROTOCOL.
    /// Default: UDP (1).
    /// </remarks>
    SnmpProtocolType Protocol { get; set; }

    /// <summary>
    /// Gets or sets the community type for SNMP v1/v2c.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_COMMUNITY.
    /// Only used when SNMP version is V1 or V2c.
    /// Default: Public (0).
    /// </remarks>
    SnmpCommunityType Community { get; set; }

    /// <summary>
    /// Gets or sets the custom community string.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_CUSTOM_COMMUNITY.
    /// Only used when Community is Custom.
    /// Default: "public".
    /// </remarks>
    string? CustomCommunity { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of items per SNMP request.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_ITEMS_PER_REQUEST.
    /// Valid range: 1-25. Default: 25.
    /// </remarks>
    int ItemsPerRequest { get; set; }

    /// <summary>
    /// Gets or sets whether to log error messages for non-existent tags.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_LOG_ERROR_MESSAGE_FOR_NON_EXISTENT_TAGS.
    /// Default: true.
    /// </remarks>
    bool LogErrorForMissingTag { get; set; }

    /// <summary>
    /// Gets or sets whether to use the GetBulk command.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_USE_GETBULK_COMMAND.
    /// Not available for SNMPv1.
    /// Default: true.
    /// </remarks>
    bool UseGetBulkCommand { get; set; }

    /// <summary>
    /// Gets or sets whether to deactivate tags on NoSuchObject/Instance or NoSuchName errors.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_DEACTIVATE_TAGS_ON_NOSUCHOBJECT_INSTANCE_NOSUCHNAME_ERRORS.
    /// Default: true.
    /// </remarks>
    bool DeactivateTagsOnErrors { get; set; }

    /// <summary>
    /// Gets or sets the SNMPv3 username.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_USERNAME.
    /// Used only when SNMP version is V3.
    /// Maximum length: 32.
    /// </remarks>
    string? Username { get; set; }

    /// <summary>
    /// Gets or sets the SNMPv3 context name.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_CONTEXT_NAME.
    /// Used only when SNMP version is V3.
    /// Maximum length: 255.
    /// </remarks>
    string? ContextName { get; set; }

    /// <summary>
    /// Gets or sets the SNMPv3 security level.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_SECURITY_LEVEL.
    /// Used only when SNMP version is V3.
    /// Default: NoAuthNoPriv (0).
    /// </remarks>
    SnmpSecurityLevelType SecurityLevel { get; set; }

    /// <summary>
    /// Gets or sets the SNMPv3 authentication style.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_AUTHENTICATION_STYLE.
    /// Used when security level is AuthNoPriv or AuthPriv.
    /// Default: HmacMd5 (0).
    /// </remarks>
    SnmpAuthenticationProtocolType AuthenticationStyle { get; set; }

    /// <summary>
    /// Gets or sets the SNMPv3 authentication passphrase.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_AUTHENTICATION_PASSPHRASE.
    /// Used when security level is AuthNoPriv or AuthPriv.
    /// </remarks>
    string? AuthenticationPassphrase { get; set; }

    /// <summary>
    /// Gets or sets the SNMPv3 encryption style.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_ENCRYPTION_STYLE.
    /// Used when security level is AuthPriv.
    /// Default: Des (0).
    /// </remarks>
    SnmpPrivacyProtocolType EncryptionStyle { get; set; }

    /// <summary>
    /// Gets or sets the SNMPv3 privacy passphrase.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_PRIVACY_PASSPHRASE.
    /// Used when security level is AuthPriv.
    /// </remarks>
    string? PrivacyPassphrase { get; set; }

    /// <summary>
    /// Gets or sets the device template type.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_TEMPLATE.
    /// Default: OtherDevice (3).
    /// </remarks>
    SnmpTemplateType Template { get; set; }

    /// <summary>
    /// Gets or sets the number of Ethernet ports on the device.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_MIB_IMPORT_NUMBER_OF_PORTS.
    /// Valid range: 0-99. Default: 0.
    /// Only used when template is EthernetSwitch, OtherDevice, or None.
    /// </remarks>
    int NumberOfPorts { get; set; }

    /// <summary>
    /// Gets or sets the list of MIB modules for automatic tag generation.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_INCLUDED_MIB_MODULES.
    /// Default: "RFC1213-MIB;".
    /// </remarks>
    string? IncludedMibModules { get; set; }

    /// <summary>
    /// Gets or sets whether SNMP trap/inform support is enabled.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_ENABLE_SNMP_TRAP_INFORM_SUPPORT.
    /// Default: false.
    /// </remarks>
    bool EnableTrapInformSupport { get; set; }

    /// <summary>
    /// Gets or sets the trap/inform listening port.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_TRAP_INFORM_PORT.
    /// Valid range: 1-65535. Default: 162.
    /// Only used when trap/inform support is enabled.
    /// </remarks>
    int TrapInformPort { get; set; }

    /// <summary>
    /// Gets or sets the trap/inform protocol.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_TRAP_INFORM_PROTOCOL.
    /// Default: UDP (1).
    /// Only used when trap/inform support is enabled.
    /// </remarks>
    SnmpProtocolType TrapInformProtocol { get; set; }

    /// <summary>
    /// Gets or sets the trap notification community type.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_TRAP_NOTIFICATION_COMMUNITY.
    /// Default: Custom (2).
    /// Only used when trap/inform support is enabled.
    /// </remarks>
    SnmpCommunityType TrapNotificationCommunity { get; set; }

    /// <summary>
    /// Gets or sets the custom trap notification community string.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_TRAP_NOTIFICATION_CUSTOM_COMMUNITY.
    /// Only used when trap notification community is Custom.
    /// Maximum length: 256.
    /// </remarks>
    string? TrapNotificationCustomCommunity { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of trap/inform events to buffer.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_NUMBER_OF_EVENTS.
    /// Valid range: 1-100. Default: 10.
    /// Only used when trap/inform support is enabled.
    /// </remarks>
    int NumberOfEvents { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of fields per event.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_NUMBER_OF_FIELDS.
    /// Valid range: 1-20. Default: 10.
    /// Only used when trap/inform support is enabled.
    /// </remarks>
    int NumberOfFields { get; set; }

    /// <summary>
    /// Gets or sets whether to encode trap data as Extended ASCII.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_TRAP_ASCII_ENCODING.
    /// Default: false.
    /// Only used when trap/inform support is enabled.
    /// </remarks>
    bool TrapAsciiEncoding { get; set; }

    /// <summary>
    /// Gets or sets whether network analyst tags are enabled.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_ENABLE_NETWORK_ANALYST_TAGS.
    /// Default: false.
    /// Only used when template is EthernetSwitch, OtherDevice, or None.
    /// </remarks>
    bool EnableNetworkAnalystTags { get; set; }

    /// <summary>
    /// Gets or sets the number of ports for the switch device (network analyst).
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_NETWORK_ANALYST_NUMBER_OF_PORTS.
    /// Valid range: 1-99. Default: 1.
    /// Only used when network analyst tags are enabled.
    /// </remarks>
    int NetworkAnalystNumberOfPorts { get; set; }

    /// <summary>
    /// Gets or sets the port offset for network analyst OID polling.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_PORT_OFFSET.
    /// Valid range: 0-65436. Default: 0.
    /// Only used when network analyst tags are enabled.
    /// </remarks>
    int PortOffset { get; set; }

    /// <summary>
    /// Gets or sets the port status 0 limit percentage.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_PORT_STATUS_0_LIMIT.
    /// Valid range: 0-100. Default: 10.
    /// Only used when network analyst tags are enabled.
    /// </remarks>
    int PortStatus0Limit { get; set; }

    /// <summary>
    /// Gets or sets the port status 1 limit percentage.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_PORT_STATUS_1_LIMIT.
    /// Valid range: 0-100. Default: 15.
    /// Only used when network analyst tags are enabled.
    /// </remarks>
    int PortStatus1Limit { get; set; }

    /// <summary>
    /// Gets or sets the number of points in moving average.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_POINTS_IN_MOVING_AVERAGE.
    /// Valid range: 1-200. Default: 30.
    /// Only used when network analyst tags are enabled.
    /// </remarks>
    int PointsInMovingAverage { get; set; }

    /// <summary>
    /// Gets or sets the ports to exclude from highest status limit calculation.
    /// </summary>
    /// <remarks>
    /// Maps to Kepware property: snmp.DEVICE_EXCLUDE_PORTS.
    /// Maximum length: 512.
    /// Only used when network analyst tags are enabled.
    /// </remarks>
    string? ExcludePorts { get; set; }
}