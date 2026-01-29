namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.SattBusEthernet;

/// <summary>
/// Defines the SattBus Ethernet channel request properties.
/// </summary>
public interface ISattBusEthernetChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Gets or sets the network adapter to bind for Ethernet communication.
    /// </summary>
    string? NetworkAdapter { get; set; }
}
