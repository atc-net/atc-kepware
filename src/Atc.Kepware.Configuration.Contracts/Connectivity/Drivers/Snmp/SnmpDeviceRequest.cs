namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.Snmp;

/// <summary>
/// Represents an SNMP device creation request.
/// </summary>
public class SnmpDeviceRequest : DeviceRequestBase, ISnmpDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SnmpDeviceRequest"/> class.
    /// </summary>
    public SnmpDeviceRequest()
        : base(DriverType.Snmp)
    {
    }

    /// <inheritdoc />
    public SnmpVersionType SnmpVersion { get; set; } = SnmpVersionType.V2c;

    /// <inheritdoc />
    [Range(1, 65535)]
    public int Port { get; set; } = 161;

    /// <inheritdoc />
    public SnmpProtocolType Protocol { get; set; } = SnmpProtocolType.Udp;

    /// <inheritdoc />
    public SnmpCommunityType Community { get; set; } = SnmpCommunityType.Public;

    /// <inheritdoc />
    [MaxLength(256)]
    public string? CustomCommunity { get; set; } = "public";

    /// <inheritdoc />
    [Range(1, 25)]
    public int ItemsPerRequest { get; set; } = 25;

    /// <inheritdoc />
    public bool LogErrorForMissingTag { get; set; } = true;

    /// <inheritdoc />
    public bool UseGetBulkCommand { get; set; } = true;

    /// <inheritdoc />
    public bool DeactivateTagsOnErrors { get; set; } = true;

    /// <inheritdoc />
    [MaxLength(32)]
    public string? Username { get; set; } = string.Empty;

    /// <inheritdoc />
    [MaxLength(255)]
    public string? ContextName { get; set; } = string.Empty;

    /// <inheritdoc />
    public SnmpSecurityLevelType SecurityLevel { get; set; } = SnmpSecurityLevelType.NoAuthNoPriv;

    /// <inheritdoc />
    public SnmpAuthenticationProtocolType AuthenticationStyle { get; set; } = SnmpAuthenticationProtocolType.HmacMd5;

    /// <inheritdoc />
    public string? AuthenticationPassphrase { get; set; } = string.Empty;

    /// <inheritdoc />
    public SnmpPrivacyProtocolType EncryptionStyle { get; set; } = SnmpPrivacyProtocolType.Des;

    /// <inheritdoc />
    public string? PrivacyPassphrase { get; set; } = string.Empty;

    /// <inheritdoc />
    public SnmpTemplateType Template { get; set; } = SnmpTemplateType.OtherDevice;

    /// <inheritdoc />
    [Range(0, 99)]
    public int NumberOfPorts { get; set; }

    /// <inheritdoc />
    public string? IncludedMibModules { get; set; } = "RFC1213-MIB;";

    /// <inheritdoc />
    public bool EnableTrapInformSupport { get; set; }

    /// <inheritdoc />
    [Range(1, 65535)]
    public int TrapInformPort { get; set; } = 162;

    /// <inheritdoc />
    public SnmpProtocolType TrapInformProtocol { get; set; } = SnmpProtocolType.Udp;

    /// <inheritdoc />
    public SnmpCommunityType TrapNotificationCommunity { get; set; } = SnmpCommunityType.Custom;

    /// <inheritdoc />
    [MaxLength(256)]
    public string? TrapNotificationCustomCommunity { get; set; } = string.Empty;

    /// <inheritdoc />
    [Range(1, 100)]
    public int NumberOfEvents { get; set; } = 10;

    /// <inheritdoc />
    [Range(1, 20)]
    public int NumberOfFields { get; set; } = 10;

    /// <inheritdoc />
    public bool TrapAsciiEncoding { get; set; }

    /// <inheritdoc />
    public bool EnableNetworkAnalystTags { get; set; }

    /// <inheritdoc />
    [Range(1, 99)]
    public int NetworkAnalystNumberOfPorts { get; set; } = 1;

    /// <inheritdoc />
    [Range(0, 65436)]
    public int PortOffset { get; set; }

    /// <inheritdoc />
    [Range(0, 100)]
    public int PortStatus0Limit { get; set; } = 10;

    /// <inheritdoc />
    [Range(0, 100)]
    public int PortStatus1Limit { get; set; } = 15;

    /// <inheritdoc />
    [Range(1, 200)]
    public int PointsInMovingAverage { get; set; } = 30;

    /// <inheritdoc />
    [MaxLength(512)]
    public string? ExcludePorts { get; set; } = string.Empty;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(SnmpVersion)}: {SnmpVersion}, {nameof(Port)}: {Port}";
}