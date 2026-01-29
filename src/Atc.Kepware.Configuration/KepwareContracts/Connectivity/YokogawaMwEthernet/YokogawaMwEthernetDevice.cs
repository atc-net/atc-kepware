namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.YokogawaMwEthernet;

/// <summary>
/// Yokogawa MW Ethernet device.
/// </summary>
internal sealed class YokogawaMwEthernetDevice : DeviceBase, IYokogawaMwEthernetDevice
{
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public YokogawaMwEthernetModel Model { get; set; } = YokogawaMwEthernetModel.Mw100;

    [JsonPropertyName("yokogawa_mw.DEVICE_DATA_HANDLING")]
    public YokogawaMwEthernetDataHandling DataHandling { get; set; } = YokogawaMwEthernetDataHandling.None;

    [JsonPropertyName("yokogawa_mw.DEVICE_START_MATH")]
    public bool StartMath { get; set; }

    [JsonPropertyName("yokogawa_mw.DEVICE_START_MEASURING")]
    public bool StartMeasuring { get; set; }

    [JsonPropertyName("yokogawa_mw.DEVICE_DATE_AND_TIME")]
    public YokogawaMwEthernetDateTimeSource DateAndTime { get; set; } = YokogawaMwEthernetDateTimeSource.DeviceTime;

    [JsonPropertyName("yokogawa_mw.DEVICE_DATE_FORMAT")]
    public YokogawaMwEthernetDateFormat DateFormat { get; set; } = YokogawaMwEthernetDateFormat.MmDdYy;

    [JsonPropertyName("yokogawa_mw.DEVICE_SET_CLOCK_WHEN_START")]
    public bool SetClock { get; set; }

    [JsonPropertyName("yokogawa_mw.DEVICE_GENERATE_TAG_DATABASE_USING")]
    public YokogawaMwEthernetTagDatabaseSource TagDatabaseSource { get; set; } = YokogawaMwEthernetTagDatabaseSource.PhysicalChannelNumber;

    [JsonPropertyName("yokogawa_mw.DEVICE_USERNAME")]
    public string Username { get; set; } = "admin";

    [JsonPropertyName("yokogawa_mw.DEVICE_PASSWORD")]
    public string Password { get; set; } = string.Empty;

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DataHandling)}: {DataHandling}, {nameof(StartMath)}: {StartMath}, {nameof(StartMeasuring)}: {StartMeasuring}, {nameof(DateAndTime)}: {DateAndTime}, {nameof(DateFormat)}: {DateFormat}, {nameof(SetClock)}: {SetClock}, {nameof(TagDatabaseSource)}: {TagDatabaseSource}, {nameof(Username)}: {Username}";
}