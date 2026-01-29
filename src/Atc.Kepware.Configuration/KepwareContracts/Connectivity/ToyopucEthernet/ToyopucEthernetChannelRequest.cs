namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.ToyopucEthernet;

/// <summary>
/// Channel request properties for the Toyopuc Ethernet driver.
/// </summary>
internal sealed class ToyopucEthernetChannelRequest : ChannelRequestBase, IToyopucEthernetChannelRequest
{
    public ToyopucEthernetChannelRequest()
        : base(DriverType.ToyopucEthernet)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
