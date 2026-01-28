namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.FanucFocasEthernet;

/// <summary>
/// Channel properties for the Fanuc Focas Ethernet driver.
/// </summary>
internal sealed class FanucFocasEthernetChannel : ChannelBase, IFanucFocasEthernetChannel
{
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
