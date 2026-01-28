namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.KraussMaffeiMc4Ethernet;

/// <summary>
/// Device properties for the KraussMaffei MC4 Ethernet driver.
/// </summary>
public sealed class KraussMaffeiMc4EthernetDeviceRequest : DeviceRequestBase, IKraussMaffeiMc4EthernetDeviceRequest
{
    public KraussMaffeiMc4EthernetDeviceRequest()
        : base(DriverType.KraussMaffeiMc4Ethernet)
    {
    }

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
    [Range(1, 255)]
    public int MachineId { get; set; } = 1;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}, {nameof(MachineId)}: {MachineId}";
}
