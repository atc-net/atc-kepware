namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AllenBradleyMicro800Ethernet;

/// <summary>
/// Channel properties for the Allen-Bradley Micro800 Ethernet driver.
/// </summary>
internal sealed class AllenBradleyMicro800EthernetChannel : ChannelBase, IAllenBradleyMicro800EthernetChannel
{
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
