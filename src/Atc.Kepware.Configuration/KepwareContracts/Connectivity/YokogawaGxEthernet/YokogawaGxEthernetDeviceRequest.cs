namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.YokogawaGxEthernet;

/// <summary>
/// Yokogawa GX Ethernet device request - Kepware format.
/// </summary>
internal sealed class YokogawaGxEthernetDeviceRequest : DeviceRequestBase, IYokogawaGxEthernetDeviceRequest
{
    public YokogawaGxEthernetDeviceRequest()
        : base(DriverType.YokogawaGxEthernet)
    {
    }

    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public YokogawaGxEthernetModel Model { get; set; } = YokogawaGxEthernetModel.Gx;

    [JsonPropertyName("yokogawa_gx.DEVICE_SPECIAL_DATA_HANDLING")]
    public YokogawaGxEthernetDataHandling DataHandling { get; set; } = YokogawaGxEthernetDataHandling.None;

    [JsonPropertyName("yokogawa_gx.DEVICE_POLLING_INTERVAL_MS")]
    public int PollingInterval { get; set; } = 1000;

    [JsonPropertyName("yokogawa_gx.DEVICE_START_MATH")]
    public bool StartMath { get; set; }

    [JsonPropertyName("yokogawa_gx.DEVICE_DATE_AND_TIME")]
    public YokogawaGxEthernetDateTimeSource DateAndTime { get; set; } = YokogawaGxEthernetDateTimeSource.DeviceTime;

    [JsonPropertyName("yokogawa_gx.DEVICE_DATE_FORMAT")]
    public YokogawaGxEthernetDateFormat DateFormat { get; set; } = YokogawaGxEthernetDateFormat.MmDdYy;

    [JsonPropertyName("yokogawa_gx.DEVICE_SET_CLOCK")]
    public bool SetClock { get; set; }

    [JsonPropertyName("yokogawa_gx.DEVICE_GENERATE_TAG_DATABASE_USING")]
    public YokogawaGxEthernetTagDatabaseSource TagDatabaseSource { get; set; } = YokogawaGxEthernetTagDatabaseSource.PhysicalChannelNumber;

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DataHandling)}: {DataHandling}, {nameof(PollingInterval)}: {PollingInterval}, {nameof(StartMath)}: {StartMath}, {nameof(DateAndTime)}: {DateAndTime}, {nameof(DateFormat)}: {DateFormat}, {nameof(SetClock)}: {SetClock}, {nameof(TagDatabaseSource)}: {TagDatabaseSource}";
}
