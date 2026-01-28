namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.Opto22Ethernet;

/// <summary>
/// Device request for the Opto 22 Ethernet driver.
/// </summary>
internal sealed class Opto22EthernetDeviceRequest : DeviceRequestBase, IOpto22EthernetDeviceRequest
{
    public Opto22EthernetDeviceRequest()
        : base(DriverType.Opto22Ethernet)
    {
    }

    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public Opto22EthernetDeviceModelType Model { get; set; } = Opto22EthernetDeviceModelType.SnapPacR1;

    [Required]
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = string.Empty;

    [Range(1, 30)]
    [JsonPropertyName("servermain.DEVICE_CONNECTION_TIMEOUT_SECONDS")]
    public int ConnectTimeoutSeconds { get; set; } = 3;

    [Range(50, 9999999)]
    [JsonPropertyName("servermain.DEVICE_REQUEST_TIMEOUT_MILLISECONDS")]
    public int RequestTimeoutMs { get; set; } = 1000;

    [Range(1, 10)]
    [JsonPropertyName("servermain.DEVICE_RETRY_ATTEMPTS")]
    public int RetryAttempts { get; set; } = 3;

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_ENABLE_ON_COMMUNICATIONS_FAILURES")]
    public bool DemoteOnFailure { get; set; }

    [Range(1, 30)]
    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DEMOTE_AFTER_SUCCESSIVE_TIMEOUTS")]
    public int TimeoutsToDemote { get; set; } = 3;

    [Range(100, 3600000)]
    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_PERIOD_MS")]
    public int DemotionPeriodMs { get; set; } = 10000;

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DISCARD_WRITES")]
    public bool DiscardRequestsWhenDemoted { get; set; }

    [Range(0, 65535)]
    [JsonPropertyName("opto_22_ethernet.DEVICE_PORT")]
    public int Port { get; set; } = 2001;

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}
