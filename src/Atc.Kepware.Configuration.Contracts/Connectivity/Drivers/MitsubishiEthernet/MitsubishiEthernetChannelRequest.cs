namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.MitsubishiEthernet;

/// <summary>
/// Represents a Mitsubishi Ethernet channel creation request.
/// </summary>
public class MitsubishiEthernetChannelRequest : ChannelRequestBase, IMitsubishiEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MitsubishiEthernetChannelRequest"/> class.
    /// </summary>
    public MitsubishiEthernetChannelRequest()
        : base(DriverType.MitsubishiEthernet)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}