namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.HoneywellHc900Ethernet;

public sealed class HoneywellHc900EthernetDevice : DeviceBase, IHoneywellHc900EthernetDevice
{
    /// <inheritdoc />
    public HoneywellHc900EthernetDeviceModelType Model { get; set; }

    /// <inheritdoc />
    public HoneywellHc900EthernetDeviceIdFormatType IdFormat { get; set; }

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
    public int Port { get; set; }

    /// <inheritdoc />
    public bool FirstWordLow { get; set; }

    /// <inheritdoc />
    public int OutputCoils { get; set; }

    /// <inheritdoc />
    public int InputCoils { get; set; }

    /// <inheritdoc />
    public int InternalRegisters { get; set; }

    /// <inheritdoc />
    public int HoldingRegisters { get; set; }

    /// <inheritdoc />
    public int NumberOfLoops { get; set; }

    /// <inheritdoc />
    public int NumberOfVariables { get; set; }

    /// <inheritdoc />
    public int NumberOfSignalTags { get; set; }

    /// <inheritdoc />
    public int NumberOfSpProgrammers { get; set; }

    /// <inheritdoc />
    public int Segments1 { get; set; }

    /// <inheritdoc />
    public int Segments2 { get; set; }

    /// <inheritdoc />
    public int Segments3 { get; set; }

    /// <inheritdoc />
    public int Segments4 { get; set; }

    /// <inheritdoc />
    public int Segments5 { get; set; }

    /// <inheritdoc />
    public int Segments6 { get; set; }

    /// <inheritdoc />
    public int Segments7 { get; set; }

    /// <inheritdoc />
    public int Segments8 { get; set; }

    /// <inheritdoc />
    public string? TagImportFiles { get; set; }

    /// <inheritdoc />
    public bool DisplayDescriptions { get; set; }

    /// <inheritdoc />
    public HoneywellHc900EthernetDeviceTagNamingType TagNaming { get; set; }

    /// <inheritdoc />
    public bool TagGenerationOnPropertyChange { get; set; }

    /// <inheritdoc />
    public DeviceTagGenerationOnStartupType TagGenerationOnStartup { get; set; }

    /// <inheritdoc />
    public DeviceTagGenerationDuplicateHandlingType TagGenerationDuplicateHandling { get; set; }

    /// <inheritdoc />
    public string? TagGenerationGroup { get; set; }

    /// <inheritdoc />
    public bool AllowAutomaticallyGeneratedSubgroups { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(IdFormat)}: {IdFormat}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}
