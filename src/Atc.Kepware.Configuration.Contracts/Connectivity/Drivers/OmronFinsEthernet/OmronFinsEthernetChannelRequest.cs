namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.OmronFinsEthernet;

/// <summary>
/// Represents an Omron FINS Ethernet channel creation request.
/// </summary>
public class OmronFinsEthernetChannelRequest : ChannelRequestBase, IOmronFinsEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OmronFinsEthernetChannelRequest"/> class.
    /// </summary>
    public OmronFinsEthernetChannelRequest()
        : base(DriverType.OmronFinsEthernet)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    [Range(1, 65535)]
    public int Port { get; set; } = 9600;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Port)}: {Port}";
}