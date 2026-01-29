namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.BuswareEthernet;

/// <summary>
/// Represents a Busware Ethernet device creation request.
/// </summary>
public class BuswareEthernetDeviceRequest : DeviceRequestBase, IBuswareEthernetDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuswareEthernetDeviceRequest"/> class.
    /// </summary>
    public BuswareEthernetDeviceRequest()
        : base(DriverType.BuswareEthernet)
    {
    }

    /// <inheritdoc />
    public BuswareEthernetDeviceModelType Model { get; set; } = BuswareEthernetDeviceModelType.BuswareEthernet;

    /// <inheritdoc />
    public BuswareEthernetDeviceIdFormatType IdFormat { get; set; } = BuswareEthernetDeviceIdFormatType.Octal;

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
    public int PortNumber { get; set; } = 502;

    /// <inheritdoc />
    [Range(8, 800)]
    public int OutputDiscretes { get; set; } = 32;

    /// <inheritdoc />
    [Range(8, 800)]
    public int InputDiscretes { get; set; } = 32;

    /// <inheritdoc />
    [Range(1, 120)]
    public int OutputRegisters { get; set; } = 32;

    /// <inheritdoc />
    [Range(1, 120)]
    public int InputRegisters { get; set; } = 32;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}";
}