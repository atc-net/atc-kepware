namespace Atc.Kepware.Configuration.KepwareContracts;

internal abstract class DeviceRequestBase
{
    protected DeviceRequestBase(
        DriverType deviceDriver)
    {
        Driver = deviceDriver.GetDescription();
    }

    /// <summary>
    /// Specifies the identity of this object.
    /// </summary>
    [MinLength(1)]
    [MaxLength(256)]
    [JsonPropertyName("common.ALLTYPES_NAME")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Summary of this object or its use.
    /// </summary>
    [MaxLength(255)]
    [JsonPropertyName("common.ALLTYPES_DESCRIPTION")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("servermain.MULTIPLE_TYPES_DEVICE_DRIVER")]
    public string Driver { get; private init; }

    /// <summary>
    /// Indicates whether or not communication with the physical device is active (enabled) or turned off (disabled).
    /// When disabled, data is marked invalid and write operations are not accepted.
    /// </summary>
    [JsonPropertyName("servermain.DEVICE_DATA_COLLECTION")]
    public bool DataCollection { get; set; } = true;

    /// <summary>
    /// Use generic valid OPC data without communicating with the physical device.
    /// </summary>
    [JsonPropertyName("servermain.DEVICE_SIMULATED")]
    public bool Simulated { get; set; }

    /// <summary>
    /// Specifies the method for determining how often tags in the device are scanned.
    /// </summary>
    [JsonPropertyName("servermain.DEVICE_SCAN_MODE")]
    public DeviceScanModeType ScanMode { get; set; } = DeviceScanModeType.RespectClientSpecifiedScanRate;

    /// <summary>
    /// Indicates the frequency of scanning in milliseconds.
    /// When the Scan Mode is Request data no faster than Scan Rate, this is the maximum rate.
    /// When the Scan Mode is Request all data at Scan Rate, all tags are scanned at this rate.
    /// </summary>
    /// <remarks>
    /// Property is only applicable when <see cref="DeviceScanModeType"/> is <see cref="DeviceScanModeType.RequestDataNoFasterThanScanRate"/> or <see cref="DeviceScanModeType.RequestAllDataAtScanRate"/>.
    /// </remarks>
    [Range(10, 99999990)]
    [JsonPropertyName("servermain.DEVICE_SCAN_MODE_RATE_MS")]
    public int ScanRate { get; set; } = 1000;

    /// <summary>
    /// Determines if the first updates for new tag references should be returned from stored (cached) data
    /// rather than polling devices immediately.
    /// </summary>
    [JsonPropertyName("servermain.DEVICE_SCAN_MODE_PROVIDE_INITIAL_UPDATES_FROM_CACHE")]
    public bool InitialUpdatesFromCache { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(Driver)}: {Driver}, {nameof(DataCollection)}: {DataCollection}, {nameof(Simulated)}: {Simulated}, {nameof(ScanMode)}: {ScanMode}, {nameof(ScanRate)}: {ScanRate}, {nameof(InitialUpdatesFromCache)}: {InitialUpdatesFromCache}";
}