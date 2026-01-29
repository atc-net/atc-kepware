namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.YokogawaGxEthernet;

/// <summary>
/// Yokogawa GX Ethernet device.
/// </summary>
public class YokogawaGxEthernetDevice : DeviceBase, IYokogawaGxEthernetDevice
{
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