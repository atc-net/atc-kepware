namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.CustomInterface;

/// <summary>
/// Device properties for the Custom Interface driver.
/// </summary>
internal sealed class CustomInterfaceDeviceRequest : DeviceRequestBase, ICustomInterfaceDeviceRequest
{
    public CustomInterfaceDeviceRequest()
        : base(DriverType.CustomInterface)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("custom_interface.DEVICE_OVERRIDE_CONFIGURATION_FILE")]
    public bool OverrideConfigurationFile { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("custom_interface.DEVICE_SHARED_MEMORY_DEVICE_OFFSET")]
    [Range(0, 2147483647)]
    public int SharedMemoryDeviceOffset { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("custom_interface.DEVICE_DEVICE_IDENTIFIER")]
    [MaxLength(256)]
    public string? DeviceIdentifier { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("custom_interface.DEVICE_SCAN_RATE_FLOOR_MILLISECONDS_V61")]
    [Range(100, 60000)]
    public int ScanRateFloorMilliseconds { get; set; } = 250;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(OverrideConfigurationFile)}: {OverrideConfigurationFile}, {nameof(SharedMemoryDeviceOffset)}: {SharedMemoryDeviceOffset}, {nameof(DeviceIdentifier)}: {DeviceIdentifier}, {nameof(ScanRateFloorMilliseconds)}: {ScanRateFloorMilliseconds}";
}
