namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.KraussMaffeiMc4Ethernet;

/// <summary>
/// Device properties for the KraussMaffei MC4 Ethernet driver.
/// </summary>
internal sealed class KraussMaffeiMc4EthernetDevice : DeviceBase, IKraussMaffeiMc4EthernetDevice
{
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = string.Empty;

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

    [JsonPropertyName("kraussmaffei_mc4_ethernet.DEVICE_PORT")]
    public int Port { get; set; }

    [JsonPropertyName("kraussmaffei_mc4_ethernet.DEVICE_MACHINE_ID")]
    public int MachineId { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}, {nameof(MachineId)}: {MachineId}";
}
