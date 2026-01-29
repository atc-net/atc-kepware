namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.SystemMonitor;

/// <summary>
/// Device properties for the System Monitor driver.
/// </summary>
internal sealed class SystemMonitorDevice : DeviceBase, ISystemMonitorDevice
{
    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = "localhost";

    /// <inheritdoc />
    [JsonPropertyName("system_monitor.DEVICE_QUERY_SIZE")]
    public int QuerySize { get; set; } = 50;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(QuerySize)}: {QuerySize}";
}