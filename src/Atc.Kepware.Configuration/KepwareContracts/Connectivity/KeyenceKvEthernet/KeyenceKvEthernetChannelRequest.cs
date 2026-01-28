namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.KeyenceKvEthernet;

/// <summary>
/// Channel request properties for the Keyence KV Ethernet driver.
/// </summary>
internal class KeyenceKvEthernetChannelRequest : ChannelRequestBase, IKeyenceKvEthernetChannelRequest
{
    public KeyenceKvEthernetChannelRequest()
        : base(DriverType.KeyenceKvEthernet)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("keyence_kv_ethernet.CHANNEL_PORT")]
    public int Port { get; set; } = 8501;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}, {nameof(Port)}: {Port}";
}
