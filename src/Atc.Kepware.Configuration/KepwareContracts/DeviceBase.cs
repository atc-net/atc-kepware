namespace Atc.Kepware.Configuration.KepwareContracts;

internal class DeviceBase
{
    /// <summary>
    /// Specify the identity of this object.
    /// </summary>
    [JsonPropertyName("common.ALLTYPES_NAME")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Provide a brief summary of this object or its use.
    /// </summary>
    [JsonPropertyName("common.ALLTYPES_DESCRIPTION")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("servermain.MULTIPLE_TYPES_DEVICE_DRIVER")]
    public string Driver { get; set; } = string.Empty;

    /// <summary>
    /// Select whether or not communication with the physical device is active (enabled) or turned off (disabled).
    /// When disabled, data is marked invalid and write operations are not accepted.
    /// </summary>
    [JsonPropertyName("servermain.DEVICE_DATA_COLLECTION")]
    public bool DataCollection { get; set; }

    /// <summary>
    /// Use generic valid OPC data without communicating with the physical device.
    /// </summary>
    [JsonPropertyName("servermain.DEVICE_SIMULATED")]
    public bool Simulated { get; set; }

    /// <summary>
    /// The total number of user defined tags assigned to the device.
    /// </summary>
    [JsonPropertyName("servermain.DEVICE_STATIC_TAG_COUNT")]
    public int TagCount { get; set; }

    /// <summary>
    /// Specify the method for determining how often tags in the device are scanned.
    /// </summary>
    [JsonPropertyName("servermain.DEVICE_SCAN_MODE")]
    public DeviceScanModeType ScanMode { get; set; }

    /// <summary>
    /// Indicate the frequency of scanning in milliseconds.
    /// When the Scan Mode is Request data no faster than Scan Rate, this is the maximum rate.
    /// When the Scan Mode is Request all data at Scan Rate, all tags are scanned at this rate.
    /// </summary>
    /// <remarks>
    /// Property is only applicable when <see cref="DeviceScanModeType"/> is <see cref="DeviceScanModeType.RequestDataNoFasterThanScanRate"/> or <see cref="DeviceScanModeType.RequestAllDataAtScanRate"/>.
    /// </remarks>
    [JsonPropertyName("servermain.DEVICE_SCAN_MODE_RATE_MS")]
    public int ScanRate { get; set; }

    /// <summary>
    /// Provide the first updates for new tag references from stored (cached) data
    /// rather than polling devices immediately.
    /// </summary>
    [JsonPropertyName("servermain.DEVICE_SCAN_MODE_PROVIDE_INITIAL_UPDATES_FROM_CACHE")]
    public bool InitialUpdatesFromCache { get; set; }
}