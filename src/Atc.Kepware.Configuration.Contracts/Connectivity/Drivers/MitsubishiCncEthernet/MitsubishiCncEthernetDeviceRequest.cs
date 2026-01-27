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

    /// <inheritdoc />
    public bool FirstWordLow { get; set; } = true;

    /// <inheritdoc />
    public int PortNumber { get; set; } = 5001;

    /// <inheritdoc />
    public int SourceNetwork { get; set; } = 1;

    /// <inheritdoc />
    public int SourceStation { get; set; } = 1;

    /// <inheritdoc />
    public int DestinationNetwork { get; set; } = 1;

    /// <inheritdoc />
    public int DestinationStation { get; set; } = 2;
}
