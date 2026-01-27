namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.SiemensTcpIpServerEthernet;

/// <summary>
/// Siemens TCP/IP Server Ethernet channel.
/// </summary>
public class SiemensTcpIpServerEthernetChannel : ChannelBase, ISiemensTcpIpServerEthernetChannel
{
    /// <inheritdoc />
    public int PortNumber { get; set; } = 102;
}
