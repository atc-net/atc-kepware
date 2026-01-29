namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.Opto22Ethernet;

public sealed class Opto22EthernetChannel : ChannelBase, IOpto22EthernetChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}