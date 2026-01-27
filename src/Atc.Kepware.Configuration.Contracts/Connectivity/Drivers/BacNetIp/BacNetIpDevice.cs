namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.BacNetIp;

/// <summary>
/// Represents a BACnet/IP device.
/// </summary>
public class BacNetIpDevice : DeviceBase, IBacNetIpDevice
{
    /// <inheritdoc />
    public BacNetIpDiscoveryMethodType DiscoveryMethod { get; set; }

    /// <inheritdoc />
    public string? ManualDiscoveryIpAddress { get; set; }

    /// <inheritdoc />
    public string? BacNetMac { get; set; }

    /// <inheritdoc />
    public BacNetIpRemoteDataLinkType RemoteDataLinkTechnology { get; set; }

    /// <inheritdoc />
    public BacNetIpCovModeType CovMode { get; set; }

    /// <inheritdoc />
    public int CovResubscriptionInterval { get; set; }

    /// <inheritdoc />
    public bool CancelCovSubscriptions { get; set; }

    /// <inheritdoc />
    public int MaximumApduLength { get; set; }

    /// <inheritdoc />
    public int MaximumItemsPerRequest { get; set; }

    /// <inheritdoc />
    public int CommandPriority { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DiscoveryMethod)}: {DiscoveryMethod}";
}
