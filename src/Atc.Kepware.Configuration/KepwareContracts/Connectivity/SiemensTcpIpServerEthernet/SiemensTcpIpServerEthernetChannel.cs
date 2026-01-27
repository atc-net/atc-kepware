namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.SiemensTcpIpServerEthernet;

/// <summary>
/// Siemens TCP/IP Server Ethernet channel - Kepware format.
/// </summary>
internal sealed class SiemensTcpIpServerEthernetChannel : ChannelBase, ISiemensTcpIpServerEthernetChannel
{
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    [JsonPropertyName("siemens_tcpip_unsolicited_ethernet.CHANNEL_COMMUNICATIONS_PORT_NUMBER")]
    public int PortNumber { get; set; } = 102;

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}, {nameof(PortNumber)}: {PortNumber}";
}
