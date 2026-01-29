namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.ToshibaEthernet;

/// <summary>
/// Represents a Toshiba Ethernet device creation request.
/// </summary>
public class ToshibaEthernetDeviceRequest : DeviceRequestBase, IToshibaEthernetDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ToshibaEthernetDeviceRequest"/> class.
    /// </summary>
    public ToshibaEthernetDeviceRequest()
        : base(DriverType.ToshibaEthernet)
    {
    }

    /// <summary>
    /// Gets or sets the device IP address.
    /// </summary>
    /// <remarks>
    /// Format: IP.Address (e.g., "192.168.1.1").
    /// </remarks>
    [Required]
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    [Range(0, 65535)]
    public int PortNumber { get; set; } = 1024;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}";
}
