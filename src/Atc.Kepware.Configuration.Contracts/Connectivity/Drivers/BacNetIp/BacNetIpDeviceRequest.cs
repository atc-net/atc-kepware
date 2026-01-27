namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.BacNetIp;

/// <summary>
/// Represents a BACnet/IP device creation request.
/// </summary>
public class BacNetIpDeviceRequest : DeviceRequestBase, IBacNetIpDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BacNetIpDeviceRequest"/> class.
    /// </summary>
    public BacNetIpDeviceRequest()
        : base(DriverType.BacNetIp)
    {
    }

    /// <inheritdoc />
    public BacNetIpDiscoveryMethodType DiscoveryMethod { get; set; } = BacNetIpDiscoveryMethodType.Automatic;

    /// <inheritdoc />
    public string? ManualDiscoveryIpAddress { get; set; } = "0.0.0.0";

    /// <inheritdoc />
    public string? BacNetMac { get; set; }

    /// <inheritdoc />
    public BacNetIpRemoteDataLinkType RemoteDataLinkTechnology { get; set; } = BacNetIpRemoteDataLinkType.BacNetIp;

    /// <inheritdoc />
    public BacNetIpCovModeType CovMode { get; set; } = BacNetIpCovModeType.Disabled;

    /// <inheritdoc />
    [Range(60, 86400)]
    public int CovResubscriptionInterval { get; set; } = 3600;

    /// <inheritdoc />
    public bool CancelCovSubscriptions { get; set; } = true;

    /// <inheritdoc />
    public int MaximumApduLength { get; set; } = 1476;

    /// <inheritdoc />
    public int MaximumItemsPerRequest { get; set; } = 16;

    /// <inheritdoc />
    [Range(1, 16)]
    public int CommandPriority { get; set; } = 16;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DiscoveryMethod)}: {DiscoveryMethod}";
}
