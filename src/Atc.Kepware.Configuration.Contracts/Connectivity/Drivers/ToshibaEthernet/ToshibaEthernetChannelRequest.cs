namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.ToshibaEthernet;

/// <summary>
/// Represents a Toshiba Ethernet channel creation request.
/// </summary>
public class ToshibaEthernetChannelRequest : ChannelRequestBase, IToshibaEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ToshibaEthernetChannelRequest"/> class.
    /// </summary>
    public ToshibaEthernetChannelRequest()
        : base(DriverType.ToshibaEthernet)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
