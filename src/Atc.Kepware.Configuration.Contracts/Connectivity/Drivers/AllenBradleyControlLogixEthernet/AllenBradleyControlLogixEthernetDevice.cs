namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AllenBradleyControlLogixEthernet;

public sealed class AllenBradleyControlLogixEthernetDevice : DeviceBase, IAllenBradleyControlLogixEthernetDevice
{
    /// <inheritdoc />
    public ControlLogixDeviceModelType Model { get; set; }

    /// <inheritdoc />
    public string DeviceId { get; set; } = string.Empty;

    /// <inheritdoc />
    public int ConnectTimeoutSeconds { get; set; }

    /// <inheritdoc />
    public int RequestTimeoutMs { get; set; }

    /// <inheritdoc />
    public int RetryAttempts { get; set; }

    /// <inheritdoc />
    public int InterRequestDelayMs { get; set; }

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
    public int Port { get; set; }

    /// <inheritdoc />
    public int ConnectionSizeBytes { get; set; }

    /// <inheritdoc />
    public ControlLogixInactivityWatchdogType InactivityWatchdog { get; set; }

    /// <inheritdoc />
    public ControlLogixArrayBlockSizeType ArrayBlockSize { get; set; }

    /// <inheritdoc />
    public ControlLogixProtocolModeType ProtocolMode { get; set; }

    /// <inheritdoc />
    public bool SynchronizeAfterOnlineEdits { get; set; }

    /// <inheritdoc />
    public bool SynchronizeAfterOfflineEdits { get; set; }

    /// <inheritdoc />
    public bool TerminateStringDataAtLen { get; set; }

    /// <inheritdoc />
    public ControlLogixDefaultDataType DefaultDataType { get; set; }

    /// <inheritdoc />
    public bool PerformanceStatistics { get; set; }

    /// <inheritdoc />
    public ControlLogixDatabaseImportMethodType DatabaseImportMethod { get; set; }

    /// <inheritdoc />
    public string? TagImportFile { get; set; }

    /// <inheritdoc />
    public bool TagDescriptions { get; set; }

    /// <inheritdoc />
    public bool LimitNameLength { get; set; }

    /// <inheritdoc />
    public ControlLogixTagHierarchyType TagHierarchy { get; set; }

    /// <inheritdoc />
    public bool ImposeArrayLimit { get; set; }

    /// <inheritdoc />
    public int ArrayCountUpperLimit { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}
