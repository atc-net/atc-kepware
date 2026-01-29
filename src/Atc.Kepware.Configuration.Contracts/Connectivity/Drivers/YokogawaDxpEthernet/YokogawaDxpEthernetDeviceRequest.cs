namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.YokogawaDxpEthernet;

/// <summary>
/// Yokogawa DXP Ethernet device request.
/// </summary>
public class YokogawaDxpEthernetDeviceRequest : DeviceRequestBase, IYokogawaDxpEthernetDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="YokogawaDxpEthernetDeviceRequest"/> class.
    /// </summary>
    public YokogawaDxpEthernetDeviceRequest()
        : base(DriverType.YokogawaDxpEthernet)
    {
    }

    /// <inheritdoc />
    public YokogawaDxpEthernetModel Model { get; set; } = YokogawaDxpEthernetModel.Dxp100;

    /// <inheritdoc />
    public YokogawaDxpEthernetDataHandling DataHandling { get; set; } = YokogawaDxpEthernetDataHandling.None;

    /// <inheritdoc />
    public int PollingInterval { get; set; } = 1000;

    /// <inheritdoc />
    public bool StartMath { get; set; }

    /// <inheritdoc />
    public YokogawaDxpEthernetDateTimeSource DateAndTime { get; set; } = YokogawaDxpEthernetDateTimeSource.DeviceTime;

    /// <inheritdoc />
    public YokogawaDxpEthernetDateFormat DateFormat { get; set; } = YokogawaDxpEthernetDateFormat.MmDdYy;

    /// <inheritdoc />
    public bool SetClock { get; set; }

    /// <inheritdoc />
    public YokogawaDxpEthernetTagDatabaseSource TagDatabaseSource { get; set; } = YokogawaDxpEthernetTagDatabaseSource.PhysicalChannelNumber;

    /// <inheritdoc />
    public string Username { get; set; } = "user";

    /// <inheritdoc />
    public string Password { get; set; } = string.Empty;

    /// <inheritdoc />
    public string UserId { get; set; } = string.Empty;

    /// <inheritdoc />
    public YokogawaDxpEthernetUserFunction UserFunction { get; set; } = YokogawaDxpEthernetUserFunction.Monitor;
}
