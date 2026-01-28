namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.CutlerHammerElcEthernet;

/// <summary>
/// Channel properties for the Cutler-Hammer ELC Ethernet driver.
/// </summary>
internal sealed class CutlerHammerElcEthernetChannel : ChannelBase, ICutlerHammerElcEthernetChannel
{
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
