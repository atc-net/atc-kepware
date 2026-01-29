namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.YokogawaDxpEthernet;

/// <summary>
/// Yokogawa DXP Ethernet device - Kepware format.
/// </summary>
internal sealed class YokogawaDxpEthernetDevice : DeviceBase, IYokogawaDxpEthernetDevice
{
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public YokogawaDxpEthernetModel Model { get; set; } = YokogawaDxpEthernetModel.Dxp100;

    [JsonPropertyName("yokogawa_dxp.DEVICE_SPECIAL_DATA_HANDLING")]
    public YokogawaDxpEthernetDataHandling DataHandling { get; set; } = YokogawaDxpEthernetDataHandling.None;

    [JsonPropertyName("yokogawa_dxp.DEVICE_POLLING_INTERVAL_MS")]
    public int PollingInterval { get; set; } = 1000;

    [JsonPropertyName("yokogawa_dxp.DEVICE_START_MATH")]
    public bool StartMath { get; set; }

    [JsonPropertyName("yokogawa_dxp.DEVICE_DATE_AND_TIME")]
    public YokogawaDxpEthernetDateTimeSource DateAndTime { get; set; } = YokogawaDxpEthernetDateTimeSource.DeviceTime;

    [JsonPropertyName("yokogawa_dxp.DEVICE_DATE_FORMAT")]
    public YokogawaDxpEthernetDateFormat DateFormat { get; set; } = YokogawaDxpEthernetDateFormat.MmDdYy;

    [JsonPropertyName("yokogawa_dxp.DEVICE_SET_CLOCK")]
    public bool SetClock { get; set; }

    [JsonPropertyName("yokogawa_dxp.DEVICE_GENERATE_TAG_DATABASE_USING")]
    public YokogawaDxpEthernetTagDatabaseSource TagDatabaseSource { get; set; } = YokogawaDxpEthernetTagDatabaseSource.PhysicalChannelNumber;

    [JsonPropertyName("yokogawa_dxp.DEVICE_USERNAME")]
    public string Username { get; set; } = "user";

    [JsonPropertyName("yokogawa_dxp.DEVICE_PASSWORD")]
    public string Password { get; set; } = string.Empty;

    [JsonPropertyName("yokogawa_dxp.DEVICE_USER_ID")]
    public string UserId { get; set; } = string.Empty;

    [JsonPropertyName("yokogawa_dxp.DEVICE_USER_FUNCTION")]
    public YokogawaDxpEthernetUserFunction UserFunction { get; set; } = YokogawaDxpEthernetUserFunction.Monitor;

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DataHandling)}: {DataHandling}, {nameof(PollingInterval)}: {PollingInterval}, {nameof(StartMath)}: {StartMath}, {nameof(DateAndTime)}: {DateAndTime}, {nameof(DateFormat)}: {DateFormat}, {nameof(SetClock)}: {SetClock}, {nameof(TagDatabaseSource)}: {TagDatabaseSource}, {nameof(Username)}: {Username}";
}