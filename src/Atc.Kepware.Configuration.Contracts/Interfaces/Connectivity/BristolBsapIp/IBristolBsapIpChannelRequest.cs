namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.BristolBsapIp;

/// <summary>
/// Interface for Bristol BSAP IP channel request.
/// </summary>
public interface IBristolBsapIpChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Specify the name of a network adapter to bind or allow the OS to select the default.
    /// </summary>
    string? NetworkAdapter { get; set; }

    /// <summary>
    /// Limit data transmissions to one channel at a time by assigning this channel to a virtual network.
    /// 0 = None, 1-500 = Network 1-500.
    /// </summary>
    int? VirtualNetwork { get; set; }

    /// <summary>
    /// Specify the number of transactions to perform when a channel is given permission to communicate.
    /// </summary>
    int TransactionsPerCycle { get; set; }

    /// <summary>
    /// Choose whether to Load Balance for channels to communicate in a fixed order
    /// or Priority for order based on the type of operations pending.
    /// </summary>
    BristolBsapIpChannelNetworkModeType NetworkMode { get; set; }

    /// <summary>
    /// Specify the UDP port number devices on this network use.
    /// </summary>
    int UdpPort { get; set; }
}