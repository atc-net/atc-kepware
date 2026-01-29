namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.SiemensTcpIpEthernet;

/// <summary>
/// Channel properties for the Siemens TCP/IP Ethernet driver.
/// </summary>
internal sealed class SiemensTcpIpEthernetChannel : ChannelBase, ISiemensTcpIpEthernetChannel
{
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}