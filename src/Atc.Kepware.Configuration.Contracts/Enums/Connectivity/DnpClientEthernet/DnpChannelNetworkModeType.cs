namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.DnpClientEthernet;

/// <summary>
/// Choose whether to Load Balance for channels to communicate in a fixed order
/// or Priority for order based on the type of operations pending.
/// </summary>
public enum DnpChannelNetworkModeType
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