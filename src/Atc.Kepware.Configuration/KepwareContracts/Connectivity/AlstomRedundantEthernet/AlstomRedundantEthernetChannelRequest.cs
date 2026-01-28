namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AlstomRedundantEthernet;

/// <summary>
/// Channel request properties for the Alstom Redundant Ethernet driver.
/// </summary>
internal sealed class AlstomRedundantEthernetChannelRequest : ChannelRequestBase, IAlstomRedundantEthernetChannelRequest
{
    public AlstomRedundantEthernetChannelRequest()
        : base(DriverType.AlstomRedundantEthernet)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("alstom_redundant_ethernet.CHANNEL_PRIMARY_NETWORK_ADAPTER")]
    public string? PrimaryNetworkAdapter { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("alstom_redundant_ethernet.CHANNEL_SECONDARY_NETWORK_ADAPTER")]
    public string? SecondaryNetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(PrimaryNetworkAdapter)}: {PrimaryNetworkAdapter}, {nameof(SecondaryNetworkAdapter)}: {SecondaryNetworkAdapter}";
}
