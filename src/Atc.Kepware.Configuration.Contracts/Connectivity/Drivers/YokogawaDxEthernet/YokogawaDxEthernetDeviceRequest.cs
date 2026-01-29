namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.YokogawaDxEthernet;

/// <summary>
/// Yokogawa DX Ethernet device request.
/// </summary>
public class YokogawaDxEthernetDeviceRequest : DeviceRequestBase, IYokogawaDxEthernetDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="YokogawaDxEthernetDeviceRequest"/> class.
    /// </summary>
    public YokogawaDxEthernetDeviceRequest()
        : base(DriverType.YokogawaDxEthernet)
    {
    }

    /// <inheritdoc />
    public YokogawaDxEthernetModel Model { get; set; } = YokogawaDxEthernetModel.Dx102;

    /// <inheritdoc />
    public YokogawaDxEthernetDataHandling DataHandling { get; set; } = YokogawaDxEthernetDataHandling.None;

    /// <inheritdoc />
    public int PollingInterval { get; set; } = 1000;

    /// <inheritdoc />
    public bool StartMath { get; set; }

    /// <inheritdoc />
    public YokogawaDxEthernetDateTimeSource DateAndTime { get; set; } = YokogawaDxEthernetDateTimeSource.DeviceTime;

    /// <inheritdoc />
    public YokogawaDxEthernetDateFormat DateFormat { get; set; } = YokogawaDxEthernetDateFormat.MmDdYy;

    /// <inheritdoc />
    public bool SetClock { get; set; }

    /// <inheritdoc />
    public YokogawaDxEthernetTagDatabaseSource TagDatabaseSource { get; set; } = YokogawaDxEthernetTagDatabaseSource.PhysicalChannelNumber;

    /// <inheritdoc />
    public bool As1SecurityOption { get; set; }

    /// <inheritdoc />
    public string Username { get; set; } = "admin";

    /// <inheritdoc />
    public string Password { get; set; } = "0";

    /// <inheritdoc />
    public string UserId { get; set; } = string.Empty;

    /// <inheritdoc />
    public YokogawaDxEthernetUserFunction UserFunction { get; set; } = YokogawaDxEthernetUserFunction.Monitor;
}