namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.SixnetEthertrak;

/// <summary>
/// Channel request properties for the SIXNET EtherTRAK driver.
/// </summary>
internal sealed class SixnetEthertrakChannelRequest : ChannelRequestBase, ISixnetEthertrakChannelRequest
{
    public SixnetEthertrakChannelRequest()
        : base(DriverType.SixnetEthertrak)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
