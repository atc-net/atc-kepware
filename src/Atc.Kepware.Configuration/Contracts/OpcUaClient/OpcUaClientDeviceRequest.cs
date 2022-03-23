namespace Atc.Kepware.Configuration.Contracts.OpcUaClient;

public class OpcUaClientDeviceRequest : DeviceRequestBase
{
    public OpcUaClientDeviceRequest()
        : base(DriverType.OpcUaClient)
    {
    }

    /// <summary>
    /// The rate, in milliseconds, at which tags are updated by the driver.
    /// If the value is not supported by the OPC UA server, the rate is negotiated during connection.
    /// </summary>
    [Range(100, 60000)]
    public int PublishingInterval { get; set; } = 1000;

    /// <summary>
    /// The maximum number of notifications the OPC UA server
    /// sends to the driver in a single publish response.
    /// If the value is low, the OPC UA server may drop tag updates.
    /// Zero means no limit.
    /// </summary>
    [Range(0, 4294967295)]
    public int MaxNotificationsPerPublish { get; set; }

    /// <summary>
    /// The subscription method.
    /// </summary>
    public OpcUaDeviceSubscriptionUpdateModeType UpdateMode { get; set; } = OpcUaDeviceSubscriptionUpdateModeType.Exception;

    /// <summary>
    /// Choose whether device tags are registered with the UA Server.
    /// If enabled, nodes are registered to optimize read and write operations.
    /// </summary>
    /// <remarks>
    /// Property is only applicable when <see cref="OpcUaDeviceSubscriptionUpdateModeType"/> is <see cref="OpcUaDeviceSubscriptionUpdateModeType.Poll"/>.
    /// </remarks>
    public bool RegisteredReadWrite { get; set; } = true;

    /// <summary>
    /// The maximum number of items in each read call to the server for subscriptions in Polled Update Mode
    /// and during the import of items.
    /// Since reads are more efficient when grouped, this should be kept as high as possible to decrease read times.
    /// </summary>
    [Range(1, 4096)]
    public int MaxItemsPerRead { get; set; } = 512;

    /// <summary>
    /// The maximum number of items in each write call to the server.
    /// Since writes are more efficient when grouped,
    /// this value should be kept as high as possible to decrease write times.
    /// </summary>
    [Range(1, 512)]
    public int MaxItemsPerWrite { get; set; } = 512;

    /// <summary>
    /// The time, in milliseconds, allowed for each read call. Shorter timeouts may cause reads to timeout;
    /// longer timeouts may cause the driver to be less responsive if communication is interrupted.
    /// </summary>
    [Range(100, 30000)]
    public int ReadTimeout { get; set; } = 1000;

    /// <summary>
    /// The time, in milliseconds, allowed for each write call. Shorter timeouts may cause writes to timeout;
    /// longer timeouts may cause the driver to be less responsive if communication is interrupted.
    /// </summary>
    [Range(100, 30000)]
    public int WriteTimeout { get; set; } = 1000;

    /// <summary>
    /// Choose whether an explicit read occurs after a write.
    /// If disabled, the driver only waits for the write-complete message
    /// and the cache is updated when the next publish or poll response is received.
    /// </summary>
    public bool ReadAfterWrite { get; set; } = true;

    /// <summary>
    /// Specifies how many times the publishing interval can expire without the OPC UA Client Driver
    /// sending data updates or keep-alive messages before the server deletes the subscription.
    /// The larger the value, the longer the subscription remains running if communication is interrupted.
    /// </summary>
    [Range(3, 300)]
    public int LifetimeCount { get; set; } = 60;

    /// <summary>
    /// The number of publishing intervals that must expire before a keep-alive message is sent.
    /// </summary>
    [Range(1, 10)]
    public int KeepAliveCount { get; set; } = 5;

    /// <summary>
    /// Select the relative priority of the subscription.
    /// When more than one subscription needs to send notifications,
    /// the OPC UA server sends data from the subscription with the highest priority first.
    /// Applications that do not require special priority should be set to the lowest priority possible.
    /// </summary>
    public OpcUaDeviceConnectionPriorityType ConnectionPriority { get; set; } = OpcUaDeviceConnectionPriorityType.Lowest;

    /// <summary>
    /// Specify the maximum rate, in milliseconds, at which monitored items are updated.
    /// A value of -1 sets the interval to the subscription Publishing Interval.
    /// A value of zero indicates that the remote OPC UA server should use the fastest practical rate.
    /// </summary>
    /// <remarks>
    /// Property is only applicable when <see cref="OpcUaDeviceSubscriptionUpdateModeType"/> is <see cref="OpcUaDeviceSubscriptionUpdateModeType.Exception"/>.
    /// </remarks>
    [Range(-1, 50000)]
    public int SampleInterval { get; set; } = 500;

    /// <summary>
    /// Specify the number of data updates that the OPC UA server queues for the subscription.
    /// A value of 1 disables queuing. Values greater than 1 enable queuing.
    /// </summary>
    /// <remarks>
    /// Property is only applicable when <see cref="OpcUaDeviceSubscriptionUpdateModeType"/> is <see cref="OpcUaDeviceSubscriptionUpdateModeType.Exception"/>.
    /// </remarks>
    [Range(1, 100)]
    public int QueueSize { get; set; } = 1;

    /// <summary>
    /// Indicate if the oldest notification in the queue should be discarded and not sent to the driver.
    /// If disabled, the newest notification is discarded and not sent to the driver.
    /// </summary>
    /// <remarks>
    /// Property is only applicable when <see cref="OpcUaDeviceSubscriptionUpdateModeType"/> is <see cref="OpcUaDeviceSubscriptionUpdateModeType.Exception"/>.
    /// </remarks>
    public bool DiscardOldest { get; set; } = true;

    /// <summary>
    /// The type of deadband filter to be applied to data changes.
    /// </summary>
    public OpcUaDeviceMonitoredItemsDeadBandType DeadBand { get; set; } = OpcUaDeviceMonitoredItemsDeadBandType.None;

    /// <summary>
    /// Specify the value for the selected <see cref="OpcUaDeviceMonitoredItemsDeadBandType"/>.
    /// If set to Percent, this value is a percentage number (such as, 10=10%).
    /// If set to Absolute, this value is the threshold number.
    /// </summary>
    [Range(0, 999999999)]
    public int DeadBandValue { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(PublishingInterval)}: {PublishingInterval}, {nameof(MaxNotificationsPerPublish)}: {MaxNotificationsPerPublish}, {nameof(UpdateMode)}: {UpdateMode}, {nameof(RegisteredReadWrite)}: {RegisteredReadWrite}, {nameof(MaxItemsPerRead)}: {MaxItemsPerRead}, {nameof(MaxItemsPerWrite)}: {MaxItemsPerWrite}, {nameof(ReadTimeout)}: {ReadTimeout}, {nameof(WriteTimeout)}: {WriteTimeout}, {nameof(ReadAfterWrite)}: {ReadAfterWrite}, {nameof(LifetimeCount)}: {LifetimeCount}, {nameof(KeepAliveCount)}: {KeepAliveCount}, {nameof(ConnectionPriority)}: {ConnectionPriority}, {nameof(SampleInterval)}: {SampleInterval}, {nameof(QueueSize)}: {QueueSize}, {nameof(DiscardOldest)}: {DiscardOldest}, {nameof(DeadBand)}: {DeadBand}, {nameof(DeadBandValue)}: {DeadBandValue}";
}