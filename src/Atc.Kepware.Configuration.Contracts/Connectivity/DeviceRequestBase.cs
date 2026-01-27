namespace Atc.Kepware.Configuration.Contracts.Connectivity;

public abstract class DeviceRequestBase : IDeviceRequestBase
{
    protected DeviceRequestBase(DriverType deviceDriver)
    {
        Driver = deviceDriver.GetDescription();
    }

    /// <inheritdoc />
    [KeyString]
    public string Name { get; set; } = string.Empty;

    /// <inheritdoc />
    [MaxLength(255)]
    public string Description { get; set; } = string.Empty;

    /// <inheritdoc />
    public string Driver { get; set; }

    /// <inheritdoc />
    public bool DataCollection { get; set; } = true;

    /// <inheritdoc />
    public bool Simulated { get; set; }

    /// <inheritdoc />
    public DeviceScanModeType ScanMode { get; set; } = DeviceScanModeType.RespectClientSpecifiedScanRate;

    /// <inheritdoc />
    [Range(10, 99999990)]
    public int ScanRate { get; set; } = 1000;

    /// <inheritdoc />
    public bool InitialUpdatesFromCache { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(Driver)}: {Driver}, {nameof(DataCollection)}: {DataCollection}, {nameof(Simulated)}: {Simulated}, {nameof(ScanMode)}: {ScanMode}, {nameof(ScanRate)}: {ScanRate}, {nameof(InitialUpdatesFromCache)}: {InitialUpdatesFromCache}";
}