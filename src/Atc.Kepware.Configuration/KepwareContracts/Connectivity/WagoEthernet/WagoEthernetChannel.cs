namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.WagoEthernet;

/// <summary>
/// Channel properties for the Wago Ethernet driver.
/// </summary>
internal sealed class WagoEthernetChannel : ChannelBase, IWagoEthernetChannel
{
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}