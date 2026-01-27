namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.SiemensTcpIpServerEthernet;

/// <summary>
/// Defines the Siemens TCP/IP Server Ethernet channel request properties.
/// </summary>
public interface ISiemensTcpIpServerEthernetChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Gets or sets the network adapter to bind for Ethernet communication.
    /// </summary>
    string? NetworkAdapter { get; set; }

    /// <summary>
    /// Gets or sets the port number on which the driver will listen.
    /// </summary>
    /// <remarks>
    /// Devices must be configured to connect to this port.
    /// Valid range: 0-65535. Default: 102.
    /// </remarks>
    int PortNumber { get; set; }
}
