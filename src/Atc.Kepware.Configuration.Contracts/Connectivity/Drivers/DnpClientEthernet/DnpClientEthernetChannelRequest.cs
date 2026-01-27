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
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
