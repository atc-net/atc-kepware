namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.TriconexEthernet;

/// <summary>
/// Channel properties for the Triconex Ethernet driver.
/// </summary>
internal sealed class TriconexEthernetChannel : ChannelBase, ITriconexEthernetChannel
{
    [JsonPropertyName("triconex_ethernet.CHANNEL_NETWORK_INTERFACE_ENABLE_REDUNDANCY")]
    public bool EnableNetworkRedundancy { get; set; }

    [JsonPropertyName("triconex_ethernet.CHANNEL_PRIMARY_NETWORK_ADAPTER")]
    public string? PrimaryNetworkAdapter { get; set; }

    [JsonPropertyName("triconex_ethernet.CHANNEL_SECONDARY_NETWORK_ADAPTER")]
    public string? SecondaryNetworkAdapter { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(EnableNetworkRedundancy)}: {EnableNetworkRedundancy}, {nameof(PrimaryNetworkAdapter)}: {PrimaryNetworkAdapter}, {nameof(SecondaryNetworkAdapter)}: {SecondaryNetworkAdapter}";
}
