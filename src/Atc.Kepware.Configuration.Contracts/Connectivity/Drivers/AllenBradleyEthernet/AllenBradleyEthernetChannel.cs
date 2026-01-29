namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AllenBradleyEthernet;

/// <summary>
/// Represents an Allen-Bradley Ethernet channel.
/// </summary>
public class AllenBradleyEthernetChannel : ChannelBase, IAllenBradleyEthernetChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public int? VirtualNetwork { get; set; }

    /// <inheritdoc />
    public int TransactionsPerCycle { get; set; }

    /// <inheritdoc />
    public AllenBradleyEthernetChannelNetworkModeType NetworkMode { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}