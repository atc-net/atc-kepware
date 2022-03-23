namespace Atc.Kepware.Configuration.KepwareContracts;

internal class DeviceBase : IDeviceBase
{
    /// <inheritdoc />
    [JsonPropertyName("common.ALLTYPES_NAME")]
    public string Name { get; set; } = string.Empty;

    /// <inheritdoc />
    [JsonPropertyName("common.ALLTYPES_DESCRIPTION")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("servermain.MULTIPLE_TYPES_DEVICE_DRIVER")]
    public string Driver { get; set; } = string.Empty;

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_DATA_COLLECTION")]
    public bool DataCollection { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_SIMULATED")]
    public bool Simulated { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_STATIC_TAG_COUNT")]
    public int TagCount { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_SCAN_MODE")]
    public DeviceScanModeType ScanMode { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_SCAN_MODE_RATE_MS")]
    public int ScanRate { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_SCAN_MODE_PROVIDE_INITIAL_UPDATES_FROM_CACHE")]
    public bool InitialUpdatesFromCache { get; set; }
}