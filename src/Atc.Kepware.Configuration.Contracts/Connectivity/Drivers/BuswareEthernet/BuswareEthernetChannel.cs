namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.BuswareEthernet;

/// <summary>
/// Represents a Busware Ethernet channel.
/// </summary>
public class BuswareEthernetChannel : ChannelBase, IBuswareEthernetChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
