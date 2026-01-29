namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.FanucFocasEthernet;

/// <summary>
/// Channel request properties for the Fanuc Focas Ethernet driver.
/// </summary>
internal sealed class FanucFocasEthernetChannelRequest : ChannelRequestBase, IFanucFocasEthernetChannelRequest
{
    public FanucFocasEthernetChannelRequest()
        : base(DriverType.FanucFocasEthernet)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}