namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.YokogawaMxEthernet;

/// <summary>
/// Yokogawa MX Ethernet device request.
/// </summary>
public class YokogawaMxEthernetDeviceRequest : DeviceRequestBase, IYokogawaMxEthernetDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="YokogawaMxEthernetDeviceRequest"/> class.
    /// </summary>
    public YokogawaMxEthernetDeviceRequest()
        : base(DriverType.YokogawaMxEthernet)
    {
    }

    /// <inheritdoc />
    public YokogawaMxEthernetModel Model { get; set; } = YokogawaMxEthernetModel.Mx100;

    /// <inheritdoc />
    public bool StopMxOnShutdown { get; set; }

    /// <inheritdoc />
    public YokogawaMxEthernetDataHandling DataHandling { get; set; } = YokogawaMxEthernetDataHandling.MinusInfPlusInf;

    /// <inheritdoc />
    public YokogawaMxEthernetDateTimeSource DateAndTime { get; set; } = YokogawaMxEthernetDateTimeSource.DeviceTime;

    /// <inheritdoc />
    public YokogawaMxEthernetDateFormat DateFormat { get; set; } = YokogawaMxEthernetDateFormat.MmDdYy;
}