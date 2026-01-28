namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.KraussMaffeiMc4Ethernet;

/// <summary>
/// Channel request for the KraussMaffei MC4 Ethernet driver.
/// </summary>
internal sealed class KraussMaffeiMc4EthernetChannelRequest : ChannelRequestBase, IKraussMaffeiMc4EthernetChannelRequest
{
    public KraussMaffeiMc4EthernetChannelRequest()
        : base(DriverType.KraussMaffeiMc4Ethernet)
    {
    }

    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
