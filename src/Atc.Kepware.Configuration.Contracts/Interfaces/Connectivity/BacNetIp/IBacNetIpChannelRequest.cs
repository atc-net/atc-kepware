namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.BacNetIp;

/// <summary>
/// Defines the BACnet/IP channel request properties.
/// </summary>
public interface IBacNetIpChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Gets or sets the network adapter to bind for Ethernet communication.
    /// </summary>
    string? NetworkAdapter { get; set; }

    /// <summary>
    /// Gets or sets the COV notification handling mode.
    /// </summary>
    BacNetIpCovNotificationType CovNotifications { get; set; }

    /// <summary>
    /// Gets or sets the local UDP port for BACnet communication.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-65535. Default: 47808 (0xBAC0).
    /// </remarks>
    int UdpPort { get; set; }

    /// <summary>
    /// Gets or sets the local BACnet network number.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-65534. Default: 1.
    /// </remarks>
    int LocalNetworkNumber { get; set; }

    /// <summary>
    /// Gets or sets the local BACnet device instance.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-4194302. Default: 0.
    /// </remarks>
    int LocalDeviceInstance { get; set; }

    /// <summary>
    /// Gets or sets whether to register as a foreign device.
    /// </summary>
    bool RegisterAsForeignDevice { get; set; }

    /// <summary>
    /// Gets or sets the IP address of the remote BBMD.
    /// </summary>
    /// <remarks>
    /// Only used when RegisterAsForeignDevice is enabled.
    /// </remarks>
    string? IpAddressOfRemoteBbmd { get; set; }

    /// <summary>
    /// Gets or sets the registration time-to-live in seconds.
    /// </summary>
    /// <remarks>
    /// Only used when RegisterAsForeignDevice is enabled. Valid range: 10-3600. Default: 60.
    /// </remarks>
    int RegistrationTimeToLive { get; set; }
}
