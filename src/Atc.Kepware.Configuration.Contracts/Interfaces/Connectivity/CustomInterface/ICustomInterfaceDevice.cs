namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.CustomInterface;

public interface ICustomInterfaceDevice : IDeviceBase
{
    /// <summary>
    /// Indicates if the configuration file settings should be overridden.
    /// </summary>
    bool OverrideConfigurationFile { get; set; }

    /// <summary>
    /// The shared memory file byte offset that defines the logical beginning of data for this device.
    /// </summary>
    int SharedMemoryDeviceOffset { get; set; }

    /// <summary>
    /// The identity label of the device.
    /// </summary>
    string? DeviceIdentifier { get; set; }

    /// <summary>
    /// The minimum scan rate for this device in milliseconds.
    /// </summary>
    int ScanRateFloorMilliseconds { get; set; }
}
