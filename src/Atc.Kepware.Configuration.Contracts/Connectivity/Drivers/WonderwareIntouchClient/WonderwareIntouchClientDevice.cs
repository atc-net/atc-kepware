namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.WonderwareIntouchClient;

/// <summary>
/// Represents a Wonderware InTouch Client device.
/// </summary>
public class WonderwareIntouchClientDevice : DeviceBase, IWonderwareIntouchClientDevice
{
    /// <inheritdoc />
    public WonderwareIntouchClientDeviceModel? Model { get; set; }

    /// <inheritdoc />
    public WonderwareIntouchClientImportMethod? ImportMethod { get; set; }

    /// <inheritdoc />
    public string? InTouchProjectFolder { get; set; }

    /// <inheritdoc />
    public string? InTouchCsvFile { get; set; }

    /// <inheritdoc />
    public bool? IncludeTagDescriptions { get; set; }

    /// <inheritdoc />
    public bool? ImportSystemTags { get; set; }

    /// <inheritdoc />
    public WonderwareIntouchClientTagNaming? TagNaming { get; set; }

    /// <inheritdoc />
    public WonderwareIntouchClientMode? Mode { get; set; }

    /// <inheritdoc />
    public int? MaximumActiveTimeMs { get; set; }

    /// <inheritdoc />
    public bool? DeleteInactiveTags { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(ImportMethod)}: {ImportMethod}, {nameof(Mode)}: {Mode}";
}
