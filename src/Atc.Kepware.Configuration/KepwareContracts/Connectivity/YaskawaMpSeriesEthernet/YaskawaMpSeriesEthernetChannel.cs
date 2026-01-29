namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.YaskawaMpSeriesEthernet;

/// <summary>
/// Channel properties for the Yaskawa MP Series Ethernet driver.
/// </summary>
internal sealed class YaskawaMpSeriesEthernetChannel : ChannelBase, IYaskawaMpSeriesEthernetChannel
{
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}