namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.WonderwareIntouchClient;

/// <summary>
/// Represents a Wonderware InTouch Client device creation request.
/// </summary>
public class WonderwareIntouchClientDeviceRequest : DeviceRequestBase, IWonderwareIntouchClientDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WonderwareIntouchClientDeviceRequest"/> class.
    /// </summary>
    public WonderwareIntouchClientDeviceRequest()
        : base(DriverType.WonderwareIntouchClient)
    {
    }

    /// <inheritdoc />
    public WonderwareIntouchClientDeviceModel? Model { get; set; }

    /// <inheritdoc />
    public WonderwareIntouchClientImportMethod? ImportMethod { get; set; }

    /// <inheritdoc />
    [MaxLength(260)]
    public string? InTouchProjectFolder { get; set; }

    /// <inheritdoc />
    [MaxLength(260)]
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
    [Range(0, 3600000)]
    public int? MaximumActiveTimeMs { get; set; }

    /// <inheritdoc />
    public bool? DeleteInactiveTags { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(ImportMethod)}: {ImportMethod}, {nameof(Mode)}: {Mode}";
}
