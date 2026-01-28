namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.BeckhoffTwinCat;

/// <summary>
/// Device properties for the Beckhoff TwinCAT driver.
/// </summary>
public sealed class BeckhoffTwinCatDevice : DeviceBase, IBeckhoffTwinCatDevice
{
    /// <inheritdoc />
    public BeckhoffTwinCatModel Model { get; set; }

    /// <inheritdoc />
    public BeckhoffTwinCatIdFormat IdFormat { get; set; }

    /// <inheritdoc />
    public string DeviceId { get; set; } = string.Empty;

    /// <inheritdoc />
    public int ConnectTimeoutSeconds { get; set; }

    /// <inheritdoc />
    public int RequestTimeoutMs { get; set; }

    /// <inheritdoc />
    public int RetryAttempts { get; set; }

    /// <inheritdoc />
    public bool DemoteOnFailure { get; set; }

    /// <inheritdoc />
    public int TimeoutsToDemote { get; set; }

    /// <inheritdoc />
    public int DemotionPeriodMs { get; set; }

    /// <inheritdoc />
    public bool DiscardRequestsWhenDemoted { get; set; }

    /// <inheritdoc />
    public DeviceTagGenerationOnStartupType TagGenerationOnStartup { get; set; }

    /// <inheritdoc />
    public DeviceTagGenerationDuplicateHandlingType TagGenerationDuplicateHandling { get; set; }

    /// <inheritdoc />
    public string? TagGenerationGroup { get; set; }

    /// <inheritdoc />
    public bool AllowAutomaticallyGeneratedSubgroups { get; set; }

    /// <inheritdoc />
    public int PortNumber { get; set; }

    /// <inheritdoc />
    public BeckhoffTwinCatDefaultType DefaultType { get; set; }

    /// <inheritdoc />
    public BeckhoffTwinCatImportSource ImportSource { get; set; }

    /// <inheritdoc />
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
    public string? AdditionalFilter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(IdFormat)}: {IdFormat}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}, {nameof(DefaultType)}: {DefaultType}";
}
