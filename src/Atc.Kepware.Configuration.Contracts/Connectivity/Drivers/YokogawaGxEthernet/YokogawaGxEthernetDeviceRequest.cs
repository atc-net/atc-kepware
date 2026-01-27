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
