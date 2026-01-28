namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.BuswareEthernet;

/// <summary>
/// Defines the Busware Ethernet channel request properties.
/// </summary>
public interface IBuswareEthernetChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Gets or sets the network adapter to bind for Ethernet communication.
    /// </summary>
    string? NetworkAdapter { get; set; }
}
