namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.OmronFinsEthernet;

/// <summary>
/// Represents an Omron FINS Ethernet channel.
/// </summary>
public class OmronFinsEthernetChannel : ChannelBase, IOmronFinsEthernetChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public int Port { get; set; } = 9600;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Port)}: {Port}";
}
