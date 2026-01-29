namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.DnpClientEthernet;

/// <summary>
/// Channel request properties for the DNP Client Ethernet driver.
/// </summary>
internal sealed class DnpClientEthernetChannelRequest : ChannelRequestBase, IDnpClientEthernetChannelRequest
{
    public DnpClientEthernetChannelRequest()
        : base(DriverType.DnpClientEthernet)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("dnp_master_ethernet.CHANNEL_PROTOCOL")]
    public DnpClientEthernetProtocolType Protocol { get; set; } = DnpClientEthernetProtocolType.Tcp;

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("dnp_master_ethernet.CHANNEL_SOURCE_PORT")]
    public int SourcePort { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("dnp_master_ethernet.CHANNEL_DESTINATION_HOST")]
    public string? DestinationHost { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    [Range(1, 65535)]
    [JsonPropertyName("dnp_master_ethernet.CHANNEL_DESTINATION_PORT")]
    public int DestinationPort { get; set; } = 20000;

    /// <inheritdoc />
    [Range(1, 30)]
    [JsonPropertyName("dnp_master_ethernet.CHANNEL_CONNECT_TIMEOUT_SECONDS")]
    public int ConnectTimeout { get; set; } = 3;

    /// <inheritdoc />
    [Range(100, 3600000)]
    [JsonPropertyName("dnp_master_ethernet.CHANNEL_RESPONSE_TIMEOUT_MILLISECONDS")]
    public int ResponseTimeout { get; set; } = 10000;

    /// <inheritdoc />
    [Range(0, 255)]
    [JsonPropertyName("dnp_master_ethernet.CHANNEL_MAX_LINK_LAYER_RETRIES")]
    public int MaxLinkLayerRetries { get; set; } = 3;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DestinationHost)}: {DestinationHost}, {nameof(DestinationPort)}: {DestinationPort}";
}
