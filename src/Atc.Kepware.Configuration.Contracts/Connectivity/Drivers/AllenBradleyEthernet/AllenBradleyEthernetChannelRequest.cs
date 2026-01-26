namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AllenBradleyEthernet;

/// <summary>
/// Represents an Allen-Bradley Ethernet channel creation request.
/// </summary>
public class AllenBradleyEthernetChannelRequest : ChannelRequestBase, IAllenBradleyEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AllenBradleyEthernetChannelRequest"/> class.
    /// </summary>
    public AllenBradleyEthernetChannelRequest()
        : base(DriverType.AllenBradleyEthernet)
    {
    }

    /// <summary>
    /// Gets or sets the network adapter to bind for Ethernet communication.
    /// </summary>
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
