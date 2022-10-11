namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.EuroMap63;

public interface IEuroMap63Device : IDeviceBase
{
    int ConnectionTimeout { get; set; }

    int RequestTimeout { get; set; }

    int RetryAttempts { get; set; }

    bool DemoteOnFailure { get; set; }

    int TimeoutToDemote { get; set; }

    int DemotionPeriod { get; set; }

    bool DiscardWriteRequestsWhenDemoted { get; set; }

    EuroMap63DeviceTagGenerationOnStartupType TagGenerationOnStartup { get; set; }

    EuroMap63DeviceTagGenerationDuplicateHandlingType TagGenerationDuplicateHandling { get; set; }

    string? TagGenerationGroup { get; set; }

    bool AllowAutomaticallyGeneratedSubgroups { get; set; }

    EuroMap63DeviceTagImportSourceType DeviceTagImportSource { get; set; }

    string TagImportFile { get; set; }

    string SessionFilePath { get; set; }

    int MinimumSessionNumber { get; set; }

    int MaximumSessionNumber { get; set; }

    bool PreValidateTags { get; set; }

    int MaxFileSize { get; set; }

    EuroMap63CharacterEncodingType CharacterEncoding { get; set; }

    bool IncludeCyclic { get; set; }
}