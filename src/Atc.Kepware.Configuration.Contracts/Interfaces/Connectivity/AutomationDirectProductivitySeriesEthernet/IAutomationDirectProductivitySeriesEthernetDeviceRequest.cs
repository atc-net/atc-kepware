namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.AutomationDirectProductivitySeriesEthernet;

/// <summary>
/// Defines the AutomationDirect Productivity Series Ethernet device request properties.
/// </summary>
public interface IAutomationDirectProductivitySeriesEthernetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the device model type.
    /// </summary>
    AutomationDirectProductivitySeriesEthernetDeviceModelType Model { get; set; }

    /// <summary>
    /// Gets or sets the device ID format (Octal, Decimal, or Hex).
    /// </summary>
    ModbusDeviceIdFormatType IdFormat { get; set; }

    /// <summary>
    /// Gets or sets the device ID.
    /// Format: IP_Address:UnitID (e.g., "192.168.1.1:1").
    /// </summary>
    string DeviceId { get; set; }

    /// <summary>
    /// Gets or sets the connection timeout in seconds.
    /// </summary>
    int ConnectTimeoutSeconds { get; set; }

    /// <summary>
    /// Gets or sets the request timeout in milliseconds.
    /// </summary>
    int RequestTimeoutMs { get; set; }

    /// <summary>
    /// Gets or sets the number of retry attempts before timeout.
    /// </summary>
    int RetryAttempts { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to demote the device on communication failure.
    /// </summary>
    bool DemoteOnFailure { get; set; }

    /// <summary>
    /// Gets or sets the number of timeouts before demotion.
    /// </summary>
    int TimeoutsToDemote { get; set; }

    /// <summary>
    /// Gets or sets the demotion period in milliseconds.
    /// </summary>
    int DemotionPeriodMs { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to discard requests when demoted.
    /// </summary>
    bool DiscardRequestsWhenDemoted { get; set; }

    /// <summary>
    /// Gets or sets the tag generation behavior on startup.
    /// </summary>
    DeviceTagGenerationOnStartupType TagGenerationOnStartup { get; set; }

    /// <summary>
    /// Gets or sets the duplicate tag handling behavior.
    /// </summary>
    DeviceTagGenerationDuplicateHandlingType TagGenerationDuplicateHandling { get; set; }

    /// <summary>
    /// Gets or sets the parent group for generated tags.
    /// </summary>
    string? TagGenerationGroup { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to allow automatically generated subgroups.
    /// </summary>
    bool AllowAutomaticallyGeneratedSubgroups { get; set; }

    /// <summary>
    /// Gets or sets the port number for device communication.
    /// </summary>
    int Port { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the first word is high in 32-bit values.
    /// </summary>
    bool FirstWordHigh { get; set; }

    /// <summary>
    /// Gets or sets the tag import file path.
    /// </summary>
    string? TagImportFile { get; set; }
}
