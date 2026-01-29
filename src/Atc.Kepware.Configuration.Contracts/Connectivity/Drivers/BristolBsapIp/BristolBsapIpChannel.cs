namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.BristolBsapIp;

/// <summary>
/// Channel properties for the Bristol BSAP IP driver.
/// </summary>
public sealed class BristolBsapIpChannel : ChannelBase, IBristolBsapIpChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public int? VirtualNetwork { get; set; }

    /// <inheritdoc />
    public int TransactionsPerCycle { get; set; }

    /// <inheritdoc />
    public BristolBsapIpChannelNetworkModeType NetworkMode { get; set; }

    /// <inheritdoc />
    public int UdpPort { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}, {nameof(VirtualNetwork)}: {VirtualNetwork}, {nameof(TransactionsPerCycle)}: {TransactionsPerCycle}, {nameof(NetworkMode)}: {NetworkMode}, {nameof(UdpPort)}: {UdpPort}";
}