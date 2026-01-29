namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.SixnetEthertrak;

/// <summary>
/// Defines the SIXNET EtherTRAK channel request properties.
/// </summary>
public interface ISixnetEthertrakChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Gets or sets the network adapter to bind for Ethernet communication.
    /// </summary>
    string? NetworkAdapter { get; set; }
}