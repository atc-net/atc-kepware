namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.DnpClientEthernet;

/// <summary>
/// Represents a DNP Client Ethernet channel creation request.
/// </summary>
public class DnpClientEthernetChannelRequest : ChannelRequestBase, IDnpClientEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DnpClientEthernetChannelRequest"/> class.
    /// </summary>
    public DnpClientEthernetChannelRequest()
        : base(DriverType.DnpClientEthernet)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public DnpClientEthernetProtocolType Protocol { get; set; } = DnpClientEthernetProtocolType.Tcp;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int SourcePort { get; set; }

    /// <inheritdoc />
    public string? DestinationHost { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    [Range(1, 65535)]
    public int DestinationPort { get; set; } = 20000;

    /// <inheritdoc />
    [Range(1, 30)]
    public int ConnectTimeout { get; set; } = 3;

    /// <inheritdoc />
    [Range(100, 3600000)]
    public int ResponseTimeout { get; set; } = 10000;

    /// <inheritdoc />
    [Range(0, 255)]
    public int MaxLinkLayerRetries { get; set; } = 3;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DestinationHost)}: {DestinationHost}, {nameof(DestinationPort)}: {DestinationPort}";
}