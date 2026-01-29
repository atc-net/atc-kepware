namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.YokogawaMxEthernet;

/// <summary>
/// Yokogawa MX Ethernet device - Kepware format.
/// </summary>
internal sealed class YokogawaMxEthernetDevice : DeviceBase, IYokogawaMxEthernetDevice
{
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public YokogawaMxEthernetModel Model { get; set; } = YokogawaMxEthernetModel.Mx100;

    [JsonPropertyName("yokogawa_mx.DEVICE_STOP_MX_ON_SHUTDOWN")]
    public bool StopMxOnShutdown { get; set; }

    [JsonPropertyName("yokogawa_mx.DEVICE_SPECIAL_DATA_HANDLING")]
    public YokogawaMxEthernetDataHandling DataHandling { get; set; } = YokogawaMxEthernetDataHandling.MinusInfPlusInf;

    [JsonPropertyName("yokogawa_mx.DEVICE_DATE_AND_TIME")]
    public YokogawaMxEthernetDateTimeSource DateAndTime { get; set; } = YokogawaMxEthernetDateTimeSource.DeviceTime;

    [JsonPropertyName("yokogawa_mx.DEVICE_DATE_FORMAT")]
    public YokogawaMxEthernetDateFormat DateFormat { get; set; } = YokogawaMxEthernetDateFormat.MmDdYy;

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(StopMxOnShutdown)}: {StopMxOnShutdown}, {nameof(DataHandling)}: {DataHandling}, {nameof(DateAndTime)}: {DateAndTime}, {nameof(DateFormat)}: {DateFormat}";
}
