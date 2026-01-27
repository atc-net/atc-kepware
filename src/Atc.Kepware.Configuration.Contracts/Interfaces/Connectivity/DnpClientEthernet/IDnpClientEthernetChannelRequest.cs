namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.DnpClientEthernet;

/// <summary>
/// Defines the DNP Client Ethernet channel request properties.
/// </summary>
public interface IDnpClientEthernetChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Gets or sets the network adapter to bind for Ethernet communication.
    /// </summary>
    string? NetworkAdapter { get; set; }
}
