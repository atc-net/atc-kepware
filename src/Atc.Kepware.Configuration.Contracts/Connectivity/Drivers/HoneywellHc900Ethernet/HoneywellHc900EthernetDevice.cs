namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.HoneywellHc900Ethernet;

public sealed class HoneywellHc900EthernetDevice : DeviceBase, IHoneywellHc900EthernetDevice
{
    /// <inheritdoc />
    public HoneywellHc900EthernetDeviceModelType Model { get; set; }

    /// <inheritdoc />
    public HoneywellHc900EthernetDeviceIdFormatType IdFormat { get; set; }

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
    public int Port { get; set; }

    /// <inheritdoc />
    public bool FirstWordLow { get; set; }

    /// <inheritdoc />
    public int OutputCoils { get; set; }

    /// <inheritdoc />
    public int InputCoils { get; set; }

    /// <inheritdoc />
    public int InternalRegisters { get; set; }

    /// <inheritdoc />
    public int HoldingRegisters { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(IdFormat)}: {IdFormat}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}
