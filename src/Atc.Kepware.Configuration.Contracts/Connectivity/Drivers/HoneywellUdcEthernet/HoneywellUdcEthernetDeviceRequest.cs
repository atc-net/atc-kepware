namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.HoneywellUdcEthernet;

/// <summary>
/// Device request properties for the Honeywell UDC Ethernet driver.
/// </summary>
public sealed class HoneywellUdcEthernetDeviceRequest : DeviceRequestBase, IHoneywellUdcEthernetDeviceRequest
{
    public HoneywellUdcEthernetDeviceRequest()
        : base(DriverType.HoneywellUdcEthernet)
    {
    }

    /// <inheritdoc />
    public HoneywellUdcEthernetDeviceModelType Model { get; set; } = HoneywellUdcEthernetDeviceModelType.UDC2500;

    /// <inheritdoc />
    public HoneywellUdcEthernetDeviceIdFormatType IdFormat { get; set; } = HoneywellUdcEthernetDeviceIdFormatType.Octal;

    /// <inheritdoc />
    [Required]
    public string DeviceId { get; set; } = string.Empty;

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
    [Range(0, 30000)]
    public int InterRequestDelayMs { get; set; } = 50;

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
    public bool FirstWordLow { get; set; }

    /// <inheritdoc />
    [Range(1, 22)]
    public int InternalRegisters { get; set; } = 22;

    /// <inheritdoc />
    [Range(1, 22)]
    public int HoldingRegisters { get; set; } = 22;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(IdFormat)}: {IdFormat}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}
