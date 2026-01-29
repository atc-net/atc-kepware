namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.Snmp;

/// <summary>
/// Represents an SNMP device.
/// </summary>
public class SnmpDevice : DeviceBase, ISnmpDevice
{
    /// <inheritdoc />
    public SnmpVersionType SnmpVersion { get; set; }

    /// <inheritdoc />
    public int Port { get; set; }

    /// <inheritdoc />
    public SnmpProtocolType Protocol { get; set; }

    /// <inheritdoc />
    public SnmpCommunityType Community { get; set; }

    /// <inheritdoc />
    public string? CustomCommunity { get; set; }

    /// <inheritdoc />
    public int ItemsPerRequest { get; set; }

    /// <inheritdoc />
    public bool LogErrorForMissingTag { get; set; }

    /// <inheritdoc />
    public bool UseGetBulkCommand { get; set; }

    /// <inheritdoc />
    public bool DeactivateTagsOnErrors { get; set; }

    /// <inheritdoc />
    public string? Username { get; set; }

    /// <inheritdoc />
    public string? ContextName { get; set; }

    /// <inheritdoc />
    public SnmpSecurityLevelType SecurityLevel { get; set; }

    /// <inheritdoc />
    public SnmpAuthenticationProtocolType AuthenticationStyle { get; set; }

    /// <inheritdoc />
    public string? AuthenticationPassphrase { get; set; }

    /// <inheritdoc />
    public SnmpPrivacyProtocolType EncryptionStyle { get; set; }

    /// <inheritdoc />
    public string? PrivacyPassphrase { get; set; }

    /// <inheritdoc />
    public SnmpTemplateType Template { get; set; }

    /// <inheritdoc />
    public int NumberOfPorts { get; set; }

    /// <inheritdoc />
    public string? IncludedMibModules { get; set; }

    /// <inheritdoc />
    public bool EnableTrapInformSupport { get; set; }

    /// <inheritdoc />
    public int TrapInformPort { get; set; }

    /// <inheritdoc />
    public SnmpProtocolType TrapInformProtocol { get; set; }

    /// <inheritdoc />
    public SnmpCommunityType TrapNotificationCommunity { get; set; }

    /// <inheritdoc />
    public string? TrapNotificationCustomCommunity { get; set; }

    /// <inheritdoc />
    public int NumberOfEvents { get; set; }

    /// <inheritdoc />
    public int NumberOfFields { get; set; }

    /// <inheritdoc />
    public bool TrapAsciiEncoding { get; set; }

    /// <inheritdoc />
    public bool EnableNetworkAnalystTags { get; set; }

    /// <inheritdoc />
    public int NetworkAnalystNumberOfPorts { get; set; }

    /// <inheritdoc />
    public int PortOffset { get; set; }

    /// <inheritdoc />
    public int PortStatus0Limit { get; set; }

    /// <inheritdoc />
    public int PortStatus1Limit { get; set; }

    /// <inheritdoc />
    public int PointsInMovingAverage { get; set; }

    /// <inheritdoc />
    public string? ExcludePorts { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(SnmpVersion)}: {SnmpVersion}, {nameof(Port)}: {Port}";
}