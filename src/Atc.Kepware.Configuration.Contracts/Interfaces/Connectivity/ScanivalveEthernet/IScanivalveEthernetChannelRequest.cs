namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.ScanivalveEthernet;

public interface IScanivalveEthernetChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Specify the name of a network adapter to bind or allow the OS to select the default.
    /// </summary>
    string? NetworkAdapter { get; set; }
}
