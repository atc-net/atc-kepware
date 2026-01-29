namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.YokogawaMwEthernet;

/// <summary>
/// Yokogawa MW Ethernet device.
/// </summary>
public class YokogawaMwEthernetDevice : DeviceBase, IYokogawaMwEthernetDevice
{
    /// <inheritdoc />
    public YokogawaMwEthernetModel Model { get; set; } = YokogawaMwEthernetModel.Mw100;

    /// <inheritdoc />
    public YokogawaMwEthernetDataHandling DataHandling { get; set; } = YokogawaMwEthernetDataHandling.None;

    /// <inheritdoc />
    public bool StartMath { get; set; }

    /// <inheritdoc />
    public bool StartMeasuring { get; set; }

    /// <inheritdoc />
    public YokogawaMwEthernetDateTimeSource DateAndTime { get; set; } = YokogawaMwEthernetDateTimeSource.DeviceTime;

    /// <inheritdoc />
    public YokogawaMwEthernetDateFormat DateFormat { get; set; } = YokogawaMwEthernetDateFormat.MmDdYy;

    /// <inheritdoc />
    public bool SetClock { get; set; }

    /// <inheritdoc />
    public YokogawaMwEthernetTagDatabaseSource TagDatabaseSource { get; set; } = YokogawaMwEthernetTagDatabaseSource.PhysicalChannelNumber;

    /// <inheritdoc />
    public string Username { get; set; } = "admin";

    /// <inheritdoc />
    public string Password { get; set; } = string.Empty;
}