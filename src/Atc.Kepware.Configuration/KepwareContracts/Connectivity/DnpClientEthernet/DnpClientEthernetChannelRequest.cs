namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.DnpClientEthernet;

/// <summary>
/// Channel request properties for the DNP Client Ethernet driver.
/// </summary>
internal sealed class DnpClientEthernetChannelRequest : ChannelRequestBase, IDnpClientEthernetChannelRequest
{
    public DnpClientEthernetChannelRequest()
        : base(DriverType.DnpClientEthernet)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
