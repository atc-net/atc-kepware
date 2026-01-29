namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.ToyopucEthernet;

/// <summary>
/// Channel properties for the Toyopuc Ethernet driver.
/// </summary>
internal sealed class ToyopucEthernetChannel : ChannelBase, IToyopucEthernetChannel
{
    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}