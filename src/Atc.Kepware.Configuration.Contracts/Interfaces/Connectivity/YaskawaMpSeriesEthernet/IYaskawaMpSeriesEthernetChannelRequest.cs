namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.YaskawaMpSeriesEthernet;

/// <summary>
/// Defines the Yaskawa MP Series Ethernet channel request properties.
/// </summary>
public interface IYaskawaMpSeriesEthernetChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Gets or sets the network adapter to bind for Ethernet communication.
    /// </summary>
    string? NetworkAdapter { get; set; }
}