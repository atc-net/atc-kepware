namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.CutlerHammerElcEthernet;

/// <summary>
/// Represents a Cutler-Hammer ELC Ethernet channel creation request.
/// </summary>
public class CutlerHammerElcEthernetChannelRequest : ChannelRequestBase, ICutlerHammerElcEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CutlerHammerElcEthernetChannelRequest"/> class.
    /// </summary>
    public CutlerHammerElcEthernetChannelRequest()
        : base(DriverType.CutlerHammerElcEthernet)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}