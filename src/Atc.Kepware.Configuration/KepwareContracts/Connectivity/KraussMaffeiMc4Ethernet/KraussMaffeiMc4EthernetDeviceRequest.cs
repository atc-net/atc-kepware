namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.KraussMaffeiMc4Ethernet;

/// <summary>
/// Device request for the KraussMaffei MC4 Ethernet driver.
/// </summary>
internal sealed class KraussMaffeiMc4EthernetDeviceRequest : DeviceRequestBase, IKraussMaffeiMc4EthernetDeviceRequest
{
    public KraussMaffeiMc4EthernetDeviceRequest()
        : base(DriverType.KraussMaffeiMc4Ethernet)
    {
    }

    [Required]
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = string.Empty;

    [JsonPropertyName("servermain.DEVICE_CONNECTION_TIMEOUT_SECONDS")]
    public int ConnectTimeoutSeconds { get; set; } = 3;

    [JsonPropertyName("servermain.DEVICE_REQUEST_TIMEOUT_MILLISECONDS")]
    public int RequestTimeoutMs { get; set; } = 1000;

    [JsonPropertyName("servermain.DEVICE_RETRY_ATTEMPTS")]
    public int RetryAttempts { get; set; } = 3;

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_ENABLE_ON_COMMUNICATIONS_FAILURES")]
    public bool DemoteOnFailure { get; set; }

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DEMOTE_AFTER_SUCCESSIVE_TIMEOUTS")]
    public int TimeoutsToDemote { get; set; } = 3;

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_PERIOD_MS")]
    public int DemotionPeriodMs { get; set; } = 10000;

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DISCARD_WRITES")]
    public bool DiscardRequestsWhenDemoted { get; set; }

    [Range(1, 65535)]
    [JsonPropertyName("kraussmaffei_mc4_ethernet.DEVICE_PORT")]
    public int Port { get; set; } = 4001;

    [Range(1, 255)]
    [JsonPropertyName("kraussmaffei_mc4_ethernet.DEVICE_MACHINE_ID")]
    public int MachineId { get; set; } = 1;

    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}, {nameof(MachineId)}: {MachineId}";
}
