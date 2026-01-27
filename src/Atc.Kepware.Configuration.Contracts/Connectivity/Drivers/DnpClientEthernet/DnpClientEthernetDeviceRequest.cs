namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.DnpClientEthernet;

/// <summary>
/// Represents a DNP Client Ethernet device creation request.
/// </summary>
public class DnpClientEthernetDeviceRequest : DeviceRequestBase, IDnpClientEthernetDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DnpClientEthernetDeviceRequest"/> class.
    /// </summary>
    public DnpClientEthernetDeviceRequest()
        : base(DriverType.DnpClientEthernet)
    {
    }

    /// <inheritdoc />
    [Range(0, 65519)]
    public int DnpClientAddress { get; set; } = 3;

    /// <inheritdoc />
    [Range(0, 65519)]
    public int DnpServerAddress { get; set; } = 4;

    /// <inheritdoc />
    [Range(100, 3600000)]
    public int RequestTimeout { get; set; } = 30000;

    /// <inheritdoc />
    [Range(1, 10)]
    public int MaxTimeouts { get; set; } = 1;

    /// <inheritdoc />
    [Range(0, 86400)]
    public int KeepAliveInterval { get; set; }

    /// <inheritdoc />
    public bool DnpServerUsesUtc { get; set; } = true;

    /// <inheritdoc />
    public bool DnpServerRespectsDst { get; set; }

    /// <inheritdoc />
    public bool HonorTimeSyncRequests { get; set; } = true;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DnpClientAddress)}: {DnpClientAddress}, {nameof(DnpServerAddress)}: {DnpServerAddress}";
}
