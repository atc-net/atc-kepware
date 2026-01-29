namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.WagoEthernet;

/// <summary>
/// Represents a Wago Ethernet device creation request.
/// </summary>
public class WagoEthernetDeviceRequest : DeviceRequestBase, IWagoEthernetDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WagoEthernetDeviceRequest"/> class.
    /// </summary>
    public WagoEthernetDeviceRequest()
        : base(DriverType.WagoEthernet)
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
    public WagoEthernetDeviceModelType Model { get; set; } = WagoEthernetDeviceModelType.Model_750_342;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int PortNumber { get; set; } = 502;

    /// <inheritdoc />
    [Range(8, 800)]
    public int InputCoils { get; set; } = 32;

    /// <inheritdoc />
    [Range(8, 800)]
    public int OutputCoils { get; set; } = 32;

    /// <inheritdoc />
    [Range(1, 120)]
    public int InternalRegisters { get; set; } = 32;

    /// <inheritdoc />
    [Range(1, 120)]
    public int HoldingRegisters { get; set; } = 32;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}";
}
