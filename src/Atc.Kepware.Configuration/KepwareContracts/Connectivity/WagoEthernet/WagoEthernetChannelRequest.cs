namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.WagoEthernet;

/// <summary>
/// Channel request properties for the Wago Ethernet driver.
/// </summary>
internal sealed class WagoEthernetChannelRequest : ChannelRequestBase, IWagoEthernetChannelRequest
{
    public WagoEthernetChannelRequest()
        : base(DriverType.WagoEthernet)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
