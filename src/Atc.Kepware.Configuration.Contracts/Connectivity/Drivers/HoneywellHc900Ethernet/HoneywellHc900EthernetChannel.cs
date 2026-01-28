namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.HoneywellHc900Ethernet;

public sealed class HoneywellHc900EthernetChannel : ChannelBase, IHoneywellHc900EthernetChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
