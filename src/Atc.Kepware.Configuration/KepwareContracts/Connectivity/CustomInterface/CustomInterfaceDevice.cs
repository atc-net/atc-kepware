namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.CustomInterface;

/// <summary>
/// Device properties for the Custom Interface driver.
/// </summary>
internal sealed class CustomInterfaceDevice : DeviceBase, ICustomInterfaceDevice
{
    /// <inheritdoc />
    [JsonPropertyName("custom_interface.DEVICE_OVERRIDE_CONFIGURATION_FILE")]
    public bool OverrideConfigurationFile { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("custom_interface.DEVICE_SHARED_MEMORY_DEVICE_OFFSET")]
    public int SharedMemoryDeviceOffset { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("custom_interface.DEVICE_DEVICE_IDENTIFIER")]
    public string? DeviceIdentifier { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("custom_interface.DEVICE_SCAN_RATE_FLOOR_MILLISECONDS_V61")]
    public int ScanRateFloorMilliseconds { get; set; } = 250;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(OverrideConfigurationFile)}: {OverrideConfigurationFile}, {nameof(SharedMemoryDeviceOffset)}: {SharedMemoryDeviceOffset}, {nameof(DeviceIdentifier)}: {DeviceIdentifier}, {nameof(ScanRateFloorMilliseconds)}: {ScanRateFloorMilliseconds}";
}
