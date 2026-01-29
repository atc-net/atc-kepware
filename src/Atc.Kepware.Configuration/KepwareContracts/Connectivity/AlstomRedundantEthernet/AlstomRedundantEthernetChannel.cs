namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AlstomRedundantEthernet;

/// <summary>
/// Channel properties for the Alstom Redundant Ethernet driver.
/// </summary>
internal sealed class AlstomRedundantEthernetChannel : ChannelBase, IAlstomRedundantEthernetChannel
{
    [JsonPropertyName("alstom_redundant_ethernet.CHANNEL_PRIMARY_NETWORK_ADAPTER")]
    public string? PrimaryNetworkAdapter { get; set; }

    [JsonPropertyName("alstom_redundant_ethernet.CHANNEL_SECONDARY_NETWORK_ADAPTER")]
    public string? SecondaryNetworkAdapter { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(PrimaryNetworkAdapter)}: {PrimaryNetworkAdapter}, {nameof(SecondaryNetworkAdapter)}: {SecondaryNetworkAdapter}";
}