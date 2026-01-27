namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.MitsubishiCncEthernet;

/// <summary>
/// Mitsubishi CNC Ethernet device request.
/// </summary>
public class MitsubishiCncEthernetDeviceRequest : DeviceRequestBase, IMitsubishiCncEthernetDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MitsubishiCncEthernetDeviceRequest"/> class.
    /// </summary>
    public MitsubishiCncEthernetDeviceRequest()
        : base(DriverType.MitsubishiCncEthernet)
    {
    }

    /// <summary>
    /// Gets or sets the device IP address.
    /// </summary>
    /// <remarks>
    /// Format: IP.Address (e.g., "255.255.255.255").
    /// </remarks>
    [Required]
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    public MitsubishiCncEthernetDeviceModelType Model { get; set; } = MitsubishiCncEthernetDeviceModelType.C64;

    /// <inheritdoc />
    public bool FirstWordLow { get; set; } = true;

    /// <inheritdoc />
    [Range(1, 65535)]
    public int PortNumber { get; set; } = 5001;

    /// <inheritdoc />
    [Range(1, 239)]
    public int SourceNetwork { get; set; } = 1;

    /// <inheritdoc />
    [Range(1, 239)]
    public int SourceStation { get; set; } = 1;

    /// <inheritdoc />
    [Range(0, 239)]
    public int DestinationNetwork { get; set; } = 1;

    /// <inheritdoc />
    [Range(0, 239)]
    public int DestinationStation { get; set; } = 2;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Model)}: {Model}";
}
