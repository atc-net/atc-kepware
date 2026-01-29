namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.BacNetIp;

/// <summary>
/// Represents a BACnet/IP channel.
/// </summary>
public class BacNetIpChannel : ChannelBase, IBacNetIpChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public BacNetIpCovNotificationType CovNotifications { get; set; }

    /// <inheritdoc />
    public int UdpPort { get; set; }

    /// <inheritdoc />
    public int LocalNetworkNumber { get; set; }

    /// <inheritdoc />
    public int LocalDeviceInstance { get; set; }

    /// <inheritdoc />
    public bool RegisterAsForeignDevice { get; set; }

    /// <inheritdoc />
    public string? IpAddressOfRemoteBbmd { get; set; }

    /// <inheritdoc />
    public int RegistrationTimeToLive { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(UdpPort)}: {UdpPort}, {nameof(LocalNetworkNumber)}: {LocalNetworkNumber}";
}