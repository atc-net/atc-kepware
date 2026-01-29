namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.WagoEthernet;

/// <summary>
/// Defines the Wago Ethernet channel request properties.
/// </summary>
public interface IWagoEthernetChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Gets or sets the network adapter to bind for Ethernet communication.
    /// </summary>
    string? NetworkAdapter { get; set; }
}