namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.SiemensTcpIpServerEthernet;

/// <summary>
/// Siemens TCP/IP Server Ethernet channel request.
/// </summary>
public class SiemensTcpIpServerEthernetChannelRequest : ChannelRequestBase, ISiemensTcpIpServerEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SiemensTcpIpServerEthernetChannelRequest"/> class.
    /// </summary>
    public SiemensTcpIpServerEthernetChannelRequest()
        : base(DriverType.SiemensTcpIpServerEthernet)
    {
    }

    /// <inheritdoc />
    public int PortNumber { get; set; } = 102;
}
