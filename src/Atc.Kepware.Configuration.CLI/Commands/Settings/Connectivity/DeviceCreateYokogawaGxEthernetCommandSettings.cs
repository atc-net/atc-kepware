namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateYokogawaGxEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--model")]
    [Description("Device model")]
    [DefaultValue(YokogawaGxEthernetModel.Gx)]
    public YokogawaGxEthernetModel Model { get; init; } = YokogawaGxEthernetModel.Gx;

    [CommandOption("--data-handling")]
    [Description("Data handling for out of range and error conditions")]
    [DefaultValue(YokogawaGxEthernetDataHandling.None)]
    public YokogawaGxEthernetDataHandling DataHandling { get; init; } = YokogawaGxEthernetDataHandling.None;

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
    [DefaultValue(YokogawaGxEthernetDateTimeSource.DeviceTime)]
    public YokogawaGxEthernetDateTimeSource DateAndTime { get; init; } = YokogawaGxEthernetDateTimeSource.DeviceTime;

    [CommandOption("--date-format")]
    [Description("Date format for the return string")]
    [DefaultValue(YokogawaGxEthernetDateFormat.MmDdYy)]
    public YokogawaGxEthernetDateFormat DateFormat { get; init; } = YokogawaGxEthernetDateFormat.MmDdYy;

    [CommandOption("--set-clock")]
    [Description("Set device clock on communication startup")]
    [DefaultValue(false)]
    public bool SetClock { get; init; }

    [CommandOption("--tag-database-source")]
    [Description("Tag database generation source")]
    [DefaultValue(YokogawaGxEthernetTagDatabaseSource.PhysicalChannelNumber)]
    public YokogawaGxEthernetTagDatabaseSource TagDatabaseSource { get; init; } = YokogawaGxEthernetTagDatabaseSource.PhysicalChannelNumber;
}
