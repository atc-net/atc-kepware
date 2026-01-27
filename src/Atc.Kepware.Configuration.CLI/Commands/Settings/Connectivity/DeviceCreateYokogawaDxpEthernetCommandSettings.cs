namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateYokogawaDxpEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--model")]
    [Description("Device model")]
    [DefaultValue(YokogawaDxpEthernetModel.Dxp100)]
    public YokogawaDxpEthernetModel Model { get; init; } = YokogawaDxpEthernetModel.Dxp100;

    [CommandOption("--data-handling")]
    [Description("Data handling for out of range and error conditions")]
    [DefaultValue(YokogawaDxpEthernetDataHandling.None)]
    public YokogawaDxpEthernetDataHandling DataHandling { get; init; } = YokogawaDxpEthernetDataHandling.None;

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
    [DefaultValue(YokogawaDxpEthernetDateTimeSource.DeviceTime)]
    public YokogawaDxpEthernetDateTimeSource DateAndTime { get; init; } = YokogawaDxpEthernetDateTimeSource.DeviceTime;

    [CommandOption("--date-format")]
    [Description("Date format for the return string")]
    [DefaultValue(YokogawaDxpEthernetDateFormat.MmDdYy)]
    public YokogawaDxpEthernetDateFormat DateFormat { get; init; } = YokogawaDxpEthernetDateFormat.MmDdYy;

    [CommandOption("--set-clock")]
    [Description("Set device clock on communication startup")]
    [DefaultValue(false)]
    public bool SetClock { get; init; }

    [CommandOption("--tag-database-source")]
    [Description("Tag database generation source")]
    [DefaultValue(YokogawaDxpEthernetTagDatabaseSource.PhysicalChannelNumber)]
    public YokogawaDxpEthernetTagDatabaseSource TagDatabaseSource { get; init; } = YokogawaDxpEthernetTagDatabaseSource.PhysicalChannelNumber;
}
