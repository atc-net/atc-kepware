namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.MitsubishiEthernet;

/// <summary>
/// Defines the Mitsubishi Ethernet channel request properties.
/// </summary>
public interface IMitsubishiEthernetChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Gets or sets the network adapter to bind for Ethernet communication.
    /// </summary>
    string? NetworkAdapter { get; set; }
}
