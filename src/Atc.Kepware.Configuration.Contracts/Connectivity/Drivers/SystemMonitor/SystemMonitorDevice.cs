namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.SystemMonitor;

/// <summary>
/// Device properties for the System Monitor driver.
/// </summary>
public sealed class SystemMonitorDevice : DeviceBase, ISystemMonitorDevice
{
    /// <inheritdoc />
    public string DeviceId { get; set; } = "localhost";

    /// <inheritdoc />
    public int QuerySize { get; set; } = 50;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(QuerySize)}: {QuerySize}";
}