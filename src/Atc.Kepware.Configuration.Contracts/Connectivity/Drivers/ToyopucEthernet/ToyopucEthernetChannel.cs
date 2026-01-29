namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.ToyopucEthernet;

/// <summary>
/// Represents a Toyopuc Ethernet channel.
/// </summary>
public class ToyopucEthernetChannel : ChannelBase, IToyopucEthernetChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}