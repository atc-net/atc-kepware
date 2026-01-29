namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateGeEthernetGlobalDataCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--model")]
    [Description("Device model")]
    [DefaultValue(GeEthernetGlobalDataModel.Egd)]
    public GeEthernetGlobalDataModel Model { get; init; } = GeEthernetGlobalDataModel.Egd;
}