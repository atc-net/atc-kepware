namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.Opto22Ethernet;

public interface IOpto22EthernetChannel : IChannelBase
{
    /// <summary>
    /// Specify the name of a network adapter to bind or allow the OS to select the default.
    /// </summary>
    string? NetworkAdapter { get; set; }
}
