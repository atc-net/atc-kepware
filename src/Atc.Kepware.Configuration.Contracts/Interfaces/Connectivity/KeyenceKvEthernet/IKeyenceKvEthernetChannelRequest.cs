namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.KeyenceKvEthernet;

public interface IKeyenceKvEthernetChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Specify the name of a network adapter to bind or allow the OS to select the default.
    /// </summary>
    string? NetworkAdapter { get; set; }

    /// <summary>
    /// Specify the port number for the channel.
    /// Default: 8501.
    /// </summary>
    int Port { get; set; }
}
