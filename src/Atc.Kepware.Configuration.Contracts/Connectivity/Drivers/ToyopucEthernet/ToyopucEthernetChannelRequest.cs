namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.ToyopucEthernet;

/// <summary>
/// Represents a Toyopuc Ethernet channel creation request.
/// </summary>
public class ToyopucEthernetChannelRequest : ChannelRequestBase, IToyopucEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ToyopucEthernetChannelRequest"/> class.
    /// </summary>
    public ToyopucEthernetChannelRequest()
        : base(DriverType.ToyopucEthernet)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}