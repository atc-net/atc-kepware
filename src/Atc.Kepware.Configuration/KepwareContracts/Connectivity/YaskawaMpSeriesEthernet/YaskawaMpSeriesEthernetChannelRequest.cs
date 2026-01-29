namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.YaskawaMpSeriesEthernet;

/// <summary>
/// Channel request properties for the Yaskawa MP Series Ethernet driver.
/// </summary>
internal sealed class YaskawaMpSeriesEthernetChannelRequest : ChannelRequestBase, IYaskawaMpSeriesEthernetChannelRequest
{
    public YaskawaMpSeriesEthernetChannelRequest()
        : base(DriverType.YaskawaMpSeriesEthernet)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
