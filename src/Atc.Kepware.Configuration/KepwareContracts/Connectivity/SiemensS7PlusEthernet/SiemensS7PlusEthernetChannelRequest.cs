namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.SiemensS7PlusEthernet;

/// <summary>
/// Channel request properties for the Siemens S7 Plus Ethernet driver.
/// </summary>
internal sealed class SiemensS7PlusEthernetChannelRequest : ChannelRequestBase, ISiemensS7PlusEthernetChannelRequest
{
    public SiemensS7PlusEthernetChannelRequest()
        : base(DriverType.SiemensS7PlusEthernet)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
