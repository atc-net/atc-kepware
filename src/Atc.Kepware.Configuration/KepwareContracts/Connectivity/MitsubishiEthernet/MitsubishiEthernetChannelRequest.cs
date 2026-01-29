namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.MitsubishiEthernet;

/// <summary>
/// Channel request properties for the Mitsubishi Ethernet driver.
/// </summary>
internal sealed class MitsubishiEthernetChannelRequest : ChannelRequestBase, IMitsubishiEthernetChannelRequest
{
    public MitsubishiEthernetChannelRequest()
        : base(DriverType.MitsubishiEthernet)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}