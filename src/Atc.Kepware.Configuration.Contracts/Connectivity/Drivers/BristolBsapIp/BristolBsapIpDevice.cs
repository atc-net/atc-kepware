namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.BristolBsapIp;

/// <summary>
/// Device properties for the Bristol BSAP IP driver.
/// </summary>
public sealed class BristolBsapIpDevice : DeviceBase, IBristolBsapIpDevice
{
    /// <inheritdoc />
    public BristolBsapIpDeviceModelType Model { get; set; }

    /// <inheritdoc />
    public int RtuGlobalAddress { get; set; }

    /// <inheritdoc />
    public string RtuIpAddress { get; set; } = string.Empty;

    /// <inheritdoc />
    public int RtuUdpPort { get; set; }

    /// <inheritdoc />
    public int MaximumBytesPerRequest { get; set; }

    /// <inheritdoc />
    public BristolBsapIpDeviceLevelType Level { get; set; }

    /// <inheritdoc />
    public int RequestTimeoutMs { get; set; }

    /// <inheritdoc />
    public int FailAfterSuccessiveTimeouts { get; set; }

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
    public string? TagImportFile { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(RtuIpAddress)}: {RtuIpAddress}, {nameof(RtuUdpPort)}: {RtuUdpPort}, {nameof(Level)}: {Level}";
}
