namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.YokogawaGxEthernet;

/// <summary>
/// Yokogawa GX Ethernet device request.
/// </summary>
public class YokogawaGxEthernetDeviceRequest : DeviceRequestBase, IYokogawaGxEthernetDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="YokogawaGxEthernetDeviceRequest"/> class.
    /// </summary>
    public YokogawaGxEthernetDeviceRequest()
        : base(DriverType.YokogawaGxEthernet)
    {
    }

    /// <inheritdoc />
    public YokogawaGxEthernetModel Model { get; set; } = YokogawaGxEthernetModel.Gx;

    /// <inheritdoc />
    public bool As1SecurityOption { get; set; }

    /// <inheritdoc />
    public string Username { get; set; } = "admin";

    /// <inheritdoc />
    public string Password { get; set; } = "0";

    /// <inheritdoc />
    public string UserId { get; set; } = string.Empty;
}