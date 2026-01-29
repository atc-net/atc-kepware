namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.Opto22Ethernet;

/// <summary>
/// Channel request properties for the Opto 22 Ethernet driver.
/// </summary>
internal sealed class Opto22EthernetChannelRequest : ChannelRequestBase, IOpto22EthernetChannelRequest
{
    public Opto22EthernetChannelRequest()
        : base(DriverType.Opto22Ethernet)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}