namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.CutlerHammerElcEthernet;

/// <summary>
/// Defines the Cutler-Hammer ELC Ethernet channel request properties.
/// </summary>
public interface ICutlerHammerElcEthernetChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Gets or sets the network adapter to bind for Ethernet communication.
    /// </summary>
    string? NetworkAdapter { get; set; }
}