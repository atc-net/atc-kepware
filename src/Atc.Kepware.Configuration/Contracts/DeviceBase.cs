namespace Atc.Kepware.Configuration.Contracts;

public class DeviceBase
{
    /// <summary>
    /// Specify the identity of this object.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Provide a brief summary of this object or its use.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    public string Driver { get; set; } = string.Empty;

    /// <summary>
    /// Select whether or not communication with the physical device is active (enabled) or turned off (disabled).
    /// When disabled, data is marked invalid and write operations are not accepted.
    /// </summary>
    public bool DataCollection { get; set; }

    /// <summary>
    /// Use generic valid OPC data without communicating with the physical device.
    /// </summary>
    public bool Simulated { get; set; }

    /// <summary>
    /// The total number of user defined tags assigned to the device.
    /// </summary>
    public int TagCount { get; set; }

    /// <summary>
    /// Specify the method for determining how often tags in the device are scanned.
    /// </summary>
    public DeviceScanModeType ScanMode { get; set; }

    /// <summary>
    /// Indicate the frequency of scanning in milliseconds.
    /// When the Scan Mode is Request data no faster than Scan Rate, this is the maximum rate.
    /// When the Scan Mode is Request all data at Scan Rate, all tags are scanned at this rate.
    /// </summary>
    /// <remarks>
    /// Property is only applicable when <see cref="DeviceScanModeType"/> is <see cref="DeviceScanModeType.RequestDataNoFasterThanScanRate"/> or <see cref="DeviceScanModeType.RequestAllDataAtScanRate"/>.
    /// </remarks>
    public int ScanRate { get; set; }

    /// <summary>
    /// Provide the first updates for new tag references from stored (cached) data
    /// rather than polling devices immediately.
    /// </summary>
    public bool InitialUpdatesFromCache { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(Driver)}: {Driver}, {nameof(DataCollection)}: {DataCollection}, {nameof(Simulated)}: {Simulated}, {nameof(TagCount)}: {TagCount}, {nameof(ScanMode)}: {ScanMode}, {nameof(ScanRate)}: {ScanRate}, {nameof(InitialUpdatesFromCache)}: {InitialUpdatesFromCache}";
}