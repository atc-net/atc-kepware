namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.CustomInterface;

public sealed class CustomInterfaceDevice : DeviceBase, ICustomInterfaceDevice
{
    /// <inheritdoc />
    public bool OverrideConfigurationFile { get; set; }

    /// <inheritdoc />
    public int SharedMemoryDeviceOffset { get; set; }

    /// <inheritdoc />
    public string? DeviceIdentifier { get; set; }

    /// <inheritdoc />
    public int ScanRateFloorMilliseconds { get; set; } = 250;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(OverrideConfigurationFile)}: {OverrideConfigurationFile}, {nameof(SharedMemoryDeviceOffset)}: {SharedMemoryDeviceOffset}, {nameof(DeviceIdentifier)}: {DeviceIdentifier}, {nameof(ScanRateFloorMilliseconds)}: {ScanRateFloorMilliseconds}";
}