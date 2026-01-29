namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.OpcDaClient;

/// <summary>
/// Device request properties for the OPC DA Client driver.
/// </summary>
internal sealed class OpcDaClientDeviceRequest : DeviceRequestBase, IOpcDaClientDeviceRequest
{
    public OpcDaClientDeviceRequest()
        : base(DriverType.OpcDaClient)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("opcdaclient.DEVICE_GROUP_NAME")]
    public string? GroupName { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("opcdaclient.DEVICE_UPDATE_MODE")]
    public OpcDaClientUpdateMode UpdateMode { get; set; } = OpcDaClientUpdateMode.Exception;

    /// <inheritdoc />
    [Range(0, 3600000)]
    [JsonPropertyName("opcdaclient.DEVICE_UPDATE_POLL_RATE_MS")]
    public int UpdatePollRate { get; set; } = 1000;

    /// <inheritdoc />
    [Range(0, 100)]
    [JsonPropertyName("opcdaclient.DEVICE_PERCENT_DEADBAND")]
    public float PercentDeadband { get; set; }

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("opcdaclient.DEVICE_LANGUAGE_ID")]
    public int LanguageId { get; set; } = 1033;

    /// <inheritdoc />
    [JsonPropertyName("opcdaclient.DEVICE_WRITE_METHOD")]
    public OpcDaClientReadWriteMethod WriteMethod { get; set; } = OpcDaClientReadWriteMethod.Asynchronous;

    /// <inheritdoc />
    [JsonPropertyName("opcdaclient.DEVICE_READ_METHOD")]
    public OpcDaClientReadWriteMethod ReadMethod { get; set; } = OpcDaClientReadWriteMethod.Asynchronous;

    /// <inheritdoc />
    [Range(1, 512)]
    [JsonPropertyName("opcdaclient.DEVICE_MAX_ITEMS_PER_READ")]
    public int MaxItemsPerRead { get; set; } = 512;

    /// <inheritdoc />
    [Range(1, 512)]
    [JsonPropertyName("opcdaclient.DEVICE_MAX_ITEMS_PER_WRITE")]
    public int MaxItemsPerWrite { get; set; } = 512;

    /// <inheritdoc />
    [Range(100, 30000)]
    [JsonPropertyName("opcdaclient.DEVICE_READ_TIMEOUT_MS")]
    public int ReadTimeout { get; set; } = 1000;

    /// <inheritdoc />
    [Range(100, 30000)]
    [JsonPropertyName("opcdaclient.DEVICE_WRITE_TIMEOUT_MS")]
    public int WriteTimeout { get; set; } = 1000;

    /// <inheritdoc />
    [JsonPropertyName("opcdaclient.DEVICE_READ_AFTER_WRITE")]
    public bool ReadAfterWrite { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("opcdaclient.DEVICE_WATCHDOG")]
    public bool Watchdog { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("opcdaclient.DEVICE_ITEM_ID_OF_WATCHDOG_TAG")]
    public string? WatchdogItemId { get; set; }

    /// <inheritdoc />
    [Range(2, 10)]
    [JsonPropertyName("opcdaclient.DEVICE_MISSED_UPDATES_BEFORE_RECONNECT")]
    public int MissedUpdatesBeforeReconnect { get; set; } = 3;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(UpdateMode)}: {UpdateMode}, {nameof(UpdatePollRate)}: {UpdatePollRate}";
}
