namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.TriconexEthernet;

/// <summary>
/// Represents a Triconex Ethernet channel.
/// </summary>
public class TriconexEthernetChannel : ChannelBase, ITriconexEthernetChannel
{
    /// <inheritdoc />
    public bool EnableNetworkRedundancy { get; set; }

    /// <inheritdoc />
    public string? PrimaryNetworkAdapter { get; set; }

    /// <inheritdoc />
    public string? SecondaryNetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(EnableNetworkRedundancy)}: {EnableNetworkRedundancy}, {nameof(PrimaryNetworkAdapter)}: {PrimaryNetworkAdapter}, {nameof(SecondaryNetworkAdapter)}: {SecondaryNetworkAdapter}";
}
