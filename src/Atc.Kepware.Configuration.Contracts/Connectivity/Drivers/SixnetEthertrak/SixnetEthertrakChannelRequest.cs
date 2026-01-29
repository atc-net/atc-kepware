namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.SixnetEthertrak;

/// <summary>
/// Represents a SIXNET EtherTRAK channel creation request.
/// </summary>
public class SixnetEthertrakChannelRequest : ChannelRequestBase, ISixnetEthertrakChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SixnetEthertrakChannelRequest"/> class.
    /// </summary>
    public SixnetEthertrakChannelRequest()
        : base(DriverType.SixnetEthertrak)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
