namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.ScanivalveEthernet;

/// <summary>
/// Channel request properties for the Scanivalve Ethernet driver.
/// </summary>
internal sealed class ScanivalveEthernetChannelRequest : ChannelRequestBase, IScanivalveEthernetChannelRequest
{
    public ScanivalveEthernetChannelRequest()
        : base(DriverType.ScanivalveEthernet)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}