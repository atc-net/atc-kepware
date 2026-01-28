namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.KeyenceKvEthernet;

/// <summary>
/// Device properties for the Keyence KV Ethernet driver.
/// </summary>
public sealed class KeyenceKvEthernetDeviceRequest : DeviceRequestBase, IKeyenceKvEthernetDeviceRequest
{
    public KeyenceKvEthernetDeviceRequest()
        : base(DriverType.KeyenceKvEthernet)
    {
    }

    /// <inheritdoc />
    [Required]
    public string DeviceId { get; set; } = string.Empty;

    /// <inheritdoc />
    [Range(1, 30)]
    public int ConnectTimeoutSeconds { get; set; } = 3;

    /// <inheritdoc />
    [Range(10, 9999999)]
    public int RequestTimeoutMs { get; set; } = 1000;

    /// <inheritdoc />
    [Range(1, 10)]
    public int RetryAttempts { get; set; } = 3;

    /// <inheritdoc />
    [Range(0, 30000)]
    public int InterRequestDelayMs { get; set; }

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
    public int Port { get; set; } = 8501;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}
