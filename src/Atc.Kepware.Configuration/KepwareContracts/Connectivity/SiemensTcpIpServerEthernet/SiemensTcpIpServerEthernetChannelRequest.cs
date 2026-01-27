namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.SiemensTcpIpServerEthernet;

/// <summary>
/// Siemens TCP/IP Server Ethernet channel request - Kepware format.
/// </summary>
internal sealed class SiemensTcpIpServerEthernetChannelRequest : ChannelRequestBase, ISiemensTcpIpServerEthernetChannelRequest
{
    public SiemensTcpIpServerEthernetChannelRequest()
        : base(DriverType.SiemensTcpIpServerEthernet)
    {
    }

    [JsonPropertyName("siemens_tcpip_unsolicited_ethernet.CHANNEL_COMMUNICATIONS_PORT_NUMBER")]
    public int PortNumber { get; set; } = 102;

    public override string ToString()
        => $"{base.ToString()}, {nameof(PortNumber)}: {PortNumber}";
}
