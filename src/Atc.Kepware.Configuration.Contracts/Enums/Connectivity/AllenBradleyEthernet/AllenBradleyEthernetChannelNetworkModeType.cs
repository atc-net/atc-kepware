// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Choose whether to Load Balance for channels to communicate in a fixed order
/// or Priority for order based on the type of operations pending.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Allen-Bradley%20Ethernet/channels
/// Section: servermain.CHANNEL_COMMUNICATIONS_SERIALIZATION_NETWORK_MODE
/// </remarks>
public enum AllenBradleyEthernetChannelNetworkModeType
{
    /// <summary>
    /// Load Balanced - Channels communicate in a fixed order.
    /// </summary>
    LoadBalanced = 0,

    /// <summary>
    /// Priority - Order based on the type of operations pending.
    /// </summary>
    Priority = 1,
}
