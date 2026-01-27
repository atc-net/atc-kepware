namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.YokogawaMwEthernet;

/// <summary>
/// Yokogawa MW Ethernet device - Kepware format.
/// </summary>
internal sealed class YokogawaMwEthernetDevice : DeviceBase, IYokogawaMwEthernetDevice
{
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public YokogawaMwEthernetModel Model { get; set; } = YokogawaMwEthernetModel.Mw100;

    [JsonPropertyName("yokogawa_mw.DEVICE_SPECIAL_DATA_HANDLING")]
    public YokogawaMwEthernetDataHandling DataHandling { get; set; } = YokogawaMwEthernetDataHandling.None;

    [JsonPropertyName("yokogawa_mw.DEVICE_POLLING_INTERVAL_MS")]
    public int PollingInterval { get; set; } = 1000;

    [JsonPropertyName("yokogawa_mw.DEVICE_START_MATH")]
    public bool StartMath { get; set; }

    [JsonPropertyName("yokogawa_mw.DEVICE_DATE_AND_TIME")]
    public YokogawaMwEthernetDateTimeSource DateAndTime { get; set; } = YokogawaMwEthernetDateTimeSource.DeviceTime;

    [JsonPropertyName("yokogawa_mw.DEVICE_DATE_FORMAT")]
    public YokogawaMwEthernetDateFormat DateFormat { get; set; } = YokogawaMwEthernetDateFormat.MmDdYy;

    [JsonPropertyName("yokogawa_mw.DEVICE_SET_CLOCK")]
    public bool SetClock { get; set; }

    [JsonPropertyName("yokogawa_mw.DEVICE_GENERATE_TAG_DATABASE_USING")]
    public YokogawaMwEthernetTagDatabaseSource TagDatabaseSource { get; set; } = YokogawaMwEthernetTagDatabaseSource.PhysicalChannelNumber;

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DataHandling)}: {DataHandling}, {nameof(PollingInterval)}: {PollingInterval}, {nameof(StartMath)}: {StartMath}, {nameof(DateAndTime)}: {DateAndTime}, {nameof(DateFormat)}: {DateFormat}, {nameof(SetClock)}: {SetClock}, {nameof(TagDatabaseSource)}: {TagDatabaseSource}";
}
