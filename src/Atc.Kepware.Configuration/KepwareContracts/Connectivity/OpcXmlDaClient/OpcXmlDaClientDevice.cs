namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.OpcXmlDaClient;

/// <summary>
/// Device properties for the OPC XML-DA Client driver.
/// </summary>
internal sealed class OpcXmlDaClientDevice : DeviceBase, IOpcXmlDaClientDevice
{
    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.DEVICE_UPDATE_MODE")]
    public OpcXmlDaClientUpdateMode UpdateMode { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.DEVICE_UPDATE_POLL_RATE_MS")]
    public int UpdatePollRate { get; set; } = 5000;

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.DEVICE_LANGUAGE_ID")]
    public int LanguageId { get; set; } = 1033;

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.DEVICE_HOLD_TIME_MS")]
    public int HoldTime { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.DEVICE_WAIT_TIME_MS")]
    public int WaitTime { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.DEVICE_PERCENT_DEADBAND")]
    public float PercentDeadband { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.DEVICE_MAX_ITEMS_PER_READ")]
    public int MaxItemsPerRead { get; set; } = 512;

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.DEVICE_MAX_ITEMS_PER_WRITE")]
    public int MaxItemsPerWrite { get; set; } = 512;

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.DEVICE_READ_TIMEOUT_MS")]
    public int ReadTimeout { get; set; } = 5000;

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.DEVICE_WRITE_TIMEOUT_MS")]
    public int WriteTimeout { get; set; } = 5000;

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.DEVICE_READ_AFTER_WRITE")]
    public bool ReadAfterWrite { get; set; } = true;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(UpdateMode)}: {UpdateMode}, {nameof(MaxItemsPerRead)}: {MaxItemsPerRead}, {nameof(MaxItemsPerWrite)}: {MaxItemsPerWrite}";
}