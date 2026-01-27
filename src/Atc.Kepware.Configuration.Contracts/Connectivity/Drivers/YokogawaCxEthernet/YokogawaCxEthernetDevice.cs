namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.YokogawaCxEthernet;

/// <summary>
/// Yokogawa CX Ethernet device.
/// </summary>
public class YokogawaCxEthernetDevice : DeviceBase, IYokogawaCxEthernetDevice
{
    /// <inheritdoc />
    public YokogawaCxEthernetModel Model { get; set; } = YokogawaCxEthernetModel.Cx1006;

    /// <inheritdoc />
    public YokogawaCxEthernetDataHandling DataHandling { get; set; } = YokogawaCxEthernetDataHandling.None;

    /// <inheritdoc />
    public int PollingInterval { get; set; } = 1000;

    /// <inheritdoc />
    public bool StartMath { get; set; }

    /// <inheritdoc />
    public YokogawaCxEthernetDateTimeSource DateAndTime { get; set; } = YokogawaCxEthernetDateTimeSource.DeviceTime;

    /// <inheritdoc />
    public YokogawaCxEthernetDateFormat DateFormat { get; set; } = YokogawaCxEthernetDateFormat.MmDdYy;

    /// <inheritdoc />
    public bool SetClock { get; set; }

    /// <inheritdoc />
    public YokogawaCxEthernetTagDatabaseSource TagDatabaseSource { get; set; } = YokogawaCxEthernetTagDatabaseSource.PhysicalChannelNumber;

    /// <inheritdoc />
    public string Username { get; set; } = "admin";

    /// <inheritdoc />
    public string Password { get; set; } = string.Empty;
}
