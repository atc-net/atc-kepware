namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.BristolBsapIp;

/// <summary>
/// Channel request properties for the Bristol BSAP IP driver.
/// </summary>
internal sealed class BristolBsapIpChannelRequest : ChannelRequestBase, IBristolBsapIpChannelRequest
{
    public BristolBsapIpChannelRequest()
        : base(DriverType.BristolBsapIp)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    [Range(0, 500)]
    [JsonPropertyName("servermain.CHANNEL_COMMUNICATIONS_SERIALIZATION_VIRTUAL_NETWORK")]
    public int? VirtualNetwork { get; set; }

    /// <inheritdoc />
    [Range(1, 99)]
    [JsonPropertyName("servermain.CHANNEL_COMMUNICATIONS_SERIALIZATION_TRANSACTIONS_PER_CYCLE")]
    public int TransactionsPerCycle { get; set; } = 1;

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_COMMUNICATIONS_SERIALIZATION_NETWORK_MODE")]
    public BristolBsapIpChannelNetworkModeType NetworkMode { get; set; } = BristolBsapIpChannelNetworkModeType.LoadBalanced;

    /// <inheritdoc />
    [Range(1, 65535)]
    [JsonPropertyName("bristol_bsap_ip.CHANNEL_UDP_PORT_DECIMAL")]
    public int UdpPort { get; set; } = 1234;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}, {nameof(VirtualNetwork)}: {VirtualNetwork}, {nameof(TransactionsPerCycle)}: {TransactionsPerCycle}, {nameof(NetworkMode)}: {NetworkMode}, {nameof(UdpPort)}: {UdpPort}";
}
