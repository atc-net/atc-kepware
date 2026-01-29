namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AutomationDirectProductivitySeriesEthernet;

/// <summary>
/// Represents an AutomationDirect Productivity Series Ethernet device.
/// </summary>
public class AutomationDirectProductivitySeriesEthernetDevice : DeviceBase, IAutomationDirectProductivitySeriesEthernetDevice
{
    /// <inheritdoc />
    public AutomationDirectProductivitySeriesEthernetDeviceModelType Model { get; set; }

    /// <inheritdoc />
    public ModbusDeviceIdFormatType IdFormat { get; set; }

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
    public int Port { get; set; } = 502;

    /// <inheritdoc />
    public bool FirstWordHigh { get; set; } = true;

    /// <inheritdoc />
    public string? TagImportFile { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(IdFormat)}: {IdFormat}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}