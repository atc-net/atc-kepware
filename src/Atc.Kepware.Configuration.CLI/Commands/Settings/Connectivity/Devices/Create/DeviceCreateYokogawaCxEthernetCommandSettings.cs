namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Devices.Create;

public class DeviceCreateYokogawaCxEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--model")]
    [Description("Device model")]
    [DefaultValue(YokogawaCxEthernetModel.Cx1006)]
    public YokogawaCxEthernetModel Model { get; init; } = YokogawaCxEthernetModel.Cx1006;

    [CommandOption("--data-handling")]
    [Description("Data handling for out of range and error conditions")]
    [DefaultValue(YokogawaCxEthernetDataHandling.None)]
    public YokogawaCxEthernetDataHandling DataHandling { get; init; } = YokogawaCxEthernetDataHandling.None;

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
    [DefaultValue(YokogawaCxEthernetDateTimeSource.DeviceTime)]
    public YokogawaCxEthernetDateTimeSource DateAndTime { get; init; } = YokogawaCxEthernetDateTimeSource.DeviceTime;

    [CommandOption("--date-format")]
    [Description("Date format for the return string")]
    [DefaultValue(YokogawaCxEthernetDateFormat.MmDdYy)]
    public YokogawaCxEthernetDateFormat DateFormat { get; init; } = YokogawaCxEthernetDateFormat.MmDdYy;

    [CommandOption("--set-clock")]
    [Description("Set device clock on communication startup")]
    [DefaultValue(false)]
    public bool SetClock { get; init; }

    [CommandOption("--tag-database-source")]
    [Description("Tag database generation source")]
    [DefaultValue(YokogawaCxEthernetTagDatabaseSource.PhysicalChannelNumber)]
    public YokogawaCxEthernetTagDatabaseSource TagDatabaseSource { get; init; } = YokogawaCxEthernetTagDatabaseSource.PhysicalChannelNumber;

    [CommandOption("--username")]
    [Description("Username for device login")]
    [DefaultValue("admin")]
    public string Username { get; init; } = "admin";

    [CommandOption("--device-password")]
    [Description("Password for device login")]
    [DefaultValue("")]
    public string DevicePassword { get; init; } = string.Empty;
}