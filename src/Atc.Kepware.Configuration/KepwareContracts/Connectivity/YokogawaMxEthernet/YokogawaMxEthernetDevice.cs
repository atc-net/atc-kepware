namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.YokogawaMxEthernet;

/// <summary>
/// Yokogawa MX Ethernet device - Kepware format.
/// </summary>
internal sealed class YokogawaMxEthernetDevice : DeviceBase, IYokogawaMxEthernetDevice
{
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public YokogawaMxEthernetModel Model { get; set; } = YokogawaMxEthernetModel.Mx100;

    [JsonPropertyName("yokogawa_mx.DEVICE_SPECIAL_DATA_HANDLING")]
    public YokogawaMxEthernetDataHandling DataHandling { get; set; } = YokogawaMxEthernetDataHandling.None;

    [JsonPropertyName("yokogawa_mx.DEVICE_POLLING_INTERVAL_MS")]
    public int PollingInterval { get; set; } = 1000;

    [JsonPropertyName("yokogawa_mx.DEVICE_START_MATH")]
    public bool StartMath { get; set; }

    [JsonPropertyName("yokogawa_mx.DEVICE_DATE_AND_TIME")]
    public YokogawaMxEthernetDateTimeSource DateAndTime { get; set; } = YokogawaMxEthernetDateTimeSource.DeviceTime;

    [JsonPropertyName("yokogawa_mx.DEVICE_DATE_FORMAT")]
    public YokogawaMxEthernetDateFormat DateFormat { get; set; } = YokogawaMxEthernetDateFormat.MmDdYy;

    [JsonPropertyName("yokogawa_mx.DEVICE_SET_CLOCK")]
    public bool SetClock { get; set; }

    [JsonPropertyName("yokogawa_mx.DEVICE_GENERATE_TAG_DATABASE_USING")]
    public YokogawaMxEthernetTagDatabaseSource TagDatabaseSource { get; set; } = YokogawaMxEthernetTagDatabaseSource.PhysicalChannelNumber;

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DataHandling)}: {DataHandling}, {nameof(PollingInterval)}: {PollingInterval}, {nameof(StartMath)}: {StartMath}, {nameof(DateAndTime)}: {DateAndTime}, {nameof(DateFormat)}: {DateFormat}, {nameof(SetClock)}: {SetClock}, {nameof(TagDatabaseSource)}: {TagDatabaseSource}";
}
