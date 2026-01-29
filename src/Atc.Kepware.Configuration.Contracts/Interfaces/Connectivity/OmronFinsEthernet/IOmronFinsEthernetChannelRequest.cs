namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.OmronFinsEthernet;

/// <summary>
/// Defines the Omron FINS Ethernet channel request properties.
/// </summary>
public interface IOmronFinsEthernetChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Gets or sets the network adapter to bind for Ethernet communication.
    /// </summary>
    string? NetworkAdapter { get; set; }

    /// <summary>
    /// Gets or sets the port number used by devices on the local Ethernet network.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-65535. Default is 9600.
    /// </remarks>
    int Port { get; set; }
}