namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.KraussMaffeiMc4Ethernet;

/// <summary>
/// Device properties for the KraussMaffei MC4 Ethernet driver.
/// </summary>
public sealed class KraussMaffeiMc4EthernetDevice : DeviceBase, IKraussMaffeiMc4EthernetDevice
{
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
    public int MachineId { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}, {nameof(MachineId)}: {MachineId}";
}
