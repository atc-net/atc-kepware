namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.KeyenceKvEthernet;

/// <summary>
/// Device properties for the Keyence KV Ethernet driver.
/// </summary>
internal class KeyenceKvEthernetDevice : DeviceBase, IKeyenceKvEthernetDevice
{
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = string.Empty;

    [JsonPropertyName("servermain.DEVICE_CONNECTION_TIMEOUT_SECONDS")]
    public int ConnectTimeoutSeconds { get; set; }

    [JsonPropertyName("servermain.DEVICE_REQUEST_TIMEOUT_MILLISECONDS")]
    public int RequestTimeoutMs { get; set; }

    [JsonPropertyName("servermain.DEVICE_RETRY_ATTEMPTS")]
    public int RetryAttempts { get; set; }

    [JsonPropertyName("servermain.DEVICE_INTER_REQUEST_DELAY_MILLISECONDS")]
    public int InterRequestDelayMs { get; set; }

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_ENABLE_ON_COMMUNICATIONS_FAILURES")]
    public bool DemoteOnFailure { get; set; }

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DEMOTE_AFTER_SUCCESSIVE_TIMEOUTS")]
    public int TimeoutsToDemote { get; set; }

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_PERIOD_MS")]
    public int DemotionPeriodMs { get; set; }

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DISCARD_WRITES")]
    public bool DiscardRequestsWhenDemoted { get; set; }

    [JsonPropertyName("keyence_kv_ethernet.DEVICE_PORT")]
    public int Port { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}
