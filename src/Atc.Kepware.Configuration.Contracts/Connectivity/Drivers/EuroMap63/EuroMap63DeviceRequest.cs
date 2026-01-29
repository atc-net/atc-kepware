namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.EuroMap63;

public sealed class EuroMap63DeviceRequest : DeviceRequestBase, IEuroMap63DeviceRequest
{
    public EuroMap63DeviceRequest()
        : base(DriverType.EuroMap63)
    {
    }

    /// <inheritdoc />
    [Range(1, 30)]
    public int ConnectionTimeout { get; set; } = 3;

    /// <inheritdoc />
    [Range(1000, 9000000)]
    public int RequestTimeout { get; set; } = 60000;

    /// <inheritdoc />
    [Range(1, 10)]
    public int RetryAttempts { get; set; } = 1;

    /// <inheritdoc />
    public bool DemoteOnFailure { get; set; }

    /// <inheritdoc />
    [Range(1, 30)]
    public int TimeoutToDemote { get; set; } = 3;

    /// <inheritdoc />
    [Range(100, 3600000)]
    public int DemotionPeriod { get; set; } = 10000;

    /// <inheritdoc />
    public bool DiscardWriteRequestsWhenDemoted { get; set; }

    /// <inheritdoc />
    public EuroMap63DeviceTagGenerationOnStartupType TagGenerationOnStartup { get; set; } = EuroMap63DeviceTagGenerationOnStartupType.DoNotGenerateOnStartup;

    /// <inheritdoc />
    public EuroMap63DeviceTagGenerationDuplicateHandlingType TagGenerationDuplicateHandling { get; set; } = EuroMap63DeviceTagGenerationDuplicateHandlingType.DeleteOnCreate;

    /// <inheritdoc />
    [MaxLength(256)]
    public string? TagGenerationGroup { get; set; }

    /// <inheritdoc />
    public bool AllowAutomaticallyGeneratedSubgroups { get; set; } = true;

    /// <inheritdoc />
    public EuroMap63DeviceTagImportSourceType DeviceTagImportSource { get; set; } = EuroMap63DeviceTagImportSourceType.Device;

    /// <inheritdoc />
    public string TagImportFile { get; set; } = "*.dat";

    /// <inheritdoc />
    public string SessionFilePath { get; set; } = string.Empty;

    /// <inheritdoc />
    [Range(0, 9999)]
    public int MinimumSessionNumber { get; set; }

    /// <inheritdoc />
    [Range(0, 9999)]
    public int MaximumSessionNumber { get; set; } = 10;

    /// <inheritdoc />
    public bool PreValidateTags { get; set; } = true;

    /// <inheritdoc />
    [Range(50, 65535)]
    public int MaxFileSize { get; set; } = 2000;

    /// <inheritdoc />
    public EuroMap63CharacterEncodingType CharacterEncoding { get; set; } = EuroMap63CharacterEncodingType.Ansi;

    /// <inheritdoc />
    public bool IncludeCyclic { get; set; } = true;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(ConnectionTimeout)}: {ConnectionTimeout}, {nameof(RequestTimeout)}: {RequestTimeout}, {nameof(RetryAttempts)}: {RetryAttempts}, {nameof(DemoteOnFailure)}: {DemoteOnFailure}, {nameof(TimeoutToDemote)}: {TimeoutToDemote}, {nameof(DemotionPeriod)}: {DemotionPeriod}, {nameof(DiscardWriteRequestsWhenDemoted)}: {DiscardWriteRequestsWhenDemoted}, {nameof(TagGenerationOnStartup)}: {TagGenerationOnStartup}, {nameof(TagGenerationDuplicateHandling)}: {TagGenerationDuplicateHandling}, {nameof(TagGenerationGroup)}: {TagGenerationGroup}, {nameof(AllowAutomaticallyGeneratedSubgroups)}: {AllowAutomaticallyGeneratedSubgroups}, {nameof(DeviceTagImportSource)}: {DeviceTagImportSource}, {nameof(TagImportFile)}: {TagImportFile}, {nameof(SessionFilePath)}: {SessionFilePath}, {nameof(MinimumSessionNumber)}: {MinimumSessionNumber}, {nameof(MaximumSessionNumber)}: {MaximumSessionNumber}, {nameof(PreValidateTags)}: {PreValidateTags}, {nameof(MaxFileSize)}: {MaxFileSize}, {nameof(CharacterEncoding)}: {CharacterEncoding}, {nameof(IncludeCyclic)}: {IncludeCyclic}";
}