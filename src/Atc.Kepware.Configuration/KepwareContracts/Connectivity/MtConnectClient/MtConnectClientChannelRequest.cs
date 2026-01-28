namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.MtConnectClient;

/// <summary>
/// Channel properties for the MTConnect Client driver.
/// </summary>
internal class MtConnectClientChannelRequest : ChannelRequestBase, IMtConnectClientChannelRequest
{
    public MtConnectClientChannelRequest()
        : base(DriverType.MtConnectClient)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("mtconnect_client.CHANNEL_AGENT_URL")]
    public string AgentUrl { get; set; } = string.Empty;

    /// <inheritdoc />
    [Range(1, 65535)]
    [JsonPropertyName("mtconnect_client.CHANNEL_PORT")]
    public int Port { get; set; } = 5000;

    /// <inheritdoc />
    [Range(1000, 30000)]
    [JsonPropertyName("mtconnect_client.CHANNEL_HTTP_TIMEOUT")]
    public int HttpTimeout { get; set; } = 10000;

    /// <inheritdoc />
    [Range(100, 60000)]
    [JsonPropertyName("mtconnect_client.CHANNEL_SAMPLE_INTERVAL")]
    public int SampleInterval { get; set; } = 1000;

    /// <inheritdoc />
    [MaxLength(256)]
    [JsonPropertyName("mtconnect_client.CHANNEL_PROBE_PATH")]
    public string ProbePath { get; set; } = "probe";

    /// <inheritdoc />
    [MaxLength(256)]
    [JsonPropertyName("mtconnect_client.CHANNEL_CURRENT_PATH")]
    public string CurrentPath { get; set; } = "current";

    /// <inheritdoc />
    [MaxLength(256)]
    [JsonPropertyName("mtconnect_client.CHANNEL_SAMPLE_PATH")]
    public string SamplePath { get; set; } = "sample";

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(AgentUrl)}: {AgentUrl}, {nameof(Port)}: {Port}, {nameof(HttpTimeout)}: {HttpTimeout}, {nameof(SampleInterval)}: {SampleInterval}, {nameof(ProbePath)}: {ProbePath}, {nameof(CurrentPath)}: {CurrentPath}, {nameof(SamplePath)}: {SamplePath}";
}
