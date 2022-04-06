namespace Atc.Kepware.Configuration.Contracts.OpcUaClient;

public sealed class OpcUaClientDeviceRequest : DeviceRequestBase, IOpcUaClientDeviceRequest
{
    public OpcUaClientDeviceRequest()
        : base(DriverType.OpcUaClient)
    {
    }

    /// <inheritdoc />
    [Range(100, 60000)]
    public int PublishingInterval { get; set; } = 1000;

    /// <inheritdoc />
    [Range(0, 2147483647)]
    public int MaxNotificationsPerPublish { get; set; }

    /// <inheritdoc />
    public OpcUaDeviceSubscriptionUpdateModeType UpdateMode { get; set; } = OpcUaDeviceSubscriptionUpdateModeType.Exception;

    /// <inheritdoc />
    public bool RegisteredReadWrite { get; set; } = true;

    /// <inheritdoc />
    [Range(1, 4096)]
    public int MaxItemsPerRead { get; set; } = 512;

    /// <inheritdoc />
    [Range(1, 512)]
    public int MaxItemsPerWrite { get; set; } = 512;

    /// <inheritdoc />
    [Range(100, 30000)]
    public int ReadTimeout { get; set; } = 1000;

    /// <inheritdoc />
    [Range(100, 30000)]
    public int WriteTimeout { get; set; } = 1000;

    /// <inheritdoc />
    public bool ReadAfterWrite { get; set; } = true;

    /// <inheritdoc />
    [Range(3, 300)]
    public int LifetimeCount { get; set; } = 60;

    /// <inheritdoc />
    [Range(1, 10)]
    public int KeepAliveCount { get; set; } = 5;

    /// <inheritdoc />
    public OpcUaDeviceConnectionPriorityType ConnectionPriority { get; set; } = OpcUaDeviceConnectionPriorityType.Lowest;

    /// <inheritdoc />
    [Range(-1, 50000)]
    public int SampleInterval { get; set; } = 500;

    /// <inheritdoc />
    [Range(1, 100)]
    public int QueueSize { get; set; } = 1;

    /// <inheritdoc />
    public bool DiscardOldest { get; set; } = true;

    /// <inheritdoc />
    public OpcUaDeviceMonitoredItemsDeadBandType DeadBand { get; set; } = OpcUaDeviceMonitoredItemsDeadBandType.None;

    /// <inheritdoc />
    [Range(0, 999999999)]
    public int DeadBandValue { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(PublishingInterval)}: {PublishingInterval}, {nameof(MaxNotificationsPerPublish)}: {MaxNotificationsPerPublish}, {nameof(UpdateMode)}: {UpdateMode}, {nameof(RegisteredReadWrite)}: {RegisteredReadWrite}, {nameof(MaxItemsPerRead)}: {MaxItemsPerRead}, {nameof(MaxItemsPerWrite)}: {MaxItemsPerWrite}, {nameof(ReadTimeout)}: {ReadTimeout}, {nameof(WriteTimeout)}: {WriteTimeout}, {nameof(ReadAfterWrite)}: {ReadAfterWrite}, {nameof(LifetimeCount)}: {LifetimeCount}, {nameof(KeepAliveCount)}: {KeepAliveCount}, {nameof(ConnectionPriority)}: {ConnectionPriority}, {nameof(SampleInterval)}: {SampleInterval}, {nameof(QueueSize)}: {QueueSize}, {nameof(DiscardOldest)}: {DiscardOldest}, {nameof(DeadBand)}: {DeadBand}, {nameof(DeadBandValue)}: {DeadBandValue}";
}