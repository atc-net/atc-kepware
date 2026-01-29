namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.ToshibaEthernet;

/// <summary>
/// Channel properties for the Toshiba Ethernet driver.
/// </summary>
internal sealed class ToshibaEthernetChannel : ChannelBase, IToshibaEthernetChannel
{
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}