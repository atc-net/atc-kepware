namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.YokogawaMwEthernet;

/// <summary>
/// Yokogawa MW Ethernet device request.
/// </summary>
public class YokogawaMwEthernetDeviceRequest : DeviceRequestBase, IYokogawaMwEthernetDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="YokogawaMwEthernetDeviceRequest"/> class.
    /// </summary>
    public YokogawaMwEthernetDeviceRequest()
        : base(DriverType.YokogawaMwEthernet)
    {
    }

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
