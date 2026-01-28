namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.BeckhoffTwinCat;

/// <summary>
/// Device request properties for the Beckhoff TwinCAT driver.
/// </summary>
internal sealed class BeckhoffTwinCatDeviceRequest : DeviceRequestBase, IBeckhoffTwinCatDeviceRequest
{
    public BeckhoffTwinCatDeviceRequest()
        : base(DriverType.BeckhoffTwinCat)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public BeckhoffTwinCatModel Model { get; set; } = BeckhoffTwinCatModel.TwinCatPlc;

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_ID_FORMAT")]
    public BeckhoffTwinCatIdFormat IdFormat { get; set; } = BeckhoffTwinCatIdFormat.Decimal;

    /// <inheritdoc />
    [Required]
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = string.Empty;

    /// <inheritdoc />
    [Range(1, 30)]
    [JsonPropertyName("servermain.DEVICE_CONNECTION_TIMEOUT_SECONDS")]
    public int ConnectTimeoutSeconds { get; set; } = 3;

    /// <inheritdoc />
    [Range(50, 9999999)]
    [JsonPropertyName("servermain.DEVICE_REQUEST_TIMEOUT_MILLISECONDS")]
    public int RequestTimeoutMs { get; set; } = 2000;

    /// <inheritdoc />
    [Range(1, 10)]
    [JsonPropertyName("servermain.DEVICE_RETRY_ATTEMPTS")]
    public int RetryAttempts { get; set; } = 2;

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_ENABLE_ON_COMMUNICATIONS_FAILURES")]
    public bool DemoteOnFailure { get; set; }

    /// <inheritdoc />
    [Range(1, 30)]
    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DEMOTE_AFTER_SUCCESSIVE_TIMEOUTS")]
    public int TimeoutsToDemote { get; set; } = 3;

    /// <inheritdoc />
    [Range(100, 3600000)]
    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_PERIOD_MS")]
    public int DemotionPeriodMs { get; set; } = 10000;

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DISCARD_WRITES")]
    public bool DiscardRequestsWhenDemoted { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_ON_STARTUP")]
    public DeviceTagGenerationOnStartupType TagGenerationOnStartup { get; set; } = DeviceTagGenerationOnStartupType.DoNotGenerateOnStartup;

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_DUPLICATE_HANDLING")]
    public DeviceTagGenerationDuplicateHandlingType TagGenerationDuplicateHandling { get; set; } = DeviceTagGenerationDuplicateHandlingType.DeleteOnCreate;

    /// <inheritdoc />
    [MaxLength(256)]
    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_GROUP")]
    public string? TagGenerationGroup { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_ALLOW_SUB_GROUPS")]
    public bool AllowAutomaticallyGeneratedSubgroups { get; set; } = true;

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("beckhoff_twincat.DEVICE_PORT_NUMBER")]
    public int PortNumber { get; set; } = 801;

    /// <inheritdoc />
    [JsonPropertyName("beckhoff_twincat.DEVICE_DEFAULT_TYPE")]
    public BeckhoffTwinCatDefaultType DefaultType { get; set; } = BeckhoffTwinCatDefaultType.Word;

    /// <inheritdoc />
    [JsonPropertyName("beckhoff_twincat.DEVICE_IMPORT_SOURCE")]
    public BeckhoffTwinCatImportSource ImportSource { get; set; } = BeckhoffTwinCatImportSource.Device;

    /// <inheritdoc />
    [MaxLength(1024)]
    [JsonPropertyName("beckhoff_twincat.DEVICE_SYMBOL_FILE")]
    public string? SymbolFile { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("beckhoff_twincat.DEVICE_AUTO_SYNCHRONIZE_WITH_SYMBOL_FILE_CHANGES")]
    public bool AutoSynchronizeFileChanges { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("beckhoff_twincat.DEVICE_RESPECT_OPC_READ_WRITE_ITEM_PROPERTIES")]
    public bool RespectOpcReadWriteItemProperties { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("beckhoff_twincat.DEVICE_RESPECT_TAG_CASE_ON_IMPORT")]
    public bool RespectTagCaseOnImport { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("beckhoff_twincat.DEVICE_ONLY_IMPORT_VARIABLE_MARKED_FOR_OPC")]
    public bool OnlyImportVariablesMarkedForOpc { get; set; }

    /// <inheritdoc />
    [MaxLength(1024)]
    [JsonPropertyName("beckhoff_twincat.DEVICE_ADDITIONAL_OPC_FILTER")]
    public string? AdditionalFilter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(IdFormat)}: {IdFormat}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}, {nameof(DefaultType)}: {DefaultType}";
}
