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
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(IdFormat)}: {IdFormat}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}
