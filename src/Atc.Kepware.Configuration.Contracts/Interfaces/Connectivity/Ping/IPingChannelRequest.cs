namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.Ping;

/// <summary>
/// Defines the Ping channel request properties.
/// </summary>
public interface IPingChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Gets or sets the network adapter to bind for Ethernet communication.
    /// </summary>
    string? NetworkAdapter { get; set; }
}
