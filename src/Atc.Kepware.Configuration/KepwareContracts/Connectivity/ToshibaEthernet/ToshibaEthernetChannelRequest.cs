namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.ToshibaEthernet;

/// <summary>
/// Channel request properties for the Toshiba Ethernet driver.
/// </summary>
internal sealed class ToshibaEthernetChannelRequest : ChannelRequestBase, IToshibaEthernetChannelRequest
{
    public ToshibaEthernetChannelRequest()
        : base(DriverType.ToshibaEthernet)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
