namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.TriconexEthernet;

/// <summary>
/// Channel request properties for the Triconex Ethernet driver.
/// </summary>
internal sealed class TriconexEthernetChannelRequest : ChannelRequestBase, ITriconexEthernetChannelRequest
{
    public TriconexEthernetChannelRequest()
        : base(DriverType.TriconexEthernet)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("triconex_ethernet.CHANNEL_NETWORK_INTERFACE_ENABLE_REDUNDANCY")]
    public bool EnableNetworkRedundancy { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("triconex_ethernet.CHANNEL_PRIMARY_NETWORK_ADAPTER")]
    public string? PrimaryNetworkAdapter { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("triconex_ethernet.CHANNEL_SECONDARY_NETWORK_ADAPTER")]
    public string? SecondaryNetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(EnableNetworkRedundancy)}: {EnableNetworkRedundancy}, {nameof(PrimaryNetworkAdapter)}: {PrimaryNetworkAdapter}, {nameof(SecondaryNetworkAdapter)}: {SecondaryNetworkAdapter}";
}