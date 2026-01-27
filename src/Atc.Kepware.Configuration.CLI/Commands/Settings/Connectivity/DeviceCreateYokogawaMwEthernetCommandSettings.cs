namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateYokogawaMwEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--model")]
    [Description("Device model")]
    [DefaultValue(YokogawaMwEthernetModel.Mw100)]
    public YokogawaMwEthernetModel Model { get; init; } = YokogawaMwEthernetModel.Mw100;

    [CommandOption("--data-handling")]
    [Description("Data handling for out of range and error conditions")]
    [DefaultValue(YokogawaMwEthernetDataHandling.None)]
    public YokogawaMwEthernetDataHandling DataHandling { get; init; } = YokogawaMwEthernetDataHandling.None;

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
    [DefaultValue(YokogawaMwEthernetDateTimeSource.DeviceTime)]
    public YokogawaMwEthernetDateTimeSource DateAndTime { get; init; } = YokogawaMwEthernetDateTimeSource.DeviceTime;

    [CommandOption("--date-format")]
    [Description("Date format for the return string")]
    [DefaultValue(YokogawaMwEthernetDateFormat.MmDdYy)]
    public YokogawaMwEthernetDateFormat DateFormat { get; init; } = YokogawaMwEthernetDateFormat.MmDdYy;

    [CommandOption("--set-clock")]
    [Description("Set device clock on communication startup")]
    [DefaultValue(false)]
    public bool SetClock { get; init; }

    [CommandOption("--tag-database-source")]
    [Description("Tag database generation source")]
    [DefaultValue(YokogawaMwEthernetTagDatabaseSource.PhysicalChannelNumber)]
    public YokogawaMwEthernetTagDatabaseSource TagDatabaseSource { get; init; } = YokogawaMwEthernetTagDatabaseSource.PhysicalChannelNumber;
}
