namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.CustomInterface;

/// <summary>
/// Device properties for the Custom Interface driver.
/// </summary>
public sealed class CustomInterfaceDeviceRequest : DeviceRequestBase, ICustomInterfaceDeviceRequest
{
    public CustomInterfaceDeviceRequest()
        : base(DriverType.CustomInterface)
    {
    }

    /// <inheritdoc />
    public bool OverrideConfigurationFile { get; set; } = true;

    /// <inheritdoc />
    [Range(0, 2147483647)]
    public int SharedMemoryDeviceOffset { get; set; }

    /// <inheritdoc />
    [MaxLength(256)]
    public string? DeviceIdentifier { get; set; }

    /// <inheritdoc />
    [Range(100, 60000)]
    public int ScanRateFloorMilliseconds { get; set; } = 250;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(OverrideConfigurationFile)}: {OverrideConfigurationFile}, {nameof(SharedMemoryDeviceOffset)}: {SharedMemoryDeviceOffset}, {nameof(DeviceIdentifier)}: {DeviceIdentifier}, {nameof(ScanRateFloorMilliseconds)}: {ScanRateFloorMilliseconds}";
}