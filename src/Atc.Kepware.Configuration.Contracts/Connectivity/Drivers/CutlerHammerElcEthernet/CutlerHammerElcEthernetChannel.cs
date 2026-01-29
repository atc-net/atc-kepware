namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.CutlerHammerElcEthernet;

/// <summary>
/// Represents a Cutler-Hammer ELC Ethernet channel.
/// </summary>
public class CutlerHammerElcEthernetChannel : ChannelBase, ICutlerHammerElcEthernetChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}