namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.WonderwareIntouchClient;

/// <summary>
/// Device properties for the Wonderware InTouch Client driver.
/// </summary>
internal sealed class WonderwareIntouchClientDevice : DeviceBase, IWonderwareIntouchClientDevice
{
    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public WonderwareIntouchClientDeviceModel? Model { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("intouchclient.DEVICE_IMPORT_METHOD")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public WonderwareIntouchClientImportMethod? ImportMethod { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("intouchclient.DEVICE_INTOUCH_PROJECT_FOLDER")]
    public string? InTouchProjectFolder { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("intouchclient.DEVICE_INTOUCH_CSV_FILE")]
    public string? InTouchCsvFile { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("intouchclient.DEVICE_INCLUDE_TAG_DESCRIPTIONS")]
    public bool? IncludeTagDescriptions { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("intouchclient.DEVICE_IMPORT_SYSTEM_TAGS")]
    public bool? ImportSystemTags { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("intouchclient.DEVICE_TAG_NAMING")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public WonderwareIntouchClientTagNaming? TagNaming { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("intouchclient.DEVICE_MODE")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public WonderwareIntouchClientMode? Mode { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("intouchclient.DEVICE_MAXIMUM_ACTIVE_TIME_MS")]
    public int? MaximumActiveTimeMs { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("intouchclient.DEVICE_DELETE_INACTIVE_TAGS")]
    public bool? DeleteInactiveTags { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(ImportMethod)}: {ImportMethod}, {nameof(Mode)}: {Mode}";
}
