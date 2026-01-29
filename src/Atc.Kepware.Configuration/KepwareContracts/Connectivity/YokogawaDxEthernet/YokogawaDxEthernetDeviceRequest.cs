namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.YokogawaDxEthernet;

/// <summary>
/// Yokogawa DX Ethernet device request.
/// </summary>
internal sealed class YokogawaDxEthernetDeviceRequest : DeviceRequestBase, IYokogawaDxEthernetDeviceRequest
{
    public YokogawaDxEthernetDeviceRequest()
        : base(DriverType.YokogawaDxEthernet)
    {
    }

    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public YokogawaDxEthernetModel Model { get; set; } = YokogawaDxEthernetModel.Dx102;

    [JsonPropertyName("yokogawa_dx.DEVICE_SPECIAL_DATA_HANDLING")]
    public YokogawaDxEthernetDataHandling DataHandling { get; set; } = YokogawaDxEthernetDataHandling.None;

    [JsonPropertyName("yokogawa_dx.DEVICE_POLLING_INTERVAL_MS")]
    public int PollingInterval { get; set; } = 1000;

    [JsonPropertyName("yokogawa_dx.DEVICE_START_MATH")]
    public bool StartMath { get; set; }

    [JsonPropertyName("yokogawa_dx.DEVICE_DATE_AND_TIME")]
    public YokogawaDxEthernetDateTimeSource DateAndTime { get; set; } = YokogawaDxEthernetDateTimeSource.DeviceTime;

    [JsonPropertyName("yokogawa_dx.DEVICE_DATE_FORMAT")]
    public YokogawaDxEthernetDateFormat DateFormat { get; set; } = YokogawaDxEthernetDateFormat.MmDdYy;

    [JsonPropertyName("yokogawa_dx.DEVICE_SET_CLOCK")]
    public bool SetClock { get; set; }

    [JsonPropertyName("yokogawa_dx.DEVICE_GENERATE_TAG_DATABASE_USING")]
    public YokogawaDxEthernetTagDatabaseSource TagDatabaseSource { get; set; } = YokogawaDxEthernetTagDatabaseSource.PhysicalChannelNumber;

    [JsonPropertyName("yokogawa_dx.DEVICE_AS1_SECURITY_OPTION")]
    public bool As1SecurityOption { get; set; }

    [JsonPropertyName("yokogawa_dx.DEVICE_USERNAME")]
    public string Username { get; set; } = "admin";

    [JsonPropertyName("yokogawa_dx.DEVICE_PASSWORD")]
    public string Password { get; set; } = "0";

    [JsonPropertyName("yokogawa_dx.DEVICE_USER_ID")]
    public string UserId { get; set; } = string.Empty;

    [JsonPropertyName("yokogawa_dx.DEVICE_USER_FUNCTION")]
    public YokogawaDxEthernetUserFunction UserFunction { get; set; } = YokogawaDxEthernetUserFunction.Monitor;

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DataHandling)}: {DataHandling}, {nameof(PollingInterval)}: {PollingInterval}, {nameof(StartMath)}: {StartMath}, {nameof(DateAndTime)}: {DateAndTime}, {nameof(DateFormat)}: {DateFormat}, {nameof(SetClock)}: {SetClock}, {nameof(TagDatabaseSource)}: {TagDatabaseSource}, {nameof(As1SecurityOption)}: {As1SecurityOption}, {nameof(Username)}: {Username}, {nameof(UserId)}: {UserId}, {nameof(UserFunction)}: {UserFunction}";
}