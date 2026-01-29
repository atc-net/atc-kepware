namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.FanucFocasEthernet;

/// <summary>
/// Interface for Fanuc Focas Ethernet channel request properties.
/// </summary>
public interface IFanucFocasEthernetChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Specify the name of a network adapter to bind or allow the OS to select the default.
    /// </summary>
    string? NetworkAdapter { get; set; }
}