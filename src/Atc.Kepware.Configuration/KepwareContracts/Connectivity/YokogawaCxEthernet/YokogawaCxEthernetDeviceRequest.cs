namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.YokogawaCxEthernet;

/// <summary>
/// Yokogawa CX Ethernet device request.
/// </summary>
internal sealed class YokogawaCxEthernetDeviceRequest : DeviceRequestBase, IYokogawaCxEthernetDeviceRequest
{
    public YokogawaCxEthernetDeviceRequest()
        : base(DriverType.YokogawaCxEthernet)
    {
    }

    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public YokogawaCxEthernetModel Model { get; set; } = YokogawaCxEthernetModel.Cx1006;

    [JsonPropertyName("yokogawa_cx.DEVICE_DATA_HANDLING")]
    public YokogawaCxEthernetDataHandling DataHandling { get; set; } = YokogawaCxEthernetDataHandling.None;

    [JsonPropertyName("yokogawa_cx.DEVICE_POLLING_INTERVAL_MS")]
    public int PollingInterval { get; set; } = 1000;

    [JsonPropertyName("yokogawa_cx.DEVICE_START_MATH")]
    public bool StartMath { get; set; }

    [JsonPropertyName("yokogawa_cx.DEVICE_DATE_AND_TIME")]
    public YokogawaCxEthernetDateTimeSource DateAndTime { get; set; } = YokogawaCxEthernetDateTimeSource.DeviceTime;

    [JsonPropertyName("yokogawa_cx.DEVICE_DATE_FORMAT")]
    public YokogawaCxEthernetDateFormat DateFormat { get; set; } = YokogawaCxEthernetDateFormat.MmDdYy;

    [JsonPropertyName("yokogawa_cx.DEVICE_SET_CLOCK")]
    public bool SetClock { get; set; }

    [JsonPropertyName("yokogawa_cx.DEVICE_GENERATE_TAG_DATABASE_USING")]
    public YokogawaCxEthernetTagDatabaseSource TagDatabaseSource { get; set; } = YokogawaCxEthernetTagDatabaseSource.PhysicalChannelNumber;

    [JsonPropertyName("yokogawa_cx.DEVICE_USERNAME")]
    public string Username { get; set; } = "admin";

    [JsonPropertyName("yokogawa_cx.DEVICE_PASSWORD")]
    public string Password { get; set; } = string.Empty;

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DataHandling)}: {DataHandling}, {nameof(PollingInterval)}: {PollingInterval}, {nameof(StartMath)}: {StartMath}, {nameof(DateAndTime)}: {DateAndTime}, {nameof(DateFormat)}: {DateFormat}, {nameof(SetClock)}: {SetClock}, {nameof(TagDatabaseSource)}: {TagDatabaseSource}, {nameof(Username)}: {Username}";
}