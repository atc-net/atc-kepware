namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.BristolBsapIp;

/// <summary>
/// Device properties for the Bristol BSAP IP driver.
/// </summary>
public sealed class BristolBsapIpDeviceRequest : DeviceRequestBase, IBristolBsapIpDeviceRequest
{
    public BristolBsapIpDeviceRequest()
        : base(DriverType.BristolBsapIp)
    {
    }

    /// <inheritdoc />
    public BristolBsapIpDeviceModelType Model { get; set; } = BristolBsapIpDeviceModelType.Dpc33Xx;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int RtuGlobalAddress { get; set; }

    /// <inheritdoc />
    [Required]
    [MaxLength(15)]
    public string RtuIpAddress { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    [Range(1, 65535)]
    public int RtuUdpPort { get; set; } = 1234;

    /// <inheritdoc />
    [Range(64, 256)]
    public int MaximumBytesPerRequest { get; set; } = 256;

    /// <inheritdoc />
    public BristolBsapIpDeviceLevelType Level { get; set; } = BristolBsapIpDeviceLevelType.Level1;

    /// <inheritdoc />
    [Range(100, 60000)]
    public int RequestTimeoutMs { get; set; } = 1000;

    /// <inheritdoc />
    [Range(1, 10)]
    public int FailAfterSuccessiveTimeouts { get; set; } = 3;

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
    [MaxLength(260)]
    public string? TagImportFile { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(RtuIpAddress)}: {RtuIpAddress}, {nameof(RtuUdpPort)}: {RtuUdpPort}, {nameof(Level)}: {Level}";
}