namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.DnpClientEthernet;

/// <summary>
/// Channel properties for the DNP Client Ethernet driver.
/// </summary>
internal sealed class DnpClientEthernetChannel : ChannelBase, IDnpClientEthernetChannel
{
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    [JsonPropertyName("dnp_master_ethernet.CHANNEL_PROTOCOL")]
    public DnpClientEthernetProtocolType Protocol { get; set; }

    [JsonPropertyName("dnp_master_ethernet.CHANNEL_SOURCE_PORT")]
    public int SourcePort { get; set; }

    [JsonPropertyName("dnp_master_ethernet.CHANNEL_DESTINATION_HOST")]
    public string? DestinationHost { get; set; }

    [JsonPropertyName("dnp_master_ethernet.CHANNEL_DESTINATION_PORT")]
    public int DestinationPort { get; set; }

    [JsonPropertyName("dnp_master_ethernet.CHANNEL_CONNECT_TIMEOUT_SECONDS")]
    public int ConnectTimeout { get; set; }

    [JsonPropertyName("dnp_master_ethernet.CHANNEL_RESPONSE_TIMEOUT_MILLISECONDS")]
    public int ResponseTimeout { get; set; }

    [JsonPropertyName("dnp_master_ethernet.CHANNEL_MAX_LINK_LAYER_RETRIES")]
    public int MaxLinkLayerRetries { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(DestinationHost)}: {DestinationHost}, {nameof(DestinationPort)}: {DestinationPort}";
}