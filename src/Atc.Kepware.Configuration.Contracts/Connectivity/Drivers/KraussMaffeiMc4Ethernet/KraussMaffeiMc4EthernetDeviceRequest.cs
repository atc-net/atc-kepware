namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.KraussMaffeiMc4Ethernet;

/// <summary>
/// Device properties for the KraussMaffei MC4 Ethernet driver.
/// </summary>
public sealed class KraussMaffeiMc4EthernetDeviceRequest : DeviceRequestBase, IKraussMaffeiMc4EthernetDeviceRequest
{
    public KraussMaffeiMc4EthernetDeviceRequest()
        : base(DriverType.KraussMaffeiMc4Ethernet)
    {
    }

    /// <inheritdoc />
    public KraussMaffeiMc4EthernetDeviceModelType Model { get; set; } = KraussMaffeiMc4EthernetDeviceModelType.MC4;

    /// <inheritdoc />
    public KraussMaffeiMc4EthernetDeviceIdFormatType IdFormat { get; set; } = KraussMaffeiMc4EthernetDeviceIdFormatType.Octal;

    /// <inheritdoc />
    [Required]
    public string DeviceId { get; set; } = string.Empty;

    /// <inheritdoc />
    [Range(1, 30)]
    public int ConnectTimeoutSeconds { get; set; } = 3;

    /// <inheritdoc />
    [Range(50, 9999999)]
    public int RequestTimeoutMs { get; set; } = 1000;

    /// <inheritdoc />
    [Range(1, 10)]
    public int RetryAttempts { get; set; } = 3;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int Port { get; set; } = 18901;

    /// <inheritdoc />
    public KraussMaffeiMc4ProtocolType Protocol { get; set; } = KraussMaffeiMc4ProtocolType.TcpIp;

    /// <inheritdoc />
    public KraussMaffeiMc4RequestSizeModeType RequestSizeMode { get; set; } = KraussMaffeiMc4RequestSizeModeType.ExtendedMode;

    /// <inheritdoc />
    public bool ParameterHandles { get; set; } = true;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}, {nameof(Protocol)}: {Protocol}, {nameof(RequestSizeMode)}: {RequestSizeMode}, {nameof(ParameterHandles)}: {ParameterHandles}";
}
