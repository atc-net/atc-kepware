namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.BacNetIp;

/// <summary>
/// Defines the BACnet/IP device request properties.
/// </summary>
public interface IBacNetIpDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the device discovery method.
    /// </summary>
    BacNetIpDiscoveryMethodType DiscoveryMethod { get; set; }

    /// <summary>
    /// Gets or sets the IP address for manual discovery.
    /// </summary>
    /// <remarks>
    /// Only used when DiscoveryMethod is Manual.
    /// </remarks>
    string? ManualDiscoveryIpAddress { get; set; }

    /// <summary>
    /// Gets or sets the BACnet MAC address.
    /// </summary>
    string? BacNetMac { get; set; }

    /// <summary>
    /// Gets or sets the remote data link technology.
    /// </summary>
    BacNetIpRemoteDataLinkType RemoteDataLinkTechnology { get; set; }

    /// <summary>
    /// Gets or sets the COV subscription mode.
    /// </summary>
    BacNetIpCovModeType CovMode { get; set; }

    /// <summary>
    /// Gets or sets the COV resubscription interval in seconds.
    /// </summary>
    /// <remarks>
    /// Valid range: 60-86400. Default: 3600.
    /// </remarks>
    int CovResubscriptionInterval { get; set; }

    /// <summary>
    /// Gets or sets whether to cancel COV subscriptions on shutdown.
    /// </summary>
    bool CancelCovSubscriptions { get; set; }

    /// <summary>
    /// Gets or sets the maximum APDU length.
    /// </summary>
    int MaximumApduLength { get; set; }

    /// <summary>
    /// Gets or sets the maximum items per request.
    /// </summary>
    int MaximumItemsPerRequest { get; set; }

    /// <summary>
    /// Gets or sets the command priority for writes.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-16. Default: 16.
    /// </remarks>
    int CommandPriority { get; set; }
}
