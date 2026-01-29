namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.SiemensTcpIpEthernet;

/// <summary>
/// Defines the Siemens TCP/IP Ethernet channel request properties.
/// </summary>
public interface ISiemensTcpIpEthernetChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Gets or sets the network adapter to bind for Ethernet communication.
    /// </summary>
    string? NetworkAdapter { get; set; }
}