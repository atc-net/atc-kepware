namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.BristolBsapIp;

/// <summary>
/// Channel properties for the Bristol BSAP IP driver.
/// </summary>
public sealed class BristolBsapIpChannelRequest : ChannelRequestBase, IBristolBsapIpChannelRequest
{
    public BristolBsapIpChannelRequest()
        : base(DriverType.BristolBsapIp)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    [Range(0, 500)]
    public int? VirtualNetwork { get; set; }

    /// <inheritdoc />
    [Range(1, 99)]
    public int TransactionsPerCycle { get; set; } = 1;

    /// <inheritdoc />
    public BristolBsapIpChannelNetworkModeType NetworkMode { get; set; } = BristolBsapIpChannelNetworkModeType.LoadBalanced;

    /// <inheritdoc />
    [Range(1, 65535)]
    public int UdpPort { get; set; } = 1234;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}, {nameof(VirtualNetwork)}: {VirtualNetwork}, {nameof(TransactionsPerCycle)}: {TransactionsPerCycle}, {nameof(NetworkMode)}: {NetworkMode}, {nameof(UdpPort)}: {UdpPort}";
}
