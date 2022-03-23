namespace Atc.Kepware.Configuration.Contracts;

public class DeviceBase : IDeviceBase
{
    /// <inheritdoc />
    public string Name { get; set; } = string.Empty;

    /// <inheritdoc />
    public string Description { get; set; } = string.Empty;

    /// <inheritdoc />
    public string Driver { get; set; } = string.Empty;

    /// <inheritdoc />
    public bool DataCollection { get; set; }

    /// <inheritdoc />
    public bool Simulated { get; set; }

    /// <inheritdoc />
    public int TagCount { get; set; }

    /// <inheritdoc />
    public DeviceScanModeType ScanMode { get; set; }

    /// <inheritdoc />
    public int ScanRate { get; set; }

    /// <inheritdoc />
    public bool InitialUpdatesFromCache { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(Driver)}: {Driver}, {nameof(DataCollection)}: {DataCollection}, {nameof(Simulated)}: {Simulated}, {nameof(TagCount)}: {TagCount}, {nameof(ScanMode)}: {ScanMode}, {nameof(ScanRate)}: {ScanRate}, {nameof(InitialUpdatesFromCache)}: {InitialUpdatesFromCache}";
}