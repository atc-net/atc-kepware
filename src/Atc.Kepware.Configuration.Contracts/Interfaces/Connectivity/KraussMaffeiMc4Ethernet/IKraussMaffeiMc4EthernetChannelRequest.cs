namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.KraussMaffeiMc4Ethernet;

/// <summary>
/// Interface for KraussMaffei MC4 Ethernet channel request properties.
/// </summary>
public interface IKraussMaffeiMc4EthernetChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Specify the name of a network adapter to bind or allow the OS to select the default.
    /// </summary>
    string? NetworkAdapter { get; set; }
}