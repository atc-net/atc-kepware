namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.MtConnectClient;

/// <summary>
/// Channel properties for the MTConnect Client driver.
/// </summary>
public sealed class MtConnectClientChannelRequest : ChannelRequestBase, IMtConnectClientChannelRequest
{
    public MtConnectClientChannelRequest()
        : base(DriverType.MtConnectClient)
    {
    }

    /// <inheritdoc />
    public string AgentUrl { get; set; } = string.Empty;

    /// <inheritdoc />
    [Range(1, 65535)]
    public int Port { get; set; } = 5000;

    /// <inheritdoc />
    [Range(1000, 30000)]
    public int HttpTimeout { get; set; } = 10000;

    /// <inheritdoc />
    [Range(100, 60000)]
    public int SampleInterval { get; set; } = 1000;

    /// <inheritdoc />
    [MaxLength(256)]
    public string ProbePath { get; set; } = "probe";

    /// <inheritdoc />
    [MaxLength(256)]
    public string CurrentPath { get; set; } = "current";

    /// <inheritdoc />
    [MaxLength(256)]
    public string SamplePath { get; set; } = "sample";

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(AgentUrl)}: {AgentUrl}, {nameof(Port)}: {Port}, {nameof(HttpTimeout)}: {HttpTimeout}, {nameof(SampleInterval)}: {SampleInterval}, {nameof(ProbePath)}: {ProbePath}, {nameof(CurrentPath)}: {CurrentPath}, {nameof(SamplePath)}: {SamplePath}";
}
