namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.SiemensS7PlusEthernet;

/// <summary>
/// Defines the Siemens S7 Plus Ethernet channel request properties.
/// </summary>
public interface ISiemensS7PlusEthernetChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Gets or sets the network adapter to bind for Ethernet communication.
    /// </summary>
    string? NetworkAdapter { get; set; }
}
