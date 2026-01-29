namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.WagoEthernet;

/// <summary>
/// Represents a Wago Ethernet channel creation request.
/// </summary>
public class WagoEthernetChannelRequest : ChannelRequestBase, IWagoEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WagoEthernetChannelRequest"/> class.
    /// </summary>
    public WagoEthernetChannelRequest()
        : base(DriverType.WagoEthernet)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}