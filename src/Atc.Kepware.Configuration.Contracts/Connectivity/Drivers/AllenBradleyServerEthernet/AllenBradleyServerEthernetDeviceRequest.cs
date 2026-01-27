namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AllenBradleyServerEthernet;

/// <summary>
/// Allen-Bradley Server Ethernet device request.
/// </summary>
public class AllenBradleyServerEthernetDeviceRequest : DeviceRequestBase, IAllenBradleyServerEthernetDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AllenBradleyServerEthernetDeviceRequest"/> class.
    /// </summary>
    public AllenBradleyServerEthernetDeviceRequest()
        : base(DriverType.AllenBradleyServerEthernet)
    {
    }

    /// <inheritdoc />
    public int Port { get; set; } = 2222;

    /// <inheritdoc />
    public bool FirstWordLow { get; set; }
}
