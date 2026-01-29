namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.OmronFinsEthernet;

/// <summary>
/// Channel properties for the Omron FINS Ethernet driver.
/// </summary>
internal sealed class OmronFinsEthernetChannel : ChannelBase, IOmronFinsEthernetChannel
{
    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("omron_fins_ethernet.CHANNEL_PORT_NUMBER")]
    public int Port { get; set; } = 9600;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Port)}: {Port}";
}