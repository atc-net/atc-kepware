namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.Ping;

/// <summary>
/// Represents a Ping device creation request.
/// </summary>
public class PingDeviceRequest : DeviceRequestBase, IPingDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PingDeviceRequest"/> class.
    /// </summary>
    public PingDeviceRequest()
        : base(DriverType.Ping)
    {
    }

    /// <inheritdoc />
    [Required]
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}";
}
