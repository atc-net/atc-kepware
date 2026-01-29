namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.SattBusEthernet;

/// <summary>
/// Channel request properties for the SattBus Ethernet driver.
/// </summary>
internal sealed class SattBusEthernetChannelRequest : ChannelRequestBase, ISattBusEthernetChannelRequest
{
    public SattBusEthernetChannelRequest()
        : base(DriverType.SattBusEthernet)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
