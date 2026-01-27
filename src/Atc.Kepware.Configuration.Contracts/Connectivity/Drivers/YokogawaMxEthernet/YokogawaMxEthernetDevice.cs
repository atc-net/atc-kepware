namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.YokogawaMxEthernet;

/// <summary>
/// Yokogawa MX Ethernet device.
/// </summary>
public class YokogawaMxEthernetDevice : DeviceBase, IYokogawaMxEthernetDevice
{
    /// <inheritdoc />
    public YokogawaMxEthernetModel Model { get; set; } = YokogawaMxEthernetModel.Mx100;

    /// <inheritdoc />
    public YokogawaMxEthernetDataHandling DataHandling { get; set; } = YokogawaMxEthernetDataHandling.None;

    /// <inheritdoc />
    public int PollingInterval { get; set; } = 1000;

    /// <inheritdoc />
    public bool StartMath { get; set; }

    /// <inheritdoc />
    public YokogawaMxEthernetDateTimeSource DateAndTime { get; set; } = YokogawaMxEthernetDateTimeSource.DeviceTime;

    /// <inheritdoc />
    public YokogawaMxEthernetDateFormat DateFormat { get; set; } = YokogawaMxEthernetDateFormat.MmDdYy;

    /// <inheritdoc />
    public bool SetClock { get; set; }

    /// <inheritdoc />
    public YokogawaMxEthernetTagDatabaseSource TagDatabaseSource { get; set; } = YokogawaMxEthernetTagDatabaseSource.PhysicalChannelNumber;
}
