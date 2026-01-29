namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.KraussMaffeiMc4Ethernet;

/// <summary>
/// Device properties for the KraussMaffei MC4 Ethernet driver.
/// </summary>
internal sealed class KraussMaffeiMc4EthernetDevice : DeviceBase, IKraussMaffeiMc4EthernetDevice
{
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public KraussMaffeiMc4EthernetDeviceModelType Model { get; set; }

    [JsonPropertyName("servermain.DEVICE_ID_FORMAT")]
    public KraussMaffeiMc4EthernetDeviceIdFormatType IdFormat { get; set; }

    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = string.Empty;

    [JsonPropertyName("servermain.DEVICE_CONNECTION_TIMEOUT_SECONDS")]
    public int ConnectTimeoutSeconds { get; set; }

    [JsonPropertyName("servermain.DEVICE_REQUEST_TIMEOUT_MILLISECONDS")]
    public int RequestTimeoutMs { get; set; }

    [JsonPropertyName("servermain.DEVICE_RETRY_ATTEMPTS")]
    public int RetryAttempts { get; set; }

    [JsonPropertyName("kraussmaffei_mc4_ethernet.DEVICE_PORT_NUMBER")]
    public int Port { get; set; }

    [JsonPropertyName("kraussmaffei_mc4_ethernet.DEVICE_PROTOCOL")]
    public KraussMaffeiMc4ProtocolType Protocol { get; set; }

    [JsonPropertyName("kraussmaffei_mc4_ethernet.DEVICE_REQUEST_SIZE")]
    public KraussMaffeiMc4RequestSizeModeType RequestSizeMode { get; set; }

    [JsonPropertyName("kraussmaffei_mc4_ethernet.DEVICE_PARAMETER_HANDLES")]
    public bool ParameterHandles { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}, {nameof(Protocol)}: {Protocol}, {nameof(RequestSizeMode)}: {RequestSizeMode}, {nameof(ParameterHandles)}: {ParameterHandles}";
}