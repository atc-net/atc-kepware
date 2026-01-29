namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.HoneywellUdcEthernet;

/// <summary>
/// Interface for Honeywell UDC Ethernet channel request properties.
/// </summary>
public interface IHoneywellUdcEthernetChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Specify the name of a network adapter to bind or allow the OS to select the default.
    /// </summary>
    string? NetworkAdapter { get; set; }
}