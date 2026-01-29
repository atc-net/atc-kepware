namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.Ping;

/// <summary>
/// Represents a Ping channel.
/// </summary>
internal sealed class PingChannel : ChannelBase, IPingChannel
{
    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
