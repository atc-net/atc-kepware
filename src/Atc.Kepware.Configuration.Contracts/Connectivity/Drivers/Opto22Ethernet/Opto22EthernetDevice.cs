namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.Opto22Ethernet;

public sealed class Opto22EthernetDevice : DeviceBase, IOpto22EthernetDevice
{
    /// <inheritdoc />
    public Opto22EthernetDeviceModelType Model { get; set; }

    /// <inheritdoc />
    public Opto22EthernetDeviceIdFormatType IdFormat { get; set; }

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
    public Opto22EthernetIoUnitProtocolType IoUnitProtocol { get; set; }

    /// <inheritdoc />
    public int IoUnitPortNumber { get; set; }

    /// <inheritdoc />
    public int ControlEnginePortNumber { get; set; }

    /// <inheritdoc />
    public string? ImportFile { get; set; }

    /// <inheritdoc />
    public Opto22EthernetTagGenerationOnStartupType TagGenerationOnStartup { get; set; }

    /// <inheritdoc />
    public Opto22EthernetTagGenerationDuplicateHandlingType TagGenerationDuplicateHandling { get; set; }

    /// <inheritdoc />
    public string? TagGenerationGroup { get; set; }

    /// <inheritdoc />
    public bool AllowAutomaticallyGeneratedSubgroups { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DeviceId)}: {DeviceId}, {nameof(IoUnitPortNumber)}: {IoUnitPortNumber}";
}