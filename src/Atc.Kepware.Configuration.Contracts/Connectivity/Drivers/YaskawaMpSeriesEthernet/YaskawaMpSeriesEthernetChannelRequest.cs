namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.YaskawaMpSeriesEthernet;

/// <summary>
/// Represents a Yaskawa MP Series Ethernet channel creation request.
/// </summary>
public class YaskawaMpSeriesEthernetChannelRequest : ChannelRequestBase, IYaskawaMpSeriesEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="YaskawaMpSeriesEthernetChannelRequest"/> class.
    /// </summary>
    public YaskawaMpSeriesEthernetChannelRequest()
        : base(DriverType.YaskawaMpSeriesEthernet)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}