namespace Atc.Kepware.Configuration.KepwareContracts;

internal abstract class DeviceRequestBase : IDeviceRequestBase
{
    protected DeviceRequestBase(
        DriverType deviceDriver)
    {
        Driver = deviceDriver.GetDescription();
    }

    /// <inheritdoc />
    [KeyString]
    [JsonPropertyName("common.ALLTYPES_NAME")]
    public string Name { get; set; } = string.Empty;

    /// <inheritdoc />
    [MaxLength(255)]
    [JsonPropertyName("common.ALLTYPES_DESCRIPTION")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("servermain.MULTIPLE_TYPES_DEVICE_DRIVER")]
    public string Driver { get; private init; }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_DATA_COLLECTION")]
    public bool DataCollection { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_SIMULATED")]
    public bool Simulated { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_SCAN_MODE")]
    public DeviceScanModeType ScanMode { get; set; } = DeviceScanModeType.RespectClientSpecifiedScanRate;

    /// <inheritdoc />
    [Range(10, 99999990)]
    [JsonPropertyName("servermain.DEVICE_SCAN_MODE_RATE_MS")]
    public int ScanRate { get; set; } = 1000;

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_SCAN_MODE_PROVIDE_INITIAL_UPDATES_FROM_CACHE")]
    public bool InitialUpdatesFromCache { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(Driver)}: {Driver}, {nameof(DataCollection)}: {DataCollection}, {nameof(Simulated)}: {Simulated}, {nameof(ScanMode)}: {ScanMode}, {nameof(ScanRate)}: {ScanRate}, {nameof(InitialUpdatesFromCache)}: {InitialUpdatesFromCache}";
}