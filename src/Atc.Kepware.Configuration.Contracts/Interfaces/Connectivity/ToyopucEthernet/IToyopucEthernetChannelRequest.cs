namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.ToyopucEthernet;

/// <summary>
/// Defines the Toyopuc Ethernet channel request properties.
/// </summary>
public interface IToyopucEthernetChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Gets or sets the network adapter to bind for Ethernet communication.
    /// </summary>
    string? NetworkAdapter { get; set; }
}
