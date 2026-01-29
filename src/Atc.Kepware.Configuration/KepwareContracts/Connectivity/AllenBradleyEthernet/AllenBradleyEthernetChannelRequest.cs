namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AllenBradleyEthernet;

/// <summary>
/// Internal model for Allen-Bradley Ethernet channel request to Kepware API.
/// </summary>
internal sealed class AllenBradleyEthernetChannelRequest : ChannelRequestBase, IAllenBradleyEthernetChannelRequest
{
    public AllenBradleyEthernetChannelRequest()
        : base(DriverType.AllenBradleyEthernet)
    {
    }

    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    [Range(0, 500)]
    [JsonPropertyName("servermain.CHANNEL_COMMUNICATIONS_SERIALIZATION_VIRTUAL_NETWORK")]
    public int? VirtualNetwork { get; set; }

    [Range(1, 99)]
    [JsonPropertyName("servermain.CHANNEL_COMMUNICATIONS_SERIALIZATION_TRANSACTIONS_PER_CYCLE")]
    public int TransactionsPerCycle { get; set; } = 1;

    [JsonPropertyName("servermain.CHANNEL_COMMUNICATIONS_SERIALIZATION_NETWORK_MODE")]
    public AllenBradleyEthernetChannelNetworkModeType NetworkMode { get; set; } = AllenBradleyEthernetChannelNetworkModeType.LoadBalanced;

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
