namespace Atc.Kepware.Configuration.Interfaces;

public interface IDeviceRequestBase
{
    /// <summary>
    /// Specifies the identity of this object.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// Summary of this object or its use.
    /// </summary>
    string Description { get; set; }

    string Driver { get; }

    /// <summary>
    /// Indicates whether or not communication with the physical device is active (enabled) or turned off (disabled).
    /// When disabled, data is marked invalid and write operations are not accepted.
    /// </summary>
    bool DataCollection { get; set; }

    /// <summary>
    /// Use generic valid OPC data without communicating with the physical device.
    /// </summary>
    bool Simulated { get; set; }

    /// <summary>
    /// Specifies the method for determining how often tags in the device are scanned.
    /// </summary>
    DeviceScanModeType ScanMode { get; set; }

    /// <summary>
    /// Indicates the frequency of scanning in milliseconds.
    /// When the Scan Mode is Request data no faster than Scan Rate, this is the maximum rate.
    /// When the Scan Mode is Request all data at Scan Rate, all tags are scanned at this rate.
    /// </summary>
    /// <remarks>
    /// Property is only applicable when <see cref="DeviceScanModeType"/> is <see cref="DeviceScanModeType.RequestDataNoFasterThanScanRate"/> or <see cref="DeviceScanModeType.RequestAllDataAtScanRate"/>.
    /// </remarks>
    int ScanRate { get; set; }

    /// <summary>
    /// Determines if the first updates for new tag references should be returned from stored (cached) data
    /// rather than polling devices immediately.
    /// </summary>
    bool InitialUpdatesFromCache { get; set; }
}