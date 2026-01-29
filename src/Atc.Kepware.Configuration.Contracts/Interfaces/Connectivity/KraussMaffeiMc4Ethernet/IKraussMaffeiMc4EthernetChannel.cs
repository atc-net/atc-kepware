namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.KraussMaffeiMc4Ethernet;

/// <summary>
/// Interface for KraussMaffei MC4 Ethernet channel properties.
/// </summary>
public interface IKraussMaffeiMc4EthernetChannel : IChannelBase
{
    /// <summary>
    /// Specify the name of a network adapter to bind or allow the OS to select the default.
    /// </summary>
    string? NetworkAdapter { get; set; }
}