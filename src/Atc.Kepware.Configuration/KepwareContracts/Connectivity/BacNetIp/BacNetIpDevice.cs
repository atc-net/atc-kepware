namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.BacNetIp;

/// <summary>
/// Device properties for the BACnet/IP driver.
/// </summary>
internal sealed class BacNetIpDevice : DeviceBase, IBacNetIpDevice
{
    [JsonPropertyName("bacnet.DEVICE_DISCOVERY_METHOD")]
    public BacNetIpDiscoveryMethodType DiscoveryMethod { get; set; }

    [JsonPropertyName("bacnet.DEVICE_MANUAL_DISCOVERY_IP_ADDRESS")]
    public string? ManualDiscoveryIpAddress { get; set; }

    [JsonPropertyName("bacnet.DEVICE_BACNET_MAC")]
    public string? BacNetMac { get; set; }

    [JsonPropertyName("bacnet.DEVICE_REMOTE_DATA_LINK_TECHNOLOGY")]
    public BacNetIpRemoteDataLinkType RemoteDataLinkTechnology { get; set; }

    [JsonPropertyName("bacnet.DEVICE_COV_MODE")]
    public BacNetIpCovModeType CovMode { get; set; }

    [JsonPropertyName("bacnet.DEVICE_COV_RESUBSCRIPTION_INTERVAL")]
    public int CovResubscriptionInterval { get; set; }

    [JsonPropertyName("bacnet.DEVICE_CANCEL_COV_SUBSCRIPTIONS")]
    public bool CancelCovSubscriptions { get; set; }

    [JsonPropertyName("bacnet.DEVICE_MAXIMUM_APDU_LENGTH")]
    public int MaximumApduLength { get; set; }

    [JsonPropertyName("bacnet.DEVICE_MAXIMUM_ITEMS_PER_REQUEST")]
    public int MaximumItemsPerRequest { get; set; }

    [JsonPropertyName("bacnet.DEVICE_COMMAND_PRIORITY")]
    public int CommandPriority { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(DiscoveryMethod)}: {DiscoveryMethod}";
}
