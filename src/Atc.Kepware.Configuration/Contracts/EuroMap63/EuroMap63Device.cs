namespace Atc.Kepware.Configuration.Contracts.EuroMap63;

public sealed class EuroMap63Device : DeviceBase, IEuroMap63Device
{
    public int ConnectionTimeout { get; set; }

    public int RequestTimeout { get; set; }

    public int RetryAttempts { get; set; }

    public bool DemoteOnFailure { get; set; }

    public int TimeoutToDemote { get; set; }

    public int DemotionPeriod { get; set; }

    public bool DiscardWriteRequestsWhenDemoted { get; set; }

    public EuroMap63DeviceTagGenerationOnStartupType TagGenerationOnStartup { get; set; }

    public EuroMap63DeviceTagGenerationDuplicateHandlingType TagGenerationDuplicateHandling { get; set; }

    public string? TagGenerationGroup { get; set; }

    public bool AllowAutomaticallyGeneratedSubgroups { get; set; }

    public EuroMap63DeviceTagImportSourceType DeviceTagImportSource { get; set; }

    public string TagImportFile { get; set; } = string.Empty;

    public string SessionFilePath { get; set; } = string.Empty;

    public int MinimumSessionNumber { get; set; }

    public int MaximumSessionNumber { get; set; }

    public bool PreValidateTags { get; set; }

    public int MaxFileSize { get; set; }

    public EuroMap63CharacterEncodingType CharacterEncoding { get; set; }

    public bool IncludeCyclic { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(ConnectionTimeout)}: {ConnectionTimeout}, {nameof(RequestTimeout)}: {RequestTimeout}, {nameof(RetryAttempts)}: {RetryAttempts}, {nameof(DemoteOnFailure)}: {DemoteOnFailure}, {nameof(TimeoutToDemote)}: {TimeoutToDemote}, {nameof(DemotionPeriod)}: {DemotionPeriod}, {nameof(DiscardWriteRequestsWhenDemoted)}: {DiscardWriteRequestsWhenDemoted}, {nameof(TagGenerationOnStartup)}: {TagGenerationOnStartup}, {nameof(TagGenerationDuplicateHandling)}: {TagGenerationDuplicateHandling}, {nameof(TagGenerationGroup)}: {TagGenerationGroup}, {nameof(AllowAutomaticallyGeneratedSubgroups)}: {AllowAutomaticallyGeneratedSubgroups}, {nameof(DeviceTagImportSource)}: {DeviceTagImportSource}, {nameof(TagImportFile)}: {TagImportFile}, {nameof(SessionFilePath)}: {SessionFilePath}, {nameof(MinimumSessionNumber)}: {MinimumSessionNumber}, {nameof(MaximumSessionNumber)}: {MaximumSessionNumber}, {nameof(PreValidateTags)}: {PreValidateTags}, {nameof(MaxFileSize)}: {MaxFileSize}, {nameof(CharacterEncoding)}: {CharacterEncoding}, {nameof(IncludeCyclic)}: {IncludeCyclic}";
}