namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.CustomInterface;

/// <summary>
/// Device properties for the Custom Interface driver.
/// </summary>
public interface ICustomInterfaceDeviceRequest
{
    /// <summary>
    /// Specify if the configuration name and shared memory size as defined by the configuration file should be overwritten.
    /// </summary>
    bool OverrideConfigurationFile { get; set; }

    /// <summary>
    /// Specify the shared memory file byte offset that defines the logical beginning of data for this device.
    /// All register offsets for this device will be relative to this device offset.
    /// </summary>
    /// <remarks>
    /// Only enabled when OverrideConfigurationFile is true.
    /// </remarks>
    int SharedMemoryDeviceOffset { get; set; }

    /// <summary>
    /// Specify the identity label of the device.
    /// </summary>
    /// <remarks>
    /// Only enabled when OverrideConfigurationFile is true.
    /// </remarks>
    string? DeviceIdentifier { get; set; }

    /// <summary>
    /// Specify the minimum scan rate for this device.
    /// Any client scan rate faster than the Scan Rate Floor setting will be capped at the Scan Rate Floor setting.
    /// </summary>
    int ScanRateFloorMilliseconds { get; set; }
}