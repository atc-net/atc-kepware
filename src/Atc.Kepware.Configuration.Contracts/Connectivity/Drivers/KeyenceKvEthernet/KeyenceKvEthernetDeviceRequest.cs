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
    public KeyenceKvEthernetDeviceModelType Model { get; set; } = KeyenceKvEthernetDeviceModelType.KvSeries;

    /// <inheritdoc />
    public KeyenceKvEthernetDeviceIdFormatType IdFormat { get; set; } = KeyenceKvEthernetDeviceIdFormatType.Octal;

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
    public KeyenceKvEthernetIpProtocolType IpProtocol { get; set; } = KeyenceKvEthernetIpProtocolType.TcpIp;

    /// <inheritdoc />
    [Range(1, 65535)]
    public int PortNumber { get; set; } = 8501;

    /// <inheritdoc />
    [Range(1, 1000)]
    public int WordMemoryBlockSize { get; set; } = 1000;

    /// <inheritdoc />
    [Range(1, 120)]
    public int TimerCounterMemoryBlockSize { get; set; } = 120;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}";
}