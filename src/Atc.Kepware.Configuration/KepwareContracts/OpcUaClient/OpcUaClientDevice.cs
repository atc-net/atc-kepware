namespace Atc.Kepware.Configuration.KepwareContracts.OpcUaClient;

internal class OpcUaClientDevice : DeviceBase, IOpcUaClientDevice
{
    [JsonPropertyName("opcuaclient.DEVICE_SUBSCRIPTION_PUBLISHING_INTERVAL_MILLISECONDS")]
    public int PublishingInterval { get; set; }

    [JsonPropertyName("opcuaclient.DEVICE_SUBSCRIPTION_MAX_NOTIFICATIONS_PER_PUBLISH")]
    public int MaxNotificationsPerPublish { get; set; }

    [JsonPropertyName("opcuaclient.DEVICE_SUBSCRIPTION_UPDATE_MODE")]
    public OpcUaDeviceSubscriptionUpdateModeType UpdateMode { get; set; }

    [JsonPropertyName("opcuaclient.DEVICE_SUBSCRIPTION_REGISTERED_READWRITE")]
    public bool RegisteredReadWrite { get; set; }

    [JsonPropertyName("opcuaclient.DEVICE_MAX_ITEMS_PER_READ")]
    public int MaxItemsPerRead { get; set; }

    [JsonPropertyName("opcuaclient.DEVICE_MAX_ITEMS_PER_WRITE")]
    public int MaxItemsPerWrite { get; set; }

    [JsonPropertyName("opcuaclient.DEVICE_READ_TIMEOUT_MS")]
    public int ReadTimeout { get; set; }

    [JsonPropertyName("opcuaclient.DEVICE_WRITE_TIMEOUT_MS")]
    public int WriteTimeout { get; set; }

    [JsonPropertyName("opcuaclient.DEVICE_READ_AFTER_WRITE")]
    public bool ReadAfterWrite { get; set; }

    [JsonPropertyName("opcuaclient.DEVICE_CONNECTION_LIFETIME_COUNT")]
    public int LifetimeCount { get; set; }

    [JsonPropertyName("opcuaclient.DEVICE_CONNECTION_MAX_KEEP_ALIVE")]
    public int KeepAliveCount { get; set; }

    [JsonPropertyName("opcuaclient.DEVICE_CONNECTION_PRIORITY")]
    public OpcUaDeviceConnectionPriorityType ConnectionPriority { get; set; }

    [JsonPropertyName("opcuaclient.DEVICE_MONITORED_ITEMS_SAMPLE_INTERVAL_MILLISECONDS")]
    public int SampleInterval { get; set; }

    [JsonPropertyName("opcuaclient.DEVICE_MONITORED_ITEMS_QUEUE_SIZE")]
    public int QueueSize { get; set; }

    [JsonPropertyName("opcuaclient.DEVICE_MONITORED_ITEMS_DISCARD_OLDEST")]
    public bool DiscardOldest { get; set; }

    [JsonPropertyName("opcuaclient.DEVICE_MONITORED_ITEMS_DEADBAND_TYPE")]
    public OpcUaDeviceMonitoredItemsDeadBandType DeadBand { get; set; }

    [JsonPropertyName("opcuaclient.DEVICE_MONITORED_ITEMS_DEADBAND_VALUE")]
    public int DeadBandValue { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(PublishingInterval)}: {PublishingInterval}, {nameof(MaxNotificationsPerPublish)}: {MaxNotificationsPerPublish}, {nameof(UpdateMode)}: {UpdateMode}, {nameof(RegisteredReadWrite)}: {RegisteredReadWrite}, {nameof(MaxItemsPerRead)}: {MaxItemsPerRead}, {nameof(MaxItemsPerWrite)}: {MaxItemsPerWrite}, {nameof(ReadTimeout)}: {ReadTimeout}, {nameof(WriteTimeout)}: {WriteTimeout}, {nameof(ReadAfterWrite)}: {ReadAfterWrite}, {nameof(LifetimeCount)}: {LifetimeCount}, {nameof(KeepAliveCount)}: {KeepAliveCount}, {nameof(ConnectionPriority)}: {ConnectionPriority}, {nameof(SampleInterval)}: {SampleInterval}, {nameof(QueueSize)}: {QueueSize}, {nameof(DiscardOldest)}: {DiscardOldest}, {nameof(DeadBand)}: {DeadBand}, {nameof(DeadBandValue)}: {DeadBandValue}";
}