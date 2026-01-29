namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.DnpClientEthernet;

/// <summary>
/// Represents a DNP Client Ethernet channel.
/// </summary>
public class DnpClientEthernetChannel : ChannelBase, IDnpClientEthernetChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public DnpClientEthernetProtocolType Protocol { get; set; }

    /// <inheritdoc />
    public int SourcePort { get; set; }

    /// <inheritdoc />
    public string? DestinationHost { get; set; }

    /// <inheritdoc />
    public int DestinationPort { get; set; }

    /// <inheritdoc />
    public int ConnectTimeout { get; set; }

    /// <inheritdoc />
    public int ResponseTimeout { get; set; }

    /// <inheritdoc />
    public int MaxLinkLayerRetries { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DestinationHost)}: {DestinationHost}, {nameof(DestinationPort)}: {DestinationPort}";
}