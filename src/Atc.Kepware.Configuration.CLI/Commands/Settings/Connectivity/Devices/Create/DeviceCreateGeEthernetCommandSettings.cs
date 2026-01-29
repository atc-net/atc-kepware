namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Devices.Create;

public class DeviceCreateGeEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--model")]
    [Description("Device model")]
    [DefaultValue(GeEthernetModel.PacSystems)]
    public GeEthernetModel Model { get; init; } = GeEthernetModel.PacSystems;
}