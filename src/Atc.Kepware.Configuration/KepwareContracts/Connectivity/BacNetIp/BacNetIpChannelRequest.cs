namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.BacNetIp;

/// <summary>
/// Channel request properties for the BACnet/IP driver.
/// </summary>
internal sealed class BacNetIpChannelRequest : ChannelRequestBase, IBacNetIpChannelRequest
{
    public BacNetIpChannelRequest()
        : base(DriverType.BacNetIp)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("bacnet.CHANNEL_ALLOW_COV_NOTIFICATIONS")]
    public BacNetIpCovNotificationType CovNotifications { get; set; } = BacNetIpCovNotificationType.RequireNpdu;

    /// <inheritdoc />
    [Range(1, 65535)]
    [JsonPropertyName("bacnet.CHANNEL_UDP_PORT")]
    public int UdpPort { get; set; } = 47808;

    /// <inheritdoc />
    [Range(1, 65534)]
    [JsonPropertyName("bacnet.CHANNEL_NETWORK_NUMBER")]
    public int LocalNetworkNumber { get; set; } = 1;

    /// <inheritdoc />
    [Range(0, 4194302)]
    [JsonPropertyName("bacnet.CHANNEL_DEVICE_INSTANCE")]
    public int LocalDeviceInstance { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("bacnet.CHANNEL_FOREIGN_DEVICE")]
    public bool RegisterAsForeignDevice { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("bacnet.CHANNEL_IP_ADDRESS_OF_REMOTE_BBMD")]
    public string? IpAddressOfRemoteBbmd { get; set; } = "0.0.0.0";

    /// <inheritdoc />
    [Range(10, 3600)]
    [JsonPropertyName("bacnet.CHANNEL_REGISTRATION_TIME_TO_LIVE")]
    public int RegistrationTimeToLive { get; set; } = 60;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(UdpPort)}: {UdpPort}, {nameof(LocalNetworkNumber)}: {LocalNetworkNumber}";
}