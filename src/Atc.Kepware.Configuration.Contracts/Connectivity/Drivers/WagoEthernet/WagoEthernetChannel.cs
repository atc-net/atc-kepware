namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.WagoEthernet;

/// <summary>
/// Represents a Wago Ethernet channel.
/// </summary>
public class WagoEthernetChannel : ChannelBase, IWagoEthernetChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}