namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.DnpClientEthernet;

/// <summary>
/// Represents a DNP Client Ethernet device.
/// </summary>
public class DnpClientEthernetDevice : DeviceBase, IDnpClientEthernetDevice
{
    /// <inheritdoc />
    public int DnpClientAddress { get; set; }

    /// <inheritdoc />
    public int DnpServerAddress { get; set; }

    /// <inheritdoc />
    public int RequestTimeout { get; set; }

    /// <inheritdoc />
    public int MaxTimeouts { get; set; }

    /// <inheritdoc />
    public int KeepAliveInterval { get; set; }

    /// <inheritdoc />
    public bool DnpServerUsesUtc { get; set; }

    /// <inheritdoc />
    public bool DnpServerRespectsDst { get; set; }

    /// <inheritdoc />
    public bool HonorTimeSyncRequests { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DnpClientAddress)}: {DnpClientAddress}, {nameof(DnpServerAddress)}: {DnpServerAddress}";
}
