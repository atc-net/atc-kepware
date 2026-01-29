namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.YaskawaMpSeriesEthernet;

/// <summary>
/// Represents a Yaskawa MP Series Ethernet channel.
/// </summary>
public class YaskawaMpSeriesEthernetChannel : ChannelBase, IYaskawaMpSeriesEthernetChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}