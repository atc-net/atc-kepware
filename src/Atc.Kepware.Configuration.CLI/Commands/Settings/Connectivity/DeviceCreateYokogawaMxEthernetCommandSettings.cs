namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateYokogawaMxEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--model")]
    [Description("Device model")]
    [DefaultValue(YokogawaMxEthernetModel.Mx100)]
    public YokogawaMxEthernetModel Model { get; init; } = YokogawaMxEthernetModel.Mx100;

    [CommandOption("--stop-mx-on-shutdown")]
    [Description("Stop MX when the server is exited")]
    [DefaultValue(false)]
    public bool StopMxOnShutdown { get; init; }

    [CommandOption("--data-handling")]
    [Description("Data handling for special condition statuses")]
    [DefaultValue(YokogawaMxEthernetDataHandling.MinusInfPlusInf)]
    public YokogawaMxEthernetDataHandling DataHandling { get; init; } = YokogawaMxEthernetDataHandling.MinusInfPlusInf;

    [CommandOption("--date-and-time")]
    [Description("Source of the date and time data")]
    [DefaultValue(YokogawaMxEthernetDateTimeSource.DeviceTime)]
    public YokogawaMxEthernetDateTimeSource DateAndTime { get; init; } = YokogawaMxEthernetDateTimeSource.DeviceTime;

    [CommandOption("--date-format")]
    [Description("Date format for the return string")]
    [DefaultValue(YokogawaMxEthernetDateFormat.MmDdYy)]
    public YokogawaMxEthernetDateFormat DateFormat { get; init; } = YokogawaMxEthernetDateFormat.MmDdYy;
}