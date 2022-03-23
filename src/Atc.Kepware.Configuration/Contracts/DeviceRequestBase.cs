namespace Atc.Kepware.Configuration.Contracts;

public abstract class DeviceRequestBase
{
    protected DeviceRequestBase(
        DriverType deviceDriver)
    {
        Driver = deviceDriver.GetDescription();
    }

    /// <summary>
    /// Specifies the identity of this object.
    /// </summary>
    [MinLength(1)]
    [MaxLength(256)]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Summary of this object or its use.
    /// </summary>
    [MaxLength(255)]
    public string Description { get; set; } = string.Empty;

    public string Driver { get; private init; }

    /// <summary>
    /// Indicates whether or not communication with the physical device is active (enabled) or turned off (disabled).
    /// When disabled, data is marked invalid and write operations are not accepted.
    /// </summary>
    public bool DataCollection { get; set; } = true;

    /// <summary>
    /// Use generic valid OPC data without communicating with the physical device.
    /// </summary>
    public bool Simulated { get; set; }

    /// <summary>
    /// Specifies the method for determining how often tags in the device are scanned.
    /// </summary>
    public DeviceScanModeType ScanMode { get; set; } = DeviceScanModeType.RespectClientSpecifiedScanRate;

    /// <summary>
    /// Indicates the frequency of scanning in milliseconds.
    /// When the Scan Mode is Request data no faster than Scan Rate, this is the maximum rate.
    /// When the Scan Mode is Request all data at Scan Rate, all tags are scanned at this rate.
    /// </summary>
    /// <remarks>
    /// Property is only applicable when <see cref="DeviceScanModeType"/> is <see cref="DeviceScanModeType.RequestDataNoFasterThanScanRate"/> or <see cref="DeviceScanModeType.RequestAllDataAtScanRate"/>.
    /// </remarks>
    [Range(10, 99999990)]
    public int ScanRate { get; set; } = 1000;

    /// <summary>
    /// Determines if the first updates for new tag references should be returned from stored (cached) data
    /// rather than polling devices immediately.
    /// </summary>
    public bool InitialUpdatesFromCache { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(Driver)}: {Driver}, {nameof(DataCollection)}: {DataCollection}, {nameof(Simulated)}: {Simulated}, {nameof(ScanMode)}: {ScanMode}, {nameof(ScanRate)}: {ScanRate}, {nameof(InitialUpdatesFromCache)}: {InitialUpdatesFromCache}";
}