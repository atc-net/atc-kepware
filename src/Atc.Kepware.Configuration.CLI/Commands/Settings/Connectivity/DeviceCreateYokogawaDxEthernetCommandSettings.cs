namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateYokogawaDxEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--model")]
    [Description("Device model")]
    [DefaultValue(YokogawaDxEthernetModel.Dx102)]
    public YokogawaDxEthernetModel Model { get; init; } = YokogawaDxEthernetModel.Dx102;

    [CommandOption("--data-handling")]
    [Description("Data handling for out of range and error conditions")]
    [DefaultValue(YokogawaDxEthernetDataHandling.None)]
    public YokogawaDxEthernetDataHandling DataHandling { get; init; } = YokogawaDxEthernetDataHandling.None;

    [CommandOption("--polling-interval")]
    [Description("Polling interval in milliseconds (10-30000)")]
    [DefaultValue(1000)]
    public int PollingInterval { get; init; } = 1000;

    [CommandOption("--start-math")]
    [Description("Start math computation on communication startup")]
    [DefaultValue(false)]
    public bool StartMath { get; init; }

    [CommandOption("--date-and-time")]
    [Description("Source of the date and time data")]
    [DefaultValue(YokogawaDxEthernetDateTimeSource.DeviceTime)]
    public YokogawaDxEthernetDateTimeSource DateAndTime { get; init; } = YokogawaDxEthernetDateTimeSource.DeviceTime;

    [CommandOption("--date-format")]
    [Description("Date format for the return string")]
    [DefaultValue(YokogawaDxEthernetDateFormat.MmDdYy)]
    public YokogawaDxEthernetDateFormat DateFormat { get; init; } = YokogawaDxEthernetDateFormat.MmDdYy;

    [CommandOption("--set-clock")]
    [Description("Set device clock on communication startup")]
    [DefaultValue(false)]
    public bool SetClock { get; init; }

    [CommandOption("--tag-database-source")]
    [Description("Tag database generation source")]
    [DefaultValue(YokogawaDxEthernetTagDatabaseSource.PhysicalChannelNumber)]
    public YokogawaDxEthernetTagDatabaseSource TagDatabaseSource { get; init; } = YokogawaDxEthernetTagDatabaseSource.PhysicalChannelNumber;

    [CommandOption("--as1-security-option")]
    [Description("Enable AS1 security option (enables Username/Password)")]
    [DefaultValue(false)]
    public bool As1SecurityOption { get; init; }

    [CommandOption("--username")]
    [Description("Username for AS1 security (max 256 characters)")]
    [DefaultValue("admin")]
    public string Username { get; init; } = "admin";

    [CommandOption("--device-password")]
    [Description("Password for AS1 security (max 256 characters)")]
    [DefaultValue("0")]
    public string DevicePassword { get; init; } = "0";

    [CommandOption("--user-id")]
    [Description("User ID for AS1 security")]
    [DefaultValue("")]
    public string UserId { get; init; } = string.Empty;

    [CommandOption("--user-function")]
    [Description("User function for AS1 security")]
    [DefaultValue(YokogawaDxEthernetUserFunction.Monitor)]
    public YokogawaDxEthernetUserFunction UserFunction { get; init; } = YokogawaDxEthernetUserFunction.Monitor;
}