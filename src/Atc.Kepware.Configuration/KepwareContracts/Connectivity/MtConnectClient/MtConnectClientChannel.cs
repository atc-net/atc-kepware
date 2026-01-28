namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.MtConnectClient;

/// <summary>
/// Channel properties for the MTConnect Client driver.
/// </summary>
internal class MtConnectClientChannel : ChannelBase, IMtConnectClientChannel
{
    [JsonPropertyName("mtconnect_client.CHANNEL_AGENT_URL")]
    public string AgentUrl { get; set; } = string.Empty;

    [JsonPropertyName("mtconnect_client.CHANNEL_PORT")]
    public int Port { get; set; }

    [JsonPropertyName("mtconnect_client.CHANNEL_HTTP_TIMEOUT")]
    public int HttpTimeout { get; set; }

    [JsonPropertyName("mtconnect_client.CHANNEL_SAMPLE_INTERVAL")]
    public int SampleInterval { get; set; }

    [JsonPropertyName("mtconnect_client.CHANNEL_PROBE_PATH")]
    public string ProbePath { get; set; } = string.Empty;

    [JsonPropertyName("mtconnect_client.CHANNEL_CURRENT_PATH")]
    public string CurrentPath { get; set; } = string.Empty;

    [JsonPropertyName("mtconnect_client.CHANNEL_SAMPLE_PATH")]
    public string SamplePath { get; set; } = string.Empty;

    public override string ToString()
        => $"{base.ToString()}, {nameof(AgentUrl)}: {AgentUrl}, {nameof(Port)}: {Port}, {nameof(HttpTimeout)}: {HttpTimeout}, {nameof(SampleInterval)}: {SampleInterval}, {nameof(ProbePath)}: {ProbePath}, {nameof(CurrentPath)}: {CurrentPath}, {nameof(SamplePath)}: {SamplePath}";
}
