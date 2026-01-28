namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AlstomRedundantEthernet;

/// <summary>
/// Device properties for the Alstom Redundant Ethernet driver.
/// </summary>
internal sealed class AlstomRedundantEthernetDevice : DeviceBase, IAlstomRedundantEthernetDevice
{
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public AlstomRedundantEthernetDeviceModel Model { get; set; }

    [JsonPropertyName("servermain.DEVICE_CONNECTION_TIMEOUT_SECONDS")]
    public int ConnectTimeoutSeconds { get; set; }

    [JsonPropertyName("servermain.DEVICE_REQUEST_TIMEOUT_MILLISECONDS")]
    public int RequestTimeoutMs { get; set; }

    [JsonPropertyName("servermain.DEVICE_RETRY_ATTEMPTS")]
    public int RetryAttempts { get; set; }

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_ENABLE_ON_COMMUNICATIONS_FAILURES")]
    public bool DemoteOnFailure { get; set; }

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DEMOTE_AFTER_SUCCESSIVE_TIMEOUTS")]
    public int TimeoutsToDemote { get; set; }

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_PERIOD_MS")]
    public int DemotionPeriodMs { get; set; }

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DISCARD_WRITES")]
    public bool DiscardRequestsWhenDemoted { get; set; }

    [JsonPropertyName("alstom_redundant_ethernet.DEVICE_PRIMARY_NORMAL_IP")]
    public string PrimaryNormalIp { get; set; } = string.Empty;

    [JsonPropertyName("alstom_redundant_ethernet.DEVICE_PRIMARY_NORMAL_PORT")]
    public int PrimaryNormalPort { get; set; }

    [JsonPropertyName("alstom_redundant_ethernet.DEVICE_PRIMARY_STANDBY_IP")]
    public string PrimaryStandbyIp { get; set; } = string.Empty;

    [JsonPropertyName("alstom_redundant_ethernet.DEVICE_PRIMARY_STANDBY_PORT")]
    public int PrimaryStandbyPort { get; set; }

    [JsonPropertyName("alstom_redundant_ethernet.DEVICE_SECONDARY_NORMAL_IP")]
    public string SecondaryNormalIp { get; set; } = string.Empty;

    [JsonPropertyName("alstom_redundant_ethernet.DEVICE_SECONDARY_NORMAL_PORT")]
    public int SecondaryNormalPort { get; set; }

    [JsonPropertyName("alstom_redundant_ethernet.DEVICE_SECONDARY_STANDBY_IP")]
    public string SecondaryStandbyIp { get; set; } = string.Empty;

    [JsonPropertyName("alstom_redundant_ethernet.DEVICE_SECONDARY_STANDBY_PORT")]
    public int SecondaryStandbyPort { get; set; }

    [JsonPropertyName("alstom_redundant_ethernet.DEVICE_OUTPUT_COILS")]
    public int OutputCoilsBlockSize { get; set; }

    [JsonPropertyName("alstom_redundant_ethernet.DEVICE_INPUT_COILS")]
    public int InputCoilsBlockSize { get; set; }

    [JsonPropertyName("alstom_redundant_ethernet.DEVICE_INTERNAL_REGISTERS")]
    public int InternalRegistersBlockSize { get; set; }

    [JsonPropertyName("alstom_redundant_ethernet.DEVICE_HOLDING_REGISTERS")]
    public int HoldingRegistersBlockSize { get; set; }

    [JsonPropertyName("alstom_redundant_ethernet.DEVICE_RESET_AFTER")]
    public int InvalidSequenceNumbersBeforeReset { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(PrimaryNormalIp)}: {PrimaryNormalIp}, {nameof(PrimaryNormalPort)}: {PrimaryNormalPort}";
}
