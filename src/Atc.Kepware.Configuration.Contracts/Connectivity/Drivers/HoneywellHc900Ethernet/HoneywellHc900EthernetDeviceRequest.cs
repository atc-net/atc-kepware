namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.HoneywellHc900Ethernet;

/// <summary>
/// Device properties for the Honeywell HC900 Ethernet driver.
/// </summary>
public sealed class HoneywellHc900EthernetDeviceRequest : DeviceRequestBase, IHoneywellHc900EthernetDeviceRequest
{
    public HoneywellHc900EthernetDeviceRequest()
        : base(DriverType.HoneywellHc900Ethernet)
    {
    }

    /// <inheritdoc />
    public HoneywellHc900EthernetDeviceModelType Model { get; set; } = HoneywellHc900EthernetDeviceModelType.Hc900;

    /// <inheritdoc />
    public HoneywellHc900EthernetDeviceIdFormatType IdFormat { get; set; } = HoneywellHc900EthernetDeviceIdFormatType.Octal;

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
    [Range(0, 65535)]
    public int Port { get; set; } = 502;

    /// <inheritdoc />
    public bool FirstWordLow { get; set; }

    /// <inheritdoc />
    [Range(8, 800)]
    public int OutputCoils { get; set; } = 32;

    /// <inheritdoc />
    [Range(8, 800)]
    public int InputCoils { get; set; } = 32;

    /// <inheritdoc />
    [Range(1, 120)]
    public int InternalRegisters { get; set; } = 32;

    /// <inheritdoc />
    [Range(1, 120)]
    public int HoldingRegisters { get; set; } = 32;

    /// <inheritdoc />
    [Range(0, 32)]
    public int NumberOfLoops { get; set; }

    /// <inheritdoc />
    [Range(0, 600)]
    public int NumberOfVariables { get; set; }

    /// <inheritdoc />
    [Range(0, 4000)]
    public int NumberOfSignalTags { get; set; }

    /// <inheritdoc />
    [Range(0, 8)]
    public int NumberOfSpProgrammers { get; set; }

    /// <inheritdoc />
    [Range(0, 50)]
    public int Segments1 { get; set; }

    /// <inheritdoc />
    [Range(0, 50)]
    public int Segments2 { get; set; }

    /// <inheritdoc />
    [Range(0, 50)]
    public int Segments3 { get; set; }

    /// <inheritdoc />
    [Range(0, 50)]
    public int Segments4 { get; set; }

    /// <inheritdoc />
    [Range(0, 50)]
    public int Segments5 { get; set; }

    /// <inheritdoc />
    [Range(0, 50)]
    public int Segments6 { get; set; }

    /// <inheritdoc />
    [Range(0, 50)]
    public int Segments7 { get; set; }

    /// <inheritdoc />
    [Range(0, 50)]
    public int Segments8 { get; set; }

    /// <inheritdoc />
    public string? TagImportFiles { get; set; }

    /// <inheritdoc />
    public bool DisplayDescriptions { get; set; } = true;

    /// <inheritdoc />
    public HoneywellHc900EthernetDeviceTagNamingType TagNaming { get; set; } = HoneywellHc900EthernetDeviceTagNamingType.Enhanced;

    /// <inheritdoc />
    public bool TagGenerationOnPropertyChange { get; set; } = true;

    /// <inheritdoc />
    public DeviceTagGenerationOnStartupType TagGenerationOnStartup { get; set; } = DeviceTagGenerationOnStartupType.GenerateOnFirstStartup;

    /// <inheritdoc />
    public DeviceTagGenerationDuplicateHandlingType TagGenerationDuplicateHandling { get; set; } = DeviceTagGenerationDuplicateHandlingType.DeleteOnCreate;

    /// <inheritdoc />
    [MaxLength(256)]
    public string? TagGenerationGroup { get; set; }

    /// <inheritdoc />
    public bool AllowAutomaticallyGeneratedSubgroups { get; set; } = true;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(IdFormat)}: {IdFormat}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}