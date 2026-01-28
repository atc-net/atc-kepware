namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.BuswareEthernet;

/// <summary>
/// Channel request properties for the Busware Ethernet driver.
/// </summary>
internal sealed class BuswareEthernetChannelRequest : ChannelRequestBase, IBuswareEthernetChannelRequest
{
    public BuswareEthernetChannelRequest()
        : base(DriverType.BuswareEthernet)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
