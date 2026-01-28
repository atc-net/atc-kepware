namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.KeyenceKvEthernet;

/// <summary>
/// Device request properties for the Keyence KV Ethernet driver.
/// </summary>
internal class KeyenceKvEthernetDeviceRequest : DeviceRequestBase, IKeyenceKvEthernetDeviceRequest
{
    public KeyenceKvEthernetDeviceRequest()
        : base(DriverType.KeyenceKvEthernet)
    {
    }

    /// <inheritdoc />
    [Required]
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = string.Empty;

    /// <inheritdoc />
    [Range(1, 30)]
    [JsonPropertyName("servermain.DEVICE_CONNECTION_TIMEOUT_SECONDS")]
    public int ConnectTimeoutSeconds { get; set; } = 3;

    /// <inheritdoc />
    [Range(10, 9999999)]
    [JsonPropertyName("servermain.DEVICE_REQUEST_TIMEOUT_MILLISECONDS")]
    public int RequestTimeoutMs { get; set; } = 1000;

    /// <inheritdoc />
    [Range(1, 10)]
    [JsonPropertyName("servermain.DEVICE_RETRY_ATTEMPTS")]
    public int RetryAttempts { get; set; } = 3;

    /// <inheritdoc />
    [Range(0, 30000)]
    [JsonPropertyName("servermain.DEVICE_INTER_REQUEST_DELAY_MILLISECONDS")]
    public int InterRequestDelayMs { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_ENABLE_ON_COMMUNICATIONS_FAILURES")]
    public bool DemoteOnFailure { get; set; }

    /// <inheritdoc />
    [Range(1, 30)]
    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DEMOTE_AFTER_SUCCESSIVE_TIMEOUTS")]
    public int TimeoutsToDemote { get; set; } = 3;

    /// <inheritdoc />
    [Range(100, 3600000)]
    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_PERIOD_MS")]
    public int DemotionPeriodMs { get; set; } = 10000;

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DISCARD_WRITES")]
    public bool DiscardRequestsWhenDemoted { get; set; }

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("keyence_kv_ethernet.DEVICE_PORT")]
    public int Port { get; set; } = 8501;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}
