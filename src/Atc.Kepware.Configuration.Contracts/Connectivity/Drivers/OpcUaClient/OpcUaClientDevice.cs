namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.OpcUaClient;

public sealed class OpcUaClientDevice : DeviceBase, IOpcUaClientDevice
{
    public int PublishingInterval { get; set; }

    public int MaxNotificationsPerPublish { get; set; }

    public OpcUaDeviceSubscriptionUpdateModeType UpdateMode { get; set; }

    public bool RegisteredReadWrite { get; set; }

    public int MaxItemsPerRead { get; set; }

    public int MaxItemsPerWrite { get; set; }

    public int ReadTimeout { get; set; }

    public int WriteTimeout { get; set; }

    public bool ReadAfterWrite { get; set; }

    public int LifetimeCount { get; set; }

    public int KeepAliveCount { get; set; }

    public OpcUaDeviceConnectionPriorityType ConnectionPriority { get; set; }

    public int SampleInterval { get; set; }

    public int QueueSize { get; set; }

    public bool DiscardOldest { get; set; }

    public OpcUaDeviceMonitoredItemsDeadBandType DeadBand { get; set; }

    public int DeadBandValue { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(PublishingInterval)}: {PublishingInterval}, {nameof(MaxNotificationsPerPublish)}: {MaxNotificationsPerPublish}, {nameof(UpdateMode)}: {UpdateMode}, {nameof(RegisteredReadWrite)}: {RegisteredReadWrite}, {nameof(MaxItemsPerRead)}: {MaxItemsPerRead}, {nameof(MaxItemsPerWrite)}: {MaxItemsPerWrite}, {nameof(ReadTimeout)}: {ReadTimeout}, {nameof(WriteTimeout)}: {WriteTimeout}, {nameof(ReadAfterWrite)}: {ReadAfterWrite}, {nameof(LifetimeCount)}: {LifetimeCount}, {nameof(KeepAliveCount)}: {KeepAliveCount}, {nameof(ConnectionPriority)}: {ConnectionPriority}, {nameof(SampleInterval)}: {SampleInterval}, {nameof(QueueSize)}: {QueueSize}, {nameof(DiscardOldest)}: {DiscardOldest}, {nameof(DeadBand)}: {DeadBand}, {nameof(DeadBandValue)}: {DeadBandValue}";
}