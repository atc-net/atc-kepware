namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.ScanivalveEthernet;

/// <summary>
/// Channel properties for the Scanivalve Ethernet driver.
/// </summary>
internal sealed class ScanivalveEthernetChannel : ChannelBase, IScanivalveEthernetChannel
{
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
