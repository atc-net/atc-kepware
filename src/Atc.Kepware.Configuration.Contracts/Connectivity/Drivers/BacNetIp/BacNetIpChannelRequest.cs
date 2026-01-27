namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.BacNetIp;

/// <summary>
/// Represents a BACnet/IP channel creation request.
/// </summary>
public class BacNetIpChannelRequest : ChannelRequestBase, IBacNetIpChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BacNetIpChannelRequest"/> class.
    /// </summary>
    public BacNetIpChannelRequest()
        : base(DriverType.BacNetIp)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public BacNetIpCovNotificationType CovNotifications { get; set; } = BacNetIpCovNotificationType.RequireNpdu;

    /// <inheritdoc />
    [Range(1, 65535)]
    public int UdpPort { get; set; } = 47808;

    /// <inheritdoc />
    [Range(1, 65534)]
    public int LocalNetworkNumber { get; set; } = 1;

    /// <inheritdoc />
    [Range(0, 4194302)]
    public int LocalDeviceInstance { get; set; }

    /// <inheritdoc />
    public bool RegisterAsForeignDevice { get; set; }

    /// <inheritdoc />
    public string? IpAddressOfRemoteBbmd { get; set; } = "0.0.0.0";

    /// <inheritdoc />
    [Range(10, 3600)]
    public int RegistrationTimeToLive { get; set; } = 60;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(UdpPort)}: {UdpPort}, {nameof(LocalNetworkNumber)}: {LocalNetworkNumber}";
}
