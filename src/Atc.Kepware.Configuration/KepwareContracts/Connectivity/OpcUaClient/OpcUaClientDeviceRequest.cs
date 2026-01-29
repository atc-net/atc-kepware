namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.OpcUaClient;

internal class OpcUaClientDeviceRequest : DeviceRequestBase, IOpcUaClientDeviceRequest
{
    public OpcUaClientDeviceRequest()
        : base(DriverType.OpcUaClient)
    {
    }

    /// <inheritdoc />
    [Range(100, 60000)]
    [JsonPropertyName("opcuaclient.DEVICE_SUBSCRIPTION_PUBLISHING_INTERVAL_MILLISECONDS")]
    public int PublishingInterval { get; set; } = 1000;

    /// <inheritdoc />
    [Range(0, 4294967295)]
    [JsonPropertyName("opcuaclient.DEVICE_SUBSCRIPTION_MAX_NOTIFICATIONS_PER_PUBLISH")]
    public long MaxNotificationsPerPublish { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("opcuaclient.DEVICE_SUBSCRIPTION_UPDATE_MODE")]
    public OpcUaDeviceSubscriptionUpdateModeType UpdateMode { get; set; } = OpcUaDeviceSubscriptionUpdateModeType.Exception;

    /// <inheritdoc />
    [JsonPropertyName("opcuaclient.DEVICE_SUBSCRIPTION_REGISTERED_READWRITE")]
    public bool RegisteredReadWrite { get; set; } = true;

    /// <inheritdoc />
    [Range(1, 4096)]
    [JsonPropertyName("opcuaclient.DEVICE_MAX_ITEMS_PER_READ")]
    public int MaxItemsPerRead { get; set; } = 512;

    /// <inheritdoc />
    [Range(1, 512)]
    [JsonPropertyName("opcuaclient.DEVICE_MAX_ITEMS_PER_WRITE")]
    public int MaxItemsPerWrite { get; set; } = 512;

    /// <inheritdoc />
    [Range(100, 30000)]
    [JsonPropertyName("opcuaclient.DEVICE_READ_TIMEOUT_MS")]
    public int ReadTimeout { get; set; } = 1000;

    /// <inheritdoc />
    [Range(100, 30000)]
    [JsonPropertyName("opcuaclient.DEVICE_WRITE_TIMEOUT_MS")]
    public int WriteTimeout { get; set; } = 1000;

    /// <inheritdoc />
    [JsonPropertyName("opcuaclient.DEVICE_READ_AFTER_WRITE")]
    public bool ReadAfterWrite { get; set; } = true;

    /// <inheritdoc />
    [Range(3, 300)]
    [JsonPropertyName("opcuaclient.DEVICE_CONNECTION_LIFETIME_COUNT")]
    public int LifetimeCount { get; set; } = 60;

    /// <inheritdoc />
    [Range(1, 10)]
    [JsonPropertyName("opcuaclient.DEVICE_CONNECTION_MAX_KEEP_ALIVE")]
    public int KeepAliveCount { get; set; } = 5;

    /// <inheritdoc />
    [JsonPropertyName("opcuaclient.DEVICE_CONNECTION_PRIORITY")]
    public OpcUaDeviceConnectionPriorityType ConnectionPriority { get; set; } = OpcUaDeviceConnectionPriorityType.Lowest;

    /// <inheritdoc />
    [Range(-1, 50000)]
    [JsonPropertyName("opcuaclient.DEVICE_MONITORED_ITEMS_SAMPLE_INTERVAL_MILLISECONDS")]
    public int SampleInterval { get; set; } = 500;

    /// <inheritdoc />
    [Range(1, 100)]
    [JsonPropertyName("opcuaclient.DEVICE_MONITORED_ITEMS_QUEUE_SIZE")]
    public int QueueSize { get; set; } = 1;

    /// <inheritdoc />
    [JsonPropertyName("opcuaclient.DEVICE_MONITORED_ITEMS_DISCARD_OLDEST")]
    public bool DiscardOldest { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("opcuaclient.DEVICE_MONITORED_ITEMS_DEADBAND_TYPE")]
    public OpcUaDeviceMonitoredItemsDeadBandType DeadBand { get; set; } = OpcUaDeviceMonitoredItemsDeadBandType.None;

    /// <inheritdoc />
    [Range(0, 999999999)]
    [JsonPropertyName("opcuaclient.DEVICE_MONITORED_ITEMS_DEADBAND_VALUE")]
    public double DeadBandValue { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(PublishingInterval)}: {PublishingInterval}, {nameof(MaxNotificationsPerPublish)}: {MaxNotificationsPerPublish}, {nameof(UpdateMode)}: {UpdateMode}, {nameof(RegisteredReadWrite)}: {RegisteredReadWrite}, {nameof(MaxItemsPerRead)}: {MaxItemsPerRead}, {nameof(MaxItemsPerWrite)}: {MaxItemsPerWrite}, {nameof(ReadTimeout)}: {ReadTimeout}, {nameof(WriteTimeout)}: {WriteTimeout}, {nameof(ReadAfterWrite)}: {ReadAfterWrite}, {nameof(LifetimeCount)}: {LifetimeCount}, {nameof(KeepAliveCount)}: {KeepAliveCount}, {nameof(ConnectionPriority)}: {ConnectionPriority}, {nameof(SampleInterval)}: {SampleInterval}, {nameof(QueueSize)}: {QueueSize}, {nameof(DiscardOldest)}: {DiscardOldest}, {nameof(DeadBand)}: {DeadBand}, {nameof(DeadBandValue)}: {DeadBandValue}";
}