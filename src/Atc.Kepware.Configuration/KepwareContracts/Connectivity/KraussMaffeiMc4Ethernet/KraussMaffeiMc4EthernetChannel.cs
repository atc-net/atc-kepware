namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.KraussMaffeiMc4Ethernet;

/// <summary>
/// Channel properties for the KraussMaffei MC4 Ethernet driver.
/// </summary>
internal sealed class KraussMaffeiMc4EthernetChannel : ChannelBase, IKraussMaffeiMc4EthernetChannel
{
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}