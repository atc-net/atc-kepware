namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.Ping;

/// <summary>
/// Represents a Ping device.
/// </summary>
public class PingDevice : DeviceBase, IPingDevice
{
    /// <inheritdoc />
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}";
}