namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.MitsubishiFxNet;

/// <summary>
/// Mitsubishi FX Net device request - Kepware format.
/// </summary>
internal sealed class MitsubishiFxNetDeviceRequest : DeviceRequestBase, IMitsubishiFxNetDeviceRequest
{
    public MitsubishiFxNetDeviceRequest()
        : base(DriverType.MitsubishiFxNet)
    {
    }

    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public MitsubishiFxNetModel Model { get; set; } = MitsubishiFxNetModel.Fx;

    [Range(0, 15)]
    [JsonPropertyName("servermain.DEVICE_ID_DECIMAL")]
    public int DeviceId { get; set; }

    [JsonPropertyName("servermain.DEVICE_ETHERNET_COMMUNICATIONS_IP")]
    public string IpAddress { get; set; } = string.Empty;

    [Range(0, 65535)]
    [JsonPropertyName("servermain.DEVICE_ETHERNET_COMMUNICATIONS_PORT")]
    public int Port { get; set; } = 2101;

    [JsonPropertyName("servermain.DEVICE_ETHERNET_COMMUNICATIONS_PROTOCOL")]
    public MitsubishiFxNetProtocolType Protocol { get; set; } = MitsubishiFxNetProtocolType.TcpIp;

    [Range(1, 30)]
    [JsonPropertyName("servermain.DEVICE_CONNECTION_TIMEOUT_SECONDS")]
    public int ConnectTimeout { get; set; } = 3;

    [Range(50, 9999999)]
    [JsonPropertyName("servermain.DEVICE_REQUEST_TIMEOUT_MILLISECONDS")]
    public int RequestTimeout { get; set; } = 1000;

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
    public int DemotionPeriod { get; set; } = 10000;

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DISCARD_WRITES")]
    public bool DiscardRequestsWhenDemoted { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DeviceId)}: {DeviceId}, {nameof(IpAddress)}: {IpAddress}";
}