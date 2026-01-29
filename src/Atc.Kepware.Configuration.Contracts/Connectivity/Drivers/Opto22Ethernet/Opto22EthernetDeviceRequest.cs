namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.Opto22Ethernet;

/// <summary>
/// Device properties for the Opto 22 Ethernet driver.
/// </summary>
public sealed class Opto22EthernetDeviceRequest : DeviceRequestBase, IOpto22EthernetDeviceRequest
{
    public Opto22EthernetDeviceRequest()
        : base(DriverType.Opto22Ethernet)
    {
    }

    /// <inheritdoc />
    public Opto22EthernetDeviceModelType Model { get; set; } = Opto22EthernetDeviceModelType.Opto22;

    /// <inheritdoc />
    public Opto22EthernetDeviceIdFormatType IdFormat { get; set; } = Opto22EthernetDeviceIdFormatType.Octal;

    /// <inheritdoc />
    [Required]
    public string DeviceId { get; set; } = "255.255.255.255";

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
    public Opto22EthernetIoUnitProtocolType IoUnitProtocol { get; set; } = Opto22EthernetIoUnitProtocolType.TcpIp;

    /// <inheritdoc />
    [Range(1, 65535)]
    public int IoUnitPortNumber { get; set; } = 2001;

    /// <inheritdoc />
    [Range(1, 65535)]
    public int ControlEnginePortNumber { get; set; } = 22001;

    /// <inheritdoc />
    public string? ImportFile { get; set; }

    /// <inheritdoc />
    public Opto22EthernetTagGenerationOnStartupType TagGenerationOnStartup { get; set; } = Opto22EthernetTagGenerationOnStartupType.DoNotGenerateOnStartup;

    /// <inheritdoc />
    public Opto22EthernetTagGenerationDuplicateHandlingType TagGenerationDuplicateHandling { get; set; } = Opto22EthernetTagGenerationDuplicateHandlingType.DeleteOnCreate;

    /// <inheritdoc />
    [MaxLength(256)]
    public string? TagGenerationGroup { get; set; }

    /// <inheritdoc />
    public bool AllowAutomaticallyGeneratedSubgroups { get; set; } = true;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DeviceId)}: {DeviceId}, {nameof(IoUnitPortNumber)}: {IoUnitPortNumber}";
}