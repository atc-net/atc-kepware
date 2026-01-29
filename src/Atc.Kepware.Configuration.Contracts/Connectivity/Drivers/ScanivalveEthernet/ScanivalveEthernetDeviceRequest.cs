namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.ScanivalveEthernet;

/// <summary>
/// Device properties for the Scanivalve Ethernet driver.
/// </summary>
public sealed class ScanivalveEthernetDeviceRequest : DeviceRequestBase, IScanivalveEthernetDeviceRequest
{
    public ScanivalveEthernetDeviceRequest()
        : base(DriverType.ScanivalveEthernet)
    {
    }

    /// <inheritdoc />
    public ScanivalveEthernetDeviceModelType Model { get; set; } = ScanivalveEthernetDeviceModelType.Dsa3200;

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
    [Range(1, 65535)]
    public int Port { get; set; } = 23;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}
