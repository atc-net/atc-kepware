namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.SiemensTcpIpEthernet;

/// <summary>
/// Defines the Siemens TCP/IP Ethernet channel properties.
/// </summary>
public interface ISiemensTcpIpEthernetChannel : IChannelBase
{
    /// <summary>
    /// Gets or sets the network adapter to bind for Ethernet communication.
    /// </summary>
    string? NetworkAdapter { get; set; }
}