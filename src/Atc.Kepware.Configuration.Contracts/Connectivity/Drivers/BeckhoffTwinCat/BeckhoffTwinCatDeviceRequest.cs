namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.BeckhoffTwinCat;

/// <summary>
/// Device request properties for the Beckhoff TwinCAT driver.
/// </summary>
public sealed class BeckhoffTwinCatDeviceRequest : DeviceRequestBase, IBeckhoffTwinCatDeviceRequest
{
    public BeckhoffTwinCatDeviceRequest()
        : base(DriverType.BeckhoffTwinCat)
    {
    }

    /// <inheritdoc />
    public BeckhoffTwinCatModel Model { get; set; } = BeckhoffTwinCatModel.TwinCatPlc;

    /// <inheritdoc />
    public BeckhoffTwinCatIdFormat IdFormat { get; set; } = BeckhoffTwinCatIdFormat.Octal;

    /// <inheritdoc />
    [Required]
    public string DeviceId { get; set; } = string.Empty;

    /// <inheritdoc />
    [Range(1, 30)]
    public int ConnectTimeoutSeconds { get; set; } = 3;

    /// <inheritdoc />
    [Range(50, 9999999)]
    public int RequestTimeoutMs { get; set; } = 2000;

    /// <inheritdoc />
    [Range(1, 10)]
    public int RetryAttempts { get; set; } = 2;

    /// <inheritdoc />
    public bool DemoteOnFailure { get; set; }

    /// <inheritdoc />
    [Range(1, 30)]
    public int TimeoutsToDemote { get; set; } = 3;

    /// <inheritdoc />
    [Range(100, 3600000)]
    public int DemotionPeriodMs { get; set; } = 10000;

    /// <inheritdoc />
    public bool DiscardRequestsWhenDemoted { get; set; }

    /// <inheritdoc />
    public DeviceTagGenerationOnStartupType TagGenerationOnStartup { get; set; } = DeviceTagGenerationOnStartupType.DoNotGenerateOnStartup;

    /// <inheritdoc />
    public DeviceTagGenerationDuplicateHandlingType TagGenerationDuplicateHandling { get; set; } = DeviceTagGenerationDuplicateHandlingType.DeleteOnCreate;

    /// <inheritdoc />
    [MaxLength(256)]
    public string? TagGenerationGroup { get; set; }

    /// <inheritdoc />
    public bool AllowAutomaticallyGeneratedSubgroups { get; set; } = true;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int PortNumber { get; set; } = 801;

    /// <inheritdoc />
    public BeckhoffTwinCatDefaultType DefaultType { get; set; } = BeckhoffTwinCatDefaultType.Word;

    /// <inheritdoc />
    public BeckhoffTwinCatImportSource ImportSource { get; set; } = BeckhoffTwinCatImportSource.Device;

    /// <inheritdoc />
    [MaxLength(1024)]
    public string? SymbolFile { get; set; }

    /// <inheritdoc />
    public bool AutoSynchronizeFileChanges { get; set; }

    /// <inheritdoc />
    public bool RespectOpcReadWriteItemProperties { get; set; }

    /// <inheritdoc />
    public bool RespectTagCaseOnImport { get; set; }

    /// <inheritdoc />
    public bool OnlyImportVariablesMarkedForOpc { get; set; }

    /// <inheritdoc />
    [MaxLength(1024)]
    public string? AdditionalFilter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(IdFormat)}: {IdFormat}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}, {nameof(DefaultType)}: {DefaultType}";
}
