namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.YokogawaGxEthernet;

/// <summary>
/// Yokogawa GX Ethernet device.
/// </summary>
public class YokogawaGxEthernetDevice : DeviceBase, IYokogawaGxEthernetDevice
{
    /// <inheritdoc />
    public YokogawaGxEthernetModel Model { get; set; } = YokogawaGxEthernetModel.Gx;

    /// <inheritdoc />
    public YokogawaGxEthernetDataHandling DataHandling { get; set; } = YokogawaGxEthernetDataHandling.None;

    /// <inheritdoc />
    public int PollingInterval { get; set; } = 1000;

    /// <inheritdoc />
    public bool StartMath { get; set; }

    /// <inheritdoc />
    public YokogawaGxEthernetDateTimeSource DateAndTime { get; set; } = YokogawaGxEthernetDateTimeSource.DeviceTime;

    /// <inheritdoc />
    public YokogawaGxEthernetDateFormat DateFormat { get; set; } = YokogawaGxEthernetDateFormat.MmDdYy;

    /// <inheritdoc />
    public bool SetClock { get; set; }

    /// <inheritdoc />
    public YokogawaGxEthernetTagDatabaseSource TagDatabaseSource { get; set; } = YokogawaGxEthernetTagDatabaseSource.PhysicalChannelNumber;
}
