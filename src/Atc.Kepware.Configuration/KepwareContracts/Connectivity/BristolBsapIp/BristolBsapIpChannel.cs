namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.BristolBsapIp;

/// <summary>
/// Channel properties for the Bristol BSAP IP driver.
/// </summary>
internal sealed class BristolBsapIpChannel : ChannelBase, IBristolBsapIpChannel
{
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    [JsonPropertyName("servermain.CHANNEL_COMMUNICATIONS_SERIALIZATION_VIRTUAL_NETWORK")]
    public int? VirtualNetwork { get; set; }

    [JsonPropertyName("servermain.CHANNEL_COMMUNICATIONS_SERIALIZATION_TRANSACTIONS_PER_CYCLE")]
    public int TransactionsPerCycle { get; set; }

    [JsonPropertyName("servermain.CHANNEL_COMMUNICATIONS_SERIALIZATION_NETWORK_MODE")]
    public BristolBsapIpChannelNetworkModeType NetworkMode { get; set; }

    [JsonPropertyName("bristol_bsap_ip.CHANNEL_UDP_PORT_DECIMAL")]
    public int UdpPort { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}, {nameof(VirtualNetwork)}: {VirtualNetwork}, {nameof(TransactionsPerCycle)}: {TransactionsPerCycle}, {nameof(NetworkMode)}: {NetworkMode}, {nameof(UdpPort)}: {UdpPort}";
}
