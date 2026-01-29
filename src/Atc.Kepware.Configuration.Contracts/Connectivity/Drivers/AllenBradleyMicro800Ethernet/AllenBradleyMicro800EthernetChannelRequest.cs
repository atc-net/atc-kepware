namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AllenBradleyMicro800Ethernet;

/// <summary>
/// Channel request properties for the Allen-Bradley Micro800 Ethernet driver.
/// </summary>
public sealed class AllenBradleyMicro800EthernetChannelRequest : ChannelRequestBase, IAllenBradleyMicro800EthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AllenBradleyMicro800EthernetChannelRequest"/> class.
    /// </summary>
    public AllenBradleyMicro800EthernetChannelRequest()
        : base(DriverType.AllenBradleyMicro800Ethernet)
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
    public AllenBradleyMicro800EthernetChannelNetworkModeType NetworkMode { get; set; } = AllenBradleyMicro800EthernetChannelNetworkModeType.LoadBalanced;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}