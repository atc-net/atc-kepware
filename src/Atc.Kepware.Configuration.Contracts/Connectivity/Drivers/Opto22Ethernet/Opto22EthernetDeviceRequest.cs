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
    public Opto22EthernetDeviceModelType Model { get; set; } = Opto22EthernetDeviceModelType.SnapPacR1;

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
    public int Port { get; set; } = 2001;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}
