namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.YokogawaDarwinEthernet;

/// <summary>
/// Yokogawa Darwin Ethernet device request.
/// </summary>
public class YokogawaDarwinEthernetDeviceRequest : DeviceRequestBase, IYokogawaDarwinEthernetDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="YokogawaDarwinEthernetDeviceRequest"/> class.
    /// </summary>
    public YokogawaDarwinEthernetDeviceRequest()
        : base(DriverType.YokogawaDarwinEthernet)
    {
    }

    /// <inheritdoc />
    public YokogawaDarwinEthernetModel Model { get; set; } = YokogawaDarwinEthernetModel.Da100_1;

    /// <inheritdoc />
    public YokogawaDarwinEthernetDataHandling DataHandling { get; set; } = YokogawaDarwinEthernetDataHandling.None;

    /// <inheritdoc />
    public int PollingInterval { get; set; } = 1000;

    /// <inheritdoc />
    public bool StartMath { get; set; }

    /// <inheritdoc />
    public YokogawaDarwinEthernetDateTimeSource DateAndTime { get; set; } = YokogawaDarwinEthernetDateTimeSource.DeviceTime;

    /// <inheritdoc />
    public YokogawaDarwinEthernetDateFormat DateFormat { get; set; } = YokogawaDarwinEthernetDateFormat.MmDdYy;

    /// <inheritdoc />
    public bool SetClock { get; set; }

    /// <inheritdoc />
    public YokogawaDarwinEthernetTagDatabaseSource TagDatabaseSource { get; set; } = YokogawaDarwinEthernetTagDatabaseSource.PhysicalChannelNumber;
}