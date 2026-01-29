namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AutomationDirectProductivitySeriesEthernet;

/// <summary>
/// Represents an AutomationDirect Productivity Series Ethernet device creation request.
/// </summary>
public class AutomationDirectProductivitySeriesEthernetDeviceRequest : DeviceRequestBase, IAutomationDirectProductivitySeriesEthernetDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AutomationDirectProductivitySeriesEthernetDeviceRequest"/> class.
    /// </summary>
    public AutomationDirectProductivitySeriesEthernetDeviceRequest()
        : base(DriverType.AutomationDirectProductivitySeriesEthernet)
    {
    }

    /// <inheritdoc />
    public AutomationDirectProductivitySeriesEthernetDeviceModelType Model { get; set; } = AutomationDirectProductivitySeriesEthernetDeviceModelType.P3550;

    /// <inheritdoc />
    public ModbusDeviceIdFormatType IdFormat { get; set; } = ModbusDeviceIdFormatType.Octal;

    /// <inheritdoc />
    [Required]
    public string DeviceId { get; set; } = "255.255.255.255:255";

    /// <inheritdoc />
    [Range(1, 30)]
    public int ConnectTimeoutSeconds { get; set; } = 3;

    /// <inheritdoc />
    [Range(50, 9999999)]
    public int RequestTimeoutMs { get; set; } = 1000;

    /// <inheritdoc />
    [Range(1, 10)]
    public int RetryAttempts { get; set; } = 3;

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
    public int Port { get; set; } = 502;

    /// <inheritdoc />
    public bool FirstWordHigh { get; set; } = true;

    /// <inheritdoc />
    [MaxLength(1024)]
    public string? TagImportFile { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(IdFormat)}: {IdFormat}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}