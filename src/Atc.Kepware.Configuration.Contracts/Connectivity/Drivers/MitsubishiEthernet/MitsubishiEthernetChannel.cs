namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.MitsubishiEthernet;

/// <summary>
/// Represents a Mitsubishi Ethernet channel.
/// </summary>
public class MitsubishiEthernetChannel : ChannelBase, IMitsubishiEthernetChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
