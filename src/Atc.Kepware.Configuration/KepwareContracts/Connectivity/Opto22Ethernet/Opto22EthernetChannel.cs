namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.Opto22Ethernet;

/// <summary>
/// Channel properties for the Opto 22 Ethernet driver.
/// </summary>
internal sealed class Opto22EthernetChannel : ChannelBase, IOpto22EthernetChannel
{
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
