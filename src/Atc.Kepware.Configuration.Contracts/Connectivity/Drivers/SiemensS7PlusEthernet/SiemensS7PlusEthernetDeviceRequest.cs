namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.SiemensS7PlusEthernet;

/// <summary>
/// Represents a Siemens S7 Plus Ethernet device creation request.
/// </summary>
public class SiemensS7PlusEthernetDeviceRequest : DeviceRequestBase, ISiemensS7PlusEthernetDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SiemensS7PlusEthernetDeviceRequest"/> class.
    /// </summary>
    public SiemensS7PlusEthernetDeviceRequest()
        : base(DriverType.SiemensS7PlusEthernet)
    {
    }

    /// <summary>
    /// Gets or sets the device IP address.
    /// </summary>
    [Required]
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    [Range(1, 65535)]
    public int Port { get; set; } = 102;

    /// <inheritdoc />
    public string? PlcPassword { get; set; }

    /// <inheritdoc />
    public bool IncludeIdbsFbs { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}