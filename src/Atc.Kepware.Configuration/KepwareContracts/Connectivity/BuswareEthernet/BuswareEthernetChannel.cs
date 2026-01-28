namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.BuswareEthernet;

/// <summary>
/// Channel properties for the Busware Ethernet driver.
/// </summary>
internal sealed class BuswareEthernetChannel : ChannelBase, IBuswareEthernetChannel
{
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
