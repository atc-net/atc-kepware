namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.OpcUaClient;

public interface IOpcUaClientDevice : IDeviceBase
{
    int PublishingInterval { get; set; }

    int MaxNotificationsPerPublish { get; set; }

    OpcUaDeviceSubscriptionUpdateModeType UpdateMode { get; set; }

    bool RegisteredReadWrite { get; set; }

    int MaxItemsPerRead { get; set; }

    int MaxItemsPerWrite { get; set; }

    int ReadTimeout { get; set; }

    int WriteTimeout { get; set; }

    bool ReadAfterWrite { get; set; }

    int LifetimeCount { get; set; }

    int KeepAliveCount { get; set; }

    OpcUaDeviceConnectionPriorityType ConnectionPriority { get; set; }

    int SampleInterval { get; set; }

    int QueueSize { get; set; }

    bool DiscardOldest { get; set; }

    OpcUaDeviceMonitoredItemsDeadBandType DeadBand { get; set; }

    int DeadBandValue { get; set; }
}