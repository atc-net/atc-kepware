namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.HoneywellHc900Ethernet;

/// <summary>
/// Channel request properties for the Honeywell HC900 Ethernet driver.
/// </summary>
internal sealed class HoneywellHc900EthernetChannelRequest : ChannelRequestBase, IHoneywellHc900EthernetChannelRequest
{
    public HoneywellHc900EthernetChannelRequest()
        : base(DriverType.HoneywellHc900Ethernet)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}