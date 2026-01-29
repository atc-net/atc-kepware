namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.KeyenceKvEthernet;

/// <summary>
/// Channel properties for the Keyence KV Ethernet driver.
/// </summary>
internal class KeyenceKvEthernetChannel : ChannelBase, IKeyenceKvEthernetChannel
{
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}