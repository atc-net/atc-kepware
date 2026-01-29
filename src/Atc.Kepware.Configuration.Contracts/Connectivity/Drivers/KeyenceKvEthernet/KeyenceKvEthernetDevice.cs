namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.KeyenceKvEthernet;

public sealed class KeyenceKvEthernetDevice : DeviceBase, IKeyenceKvEthernetDevice
{
    /// <inheritdoc />
    public KeyenceKvEthernetDeviceModelType Model { get; set; }

    /// <inheritdoc />
    public KeyenceKvEthernetDeviceIdFormatType IdFormat { get; set; }

    /// <inheritdoc />
    public string DeviceId { get; set; } = string.Empty;

    /// <inheritdoc />
    public int ConnectTimeoutSeconds { get; set; }

    /// <inheritdoc />
    public int RequestTimeoutMs { get; set; }

    /// <inheritdoc />
    public int RetryAttempts { get; set; }

    /// <inheritdoc />
    public bool DemoteOnFailure { get; set; }

    /// <inheritdoc />
    public int TimeoutsToDemote { get; set; }

    /// <inheritdoc />
    public int DemotionPeriodMs { get; set; }

    /// <inheritdoc />
    public bool DiscardRequestsWhenDemoted { get; set; }

    /// <inheritdoc />
    public KeyenceKvEthernetIpProtocolType IpProtocol { get; set; }

    /// <inheritdoc />
    public int PortNumber { get; set; }

    /// <inheritdoc />
    public int WordMemoryBlockSize { get; set; }

    /// <inheritdoc />
    public int TimerCounterMemoryBlockSize { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}";
}
