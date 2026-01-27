namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateYokogawaMxEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--model")]
    [Description("Device model")]
    [DefaultValue(YokogawaMxEthernetModel.Mx100)]
    public YokogawaMxEthernetModel Model { get; init; } = YokogawaMxEthernetModel.Mx100;

    [CommandOption("--data-handling")]
    [Description("Data handling for out of range and error conditions")]
    [DefaultValue(YokogawaMxEthernetDataHandling.None)]
    public YokogawaMxEthernetDataHandling DataHandling { get; init; } = YokogawaMxEthernetDataHandling.None;

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
    [DefaultValue(YokogawaMxEthernetDateTimeSource.DeviceTime)]
    public YokogawaMxEthernetDateTimeSource DateAndTime { get; init; } = YokogawaMxEthernetDateTimeSource.DeviceTime;

    [CommandOption("--date-format")]
    [Description("Date format for the return string")]
    [DefaultValue(YokogawaMxEthernetDateFormat.MmDdYy)]
    public YokogawaMxEthernetDateFormat DateFormat { get; init; } = YokogawaMxEthernetDateFormat.MmDdYy;

    [CommandOption("--set-clock")]
    [Description("Set device clock on communication startup")]
    [DefaultValue(false)]
    public bool SetClock { get; init; }

    [CommandOption("--tag-database-source")]
    [Description("Tag database generation source")]
    [DefaultValue(YokogawaMxEthernetTagDatabaseSource.PhysicalChannelNumber)]
    public YokogawaMxEthernetTagDatabaseSource TagDatabaseSource { get; init; } = YokogawaMxEthernetTagDatabaseSource.PhysicalChannelNumber;
}
