namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.SystemMonitor;

/// <summary>
/// Device properties for the System Monitor driver.
/// </summary>
public sealed class SystemMonitorDeviceRequest : DeviceRequestBase, ISystemMonitorDeviceRequest
{
    public SystemMonitorDeviceRequest()
        : base(DriverType.SystemMonitor)
    {
    }

    /// <inheritdoc />
    public string DeviceId { get; set; } = "localhost";

    /// <inheritdoc />
    [Range(1, 100)]
    public int QuerySize { get; set; } = 50;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(QuerySize)}: {QuerySize}";
}