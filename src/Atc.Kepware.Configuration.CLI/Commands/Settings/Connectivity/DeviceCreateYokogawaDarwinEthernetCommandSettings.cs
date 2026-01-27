namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateYokogawaDarwinEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--model")]
    [Description("Device model")]
    [DefaultValue(YokogawaDarwinEthernetModel.Da100_1)]
    public YokogawaDarwinEthernetModel Model { get; init; } = YokogawaDarwinEthernetModel.Da100_1;

    [CommandOption("--data-handling")]
    [Description("Data handling for out of range and error conditions")]
    [DefaultValue(YokogawaDarwinEthernetDataHandling.None)]
    public YokogawaDarwinEthernetDataHandling DataHandling { get; init; } = YokogawaDarwinEthernetDataHandling.None;

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
    [DefaultValue(YokogawaDarwinEthernetDateTimeSource.DeviceTime)]
    public YokogawaDarwinEthernetDateTimeSource DateAndTime { get; init; } = YokogawaDarwinEthernetDateTimeSource.DeviceTime;

    [CommandOption("--date-format")]
    [Description("Date format for the return string")]
    [DefaultValue(YokogawaDarwinEthernetDateFormat.MmDdYy)]
    public YokogawaDarwinEthernetDateFormat DateFormat { get; init; } = YokogawaDarwinEthernetDateFormat.MmDdYy;

    [CommandOption("--set-clock")]
    [Description("Set device clock on communication startup")]
    [DefaultValue(false)]
    public bool SetClock { get; init; }

    [CommandOption("--tag-database-source")]
    [Description("Tag database generation source")]
    [DefaultValue(YokogawaDarwinEthernetTagDatabaseSource.PhysicalChannelNumber)]
    public YokogawaDarwinEthernetTagDatabaseSource TagDatabaseSource { get; init; } = YokogawaDarwinEthernetTagDatabaseSource.PhysicalChannelNumber;
}
