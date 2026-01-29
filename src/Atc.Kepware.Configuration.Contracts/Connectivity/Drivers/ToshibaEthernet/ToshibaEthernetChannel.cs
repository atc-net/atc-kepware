namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.ToshibaEthernet;

/// <summary>
/// Represents a Toshiba Ethernet channel.
/// </summary>
public class ToshibaEthernetChannel : ChannelBase, IToshibaEthernetChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}