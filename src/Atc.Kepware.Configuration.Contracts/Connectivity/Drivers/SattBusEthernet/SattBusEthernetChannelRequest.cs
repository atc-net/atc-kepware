namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.SattBusEthernet;

/// <summary>
/// Represents a SattBus Ethernet channel creation request.
/// </summary>
public class SattBusEthernetChannelRequest : ChannelRequestBase, ISattBusEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SattBusEthernetChannelRequest"/> class.
    /// </summary>
    public SattBusEthernetChannelRequest()
        : base(DriverType.SattBusEthernet)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
