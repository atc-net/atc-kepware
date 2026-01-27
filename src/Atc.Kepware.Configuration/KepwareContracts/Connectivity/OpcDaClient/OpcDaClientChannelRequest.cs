namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.OpcDaClient;

/// <summary>
/// Channel request properties for the OPC DA Client driver.
/// </summary>
internal sealed class OpcDaClientChannelRequest : ChannelRequestBase, IOpcDaClientChannelRequest
{
    public OpcDaClientChannelRequest()
        : base(DriverType.OpcDaClient)
    {
    }

    /// <inheritdoc />
    [Required]
    [JsonPropertyName("opcdaclient.CHANNEL_PROG_ID")]
    public string ProgramId { get; set; } = string.Empty;

    /// <inheritdoc />
    [JsonPropertyName("opcdaclient.CHANNEL_REMOTE_MACHINE_NAME")]
    public string? RemoteMachineName { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("opcdaclient.CHANNEL_CONNECTION_TYPE")]
    public OpcDaClientConnectionType ConnectionType { get; set; } = OpcDaClientConnectionType.Any;

    /// <inheritdoc />
    [Range(5, 600)]
    [JsonPropertyName("opcdaclient.CHANNEL_FAILED_CONNECTION_RETRY_INTERVAL_SEC")]
    public int FailedConnectionRetryInterval { get; set; } = 5;

    /// <inheritdoc />
    [Range(5, 30)]
    [JsonPropertyName("opcdaclient.CHANNEL_SERVER_STATUS_QUERY_INTERVAL_SEC")]
    public int ServerStatusQueryInterval { get; set; } = 5;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(ProgramId)}: {ProgramId}, {nameof(ConnectionType)}: {ConnectionType}";
}
