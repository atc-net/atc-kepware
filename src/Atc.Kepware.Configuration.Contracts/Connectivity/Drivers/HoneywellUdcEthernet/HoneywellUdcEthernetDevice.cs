namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.HoneywellUdcEthernet;

/// <summary>
/// Device properties for the Honeywell UDC Ethernet driver.
/// </summary>
public sealed class HoneywellUdcEthernetDevice : DeviceBase, IHoneywellUdcEthernetDevice
{
    /// <inheritdoc />
    public HoneywellUdcEthernetDeviceModelType Model { get; set; }

    /// <inheritdoc />
    public HoneywellUdcEthernetDeviceIdFormatType IdFormat { get; set; }

    /// <inheritdoc />
    public string DeviceId { get; set; } = string.Empty;

    /// <inheritdoc />
    public int ConnectTimeoutSeconds { get; set; }

    /// <inheritdoc />
    public int RequestTimeoutMs { get; set; }

    /// <inheritdoc />
    public int RetryAttempts { get; set; }

    /// <inheritdoc />
    public int InterRequestDelayMs { get; set; }

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
    public int Port { get; set; }

    /// <inheritdoc />
    public bool FirstWordLow { get; set; }

    /// <inheritdoc />
    public int InternalRegisters { get; set; }

    /// <inheritdoc />
    public int HoldingRegisters { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(IdFormat)}: {IdFormat}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}
