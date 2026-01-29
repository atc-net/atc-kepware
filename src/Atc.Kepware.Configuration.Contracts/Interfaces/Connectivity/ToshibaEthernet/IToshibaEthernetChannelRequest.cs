namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.ToshibaEthernet;

/// <summary>
/// Defines the Toshiba Ethernet channel request properties.
/// </summary>
public interface IToshibaEthernetChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Gets or sets the network adapter to bind for Ethernet communication.
    /// </summary>
    string? NetworkAdapter { get; set; }
}