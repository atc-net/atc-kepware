namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.BacNetIp;

/// <summary>
/// Channel properties for the BACnet/IP driver.
/// </summary>
internal sealed class BacNetIpChannel : ChannelBase, IBacNetIpChannel
{
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    [JsonPropertyName("bacnet.CHANNEL_ALLOW_COV_NOTIFICATIONS")]
    public BacNetIpCovNotificationType CovNotifications { get; set; }

    [JsonPropertyName("bacnet.CHANNEL_UDP_PORT")]
    public int UdpPort { get; set; }

    [JsonPropertyName("bacnet.CHANNEL_NETWORK_NUMBER")]
    public int LocalNetworkNumber { get; set; }

    [JsonPropertyName("bacnet.CHANNEL_DEVICE_INSTANCE")]
    public int LocalDeviceInstance { get; set; }

    [JsonPropertyName("bacnet.CHANNEL_FOREIGN_DEVICE")]
    public bool RegisterAsForeignDevice { get; set; }

    [JsonPropertyName("bacnet.CHANNEL_IP_ADDRESS_OF_REMOTE_BBMD")]
    public string? IpAddressOfRemoteBbmd { get; set; }

    [JsonPropertyName("bacnet.CHANNEL_REGISTRATION_TIME_TO_LIVE")]
    public int RegistrationTimeToLive { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(UdpPort)}: {UdpPort}, {nameof(LocalNetworkNumber)}: {LocalNetworkNumber}";
}
