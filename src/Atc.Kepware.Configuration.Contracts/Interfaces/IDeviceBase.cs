namespace Atc.Kepware.Configuration.Contracts.Interfaces;

public interface IDeviceBase
{
    /// <summary>
    /// Name of the device.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// Description of the device.
    /// </summary>
    string Description { get; set; }

    string Driver { get; set; }

    /// <summary>
    /// Select whether or not communication with the physical device is active (enabled) or turned off (disabled).
    /// When disabled, data is marked invalid and write operations are not accepted.
    /// </summary>
    bool DataCollection { get; set; }

    /// <summary>
    /// Use generic valid OPC data without communicating with the physical device.
    /// </summary>
    bool Simulated { get; set; }

    /// <summary>
    /// The total number of user defined tags assigned to the device.
    /// </summary>
    int TagCount { get; set; }

    /// <summary>
    /// Specify the method for determining how often tags in the device are scanned.
    /// </summary>
    DeviceScanModeType ScanMode { get; set; }

    /// <summary>
    /// Indicate the frequency of scanning in milliseconds.
    /// When the Scan Mode is Request data no faster than Scan Rate, this is the maximum rate.
    /// When the Scan Mode is Request all data at Scan Rate, all tags are scanned at this rate.
    /// </summary>
    /// <remarks>
    /// Property is only applicable when <see cref="DeviceScanModeType"/> is <see cref="DeviceScanModeType.RequestDataNoFasterThanScanRate"/> or <see cref="DeviceScanModeType.RequestAllDataAtScanRate"/>.
    /// </remarks>
    int ScanRate { get; set; }

    /// <summary>
    /// Provide the first updates for new tag references from stored (cached) data
    /// rather than polling devices immediately.
    /// </summary>
    bool InitialUpdatesFromCache { get; set; }
}