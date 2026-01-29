namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.SattBusEthernet;

/// <summary>
/// Channel properties for the SattBus Ethernet driver.
/// </summary>
internal sealed class SattBusEthernetChannel : ChannelBase, ISattBusEthernetChannel
{
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
