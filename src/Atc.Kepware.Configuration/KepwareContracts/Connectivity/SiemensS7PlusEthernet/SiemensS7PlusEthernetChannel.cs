namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.SiemensS7PlusEthernet;

/// <summary>
/// Channel properties for the Siemens S7 Plus Ethernet driver.
/// </summary>
internal sealed class SiemensS7PlusEthernetChannel : ChannelBase, ISiemensS7PlusEthernetChannel
{
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
