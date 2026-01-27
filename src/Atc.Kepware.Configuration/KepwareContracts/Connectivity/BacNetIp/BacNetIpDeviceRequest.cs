namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.BacNetIp;

/// <summary>
/// Device request properties for the BACnet/IP driver.
/// </summary>
internal sealed class BacNetIpDeviceRequest : DeviceRequestBase, IBacNetIpDeviceRequest
{
    public BacNetIpDeviceRequest()
        : base(DriverType.BacNetIp)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("bacnet.DEVICE_DISCOVERY_METHOD")]
    public BacNetIpDiscoveryMethodType DiscoveryMethod { get; set; } = BacNetIpDiscoveryMethodType.Automatic;

    /// <inheritdoc />
    [JsonPropertyName("bacnet.DEVICE_MANUAL_DISCOVERY_IP_ADDRESS")]
    public string? ManualDiscoveryIpAddress { get; set; } = "0.0.0.0";

    /// <inheritdoc />
    [JsonPropertyName("bacnet.DEVICE_BACNET_MAC")]
    public string? BacNetMac { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("bacnet.DEVICE_REMOTE_DATA_LINK_TECHNOLOGY")]
    public BacNetIpRemoteDataLinkType RemoteDataLinkTechnology { get; set; } = BacNetIpRemoteDataLinkType.BacNetIp;

    /// <inheritdoc />
    [JsonPropertyName("bacnet.DEVICE_COV_MODE")]
    public BacNetIpCovModeType CovMode { get; set; } = BacNetIpCovModeType.Disabled;

    /// <inheritdoc />
    [Range(60, 86400)]
    [JsonPropertyName("bacnet.DEVICE_COV_RESUBSCRIPTION_INTERVAL")]
    public int CovResubscriptionInterval { get; set; } = 3600;

    /// <inheritdoc />
    [JsonPropertyName("bacnet.DEVICE_CANCEL_COV_SUBSCRIPTIONS")]
    public bool CancelCovSubscriptions { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("bacnet.DEVICE_MAXIMUM_APDU_LENGTH")]
    public int MaximumApduLength { get; set; } = 1476;

    /// <inheritdoc />
    [JsonPropertyName("bacnet.DEVICE_MAXIMUM_ITEMS_PER_REQUEST")]
    public int MaximumItemsPerRequest { get; set; } = 16;

    /// <inheritdoc />
    [Range(1, 16)]
    [JsonPropertyName("bacnet.DEVICE_COMMAND_PRIORITY")]
    public int CommandPriority { get; set; } = 16;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DiscoveryMethod)}: {DiscoveryMethod}";
}
