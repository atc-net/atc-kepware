namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.BuswareEthernet;

/// <summary>
/// Represents a Busware Ethernet channel creation request.
/// </summary>
public class BuswareEthernetChannelRequest : ChannelRequestBase, IBuswareEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuswareEthernetChannelRequest"/> class.
    /// </summary>
    public BuswareEthernetChannelRequest()
        : base(DriverType.BuswareEthernet)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
