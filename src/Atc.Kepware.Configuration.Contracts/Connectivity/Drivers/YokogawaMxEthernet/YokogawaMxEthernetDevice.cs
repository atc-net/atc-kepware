namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.YokogawaMxEthernet;

/// <summary>
/// Yokogawa MX Ethernet device.
/// </summary>
public class YokogawaMxEthernetDevice : DeviceBase, IYokogawaMxEthernetDevice
{
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