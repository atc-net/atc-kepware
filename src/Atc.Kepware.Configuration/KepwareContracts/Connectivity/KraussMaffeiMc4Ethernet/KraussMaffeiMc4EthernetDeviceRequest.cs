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

    [Range(0, 65535)]
    [JsonPropertyName("kraussmaffei_mc4_ethernet.DEVICE_PORT_NUMBER")]
    public int Port { get; set; } = 18901;

    [JsonPropertyName("kraussmaffei_mc4_ethernet.DEVICE_PROTOCOL")]
    public KraussMaffeiMc4ProtocolType Protocol { get; set; } = KraussMaffeiMc4ProtocolType.TcpIp;

    [JsonPropertyName("kraussmaffei_mc4_ethernet.DEVICE_REQUEST_SIZE")]
    public KraussMaffeiMc4RequestSizeModeType RequestSizeMode { get; set; } = KraussMaffeiMc4RequestSizeModeType.ExtendedMode;

    [JsonPropertyName("kraussmaffei_mc4_ethernet.DEVICE_PARAMETER_HANDLES")]
    public bool ParameterHandles { get; set; } = true;

    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}, {nameof(Protocol)}: {Protocol}, {nameof(RequestSizeMode)}: {RequestSizeMode}, {nameof(ParameterHandles)}: {ParameterHandles}";
}
