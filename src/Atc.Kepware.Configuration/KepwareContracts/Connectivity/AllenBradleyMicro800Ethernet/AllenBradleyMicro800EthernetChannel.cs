namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AllenBradleyMicro800Ethernet;

/// <summary>
/// Channel properties for the Allen-Bradley Micro800 Ethernet driver.
/// </summary>
internal sealed class AllenBradleyMicro800EthernetChannel : ChannelBase, IAllenBradleyMicro800EthernetChannel
{
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    [JsonPropertyName("servermain.CHANNEL_COMMUNICATIONS_SERIALIZATION_VIRTUAL_NETWORK")]
    public int? VirtualNetwork { get; set; }

    [JsonPropertyName("servermain.CHANNEL_COMMUNICATIONS_SERIALIZATION_TRANSACTIONS_PER_CYCLE")]
    public int TransactionsPerCycle { get; set; }

    [JsonPropertyName("servermain.CHANNEL_COMMUNICATIONS_SERIALIZATION_NETWORK_MODE")]
    public AllenBradleyMicro800EthernetChannelNetworkModeType NetworkMode { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}