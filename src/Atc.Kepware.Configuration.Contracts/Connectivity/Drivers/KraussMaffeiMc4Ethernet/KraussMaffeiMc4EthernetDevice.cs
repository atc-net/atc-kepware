namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.KraussMaffeiMc4Ethernet;

/// <summary>
/// Device properties for the KraussMaffei MC4 Ethernet driver.
/// </summary>
public sealed class KraussMaffeiMc4EthernetDevice : DeviceBase, IKraussMaffeiMc4EthernetDevice
{
    /// <inheritdoc />
    public KraussMaffeiMc4EthernetDeviceModelType Model { get; set; }

    /// <inheritdoc />
    public KraussMaffeiMc4EthernetDeviceIdFormatType IdFormat { get; set; }

    /// <inheritdoc />
    public string DeviceId { get; set; } = string.Empty;

    /// <inheritdoc />
    public int ConnectTimeoutSeconds { get; set; }

    /// <inheritdoc />
    public int RequestTimeoutMs { get; set; }

    /// <inheritdoc />
    public int RetryAttempts { get; set; }

    /// <inheritdoc />
    public int Port { get; set; }

    /// <inheritdoc />
    public KraussMaffeiMc4ProtocolType Protocol { get; set; }

    /// <inheritdoc />
    public KraussMaffeiMc4RequestSizeModeType RequestSizeMode { get; set; }

    /// <inheritdoc />
    public bool ParameterHandles { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}, {nameof(Protocol)}: {Protocol}, {nameof(RequestSizeMode)}: {RequestSizeMode}, {nameof(ParameterHandles)}: {ParameterHandles}";
}