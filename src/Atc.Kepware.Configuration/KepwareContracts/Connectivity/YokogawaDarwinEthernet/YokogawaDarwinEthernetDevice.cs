namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.YokogawaDarwinEthernet;

/// <summary>
/// Yokogawa Darwin Ethernet device.
/// </summary>
internal sealed class YokogawaDarwinEthernetDevice : DeviceBase, IYokogawaDarwinEthernetDevice
{
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public YokogawaDarwinEthernetModel Model { get; set; } = YokogawaDarwinEthernetModel.Da100_1;

    [JsonPropertyName("yokogawa_darwin.DEVICE_SPECIAL_DATA_HANDLING")]
    public YokogawaDarwinEthernetDataHandling DataHandling { get; set; } = YokogawaDarwinEthernetDataHandling.None;

    [JsonPropertyName("yokogawa_darwin.DEVICE_POLLING_INTERVAL_MS")]
    public int PollingInterval { get; set; } = 1000;

    [JsonPropertyName("yokogawa_darwin.DEVICE_START_MATH")]
    public bool StartMath { get; set; }

    [JsonPropertyName("yokogawa_darwin.DEVICE_DATE_AND_TIME")]
    public YokogawaDarwinEthernetDateTimeSource DateAndTime { get; set; } = YokogawaDarwinEthernetDateTimeSource.DeviceTime;

    [JsonPropertyName("yokogawa_darwin.DEVICE_DATE_FORMAT")]
    public YokogawaDarwinEthernetDateFormat DateFormat { get; set; } = YokogawaDarwinEthernetDateFormat.MmDdYy;

    [JsonPropertyName("yokogawa_darwin.DEVICE_SET_CLOCK")]
    public bool SetClock { get; set; }

    [JsonPropertyName("yokogawa_darwin.DEVICE_GENERATE_TAG_DATABASE_USING")]
    public YokogawaDarwinEthernetTagDatabaseSource TagDatabaseSource { get; set; } = YokogawaDarwinEthernetTagDatabaseSource.PhysicalChannelNumber;

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DataHandling)}: {DataHandling}, {nameof(PollingInterval)}: {PollingInterval}, {nameof(StartMath)}: {StartMath}, {nameof(DateAndTime)}: {DateAndTime}, {nameof(DateFormat)}: {DateFormat}, {nameof(SetClock)}: {SetClock}, {nameof(TagDatabaseSource)}: {TagDatabaseSource}";
}