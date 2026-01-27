namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AllenBradleyMicro800Ethernet;

/// <summary>
/// Channel properties for the Allen-Bradley Micro800 Ethernet driver.
/// </summary>
public sealed class AllenBradleyMicro800EthernetChannel : ChannelBase, IAllenBradleyMicro800EthernetChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
