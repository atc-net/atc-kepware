namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.AllenBradleyMicro800Ethernet;

/// <summary>
/// Defines the Allen-Bradley Micro800 Ethernet channel request properties.
/// </summary>
public interface IAllenBradleyMicro800EthernetChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Gets or sets the network adapter to bind for Ethernet communication.
    /// </summary>
    /// <remarks>
    /// Specify the name of a network adapter to bind or allow the OS to select the default.
    /// </remarks>
    string? NetworkAdapter { get; set; }

    /// <summary>
    /// Gets or sets the virtual network for channel serialization.
    /// </summary>
    /// <remarks>
    /// Limit data transmissions to one channel at a time by assigning this channel to a virtual network.
    /// Valid range: 0-500. Default: null (None).
    /// </remarks>
    int? VirtualNetwork { get; set; }

    /// <summary>
    /// Gets or sets the number of transactions per cycle.
    /// </summary>
    /// <remarks>
    /// Specify the number of transactions to perform when a channel is given permission to communicate.
    /// Valid range: 1-99. Default: 1.
    /// </remarks>
    int TransactionsPerCycle { get; set; }

    /// <summary>
    /// Gets or sets the network mode for channel serialization.
    /// </summary>
    /// <remarks>
    /// Choose whether to Load Balance for channels to communicate in a fixed order
    /// or Priority for order based on the type of operations pending.
    /// </remarks>
    AllenBradleyMicro800EthernetChannelNetworkModeType NetworkMode { get; set; }
}