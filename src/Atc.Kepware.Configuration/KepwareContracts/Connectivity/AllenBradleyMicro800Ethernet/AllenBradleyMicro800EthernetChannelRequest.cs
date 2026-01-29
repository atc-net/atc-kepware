namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AllenBradleyMicro800Ethernet;

/// <summary>
/// Channel request properties for the Allen-Bradley Micro800 Ethernet driver.
/// </summary>
internal sealed class AllenBradleyMicro800EthernetChannelRequest : ChannelRequestBase, IAllenBradleyMicro800EthernetChannelRequest
{
    public AllenBradleyMicro800EthernetChannelRequest()
        : base(DriverType.AllenBradleyMicro800Ethernet)
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
    public AllenBradleyMicro800EthernetChannelNetworkModeType NetworkMode { get; set; } = AllenBradleyMicro800EthernetChannelNetworkModeType.LoadBalanced;

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
