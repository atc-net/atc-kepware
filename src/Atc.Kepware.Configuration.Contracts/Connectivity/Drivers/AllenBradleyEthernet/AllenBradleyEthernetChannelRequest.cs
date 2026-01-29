namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AllenBradleyEthernet;

/// <summary>
/// Represents an Allen-Bradley Ethernet channel creation request.
/// </summary>
public class AllenBradleyEthernetChannelRequest : ChannelRequestBase, IAllenBradleyEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AllenBradleyEthernetChannelRequest"/> class.
    /// </summary>
    public AllenBradleyEthernetChannelRequest()
        : base(DriverType.AllenBradleyEthernet)
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
    public AllenBradleyEthernetChannelNetworkModeType NetworkMode { get; set; } = AllenBradleyEthernetChannelNetworkModeType.LoadBalanced;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}