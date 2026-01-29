namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateAllenBradleyEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--device-id <DEVICEID>")]
    [Description("The device IP address (e.g., '192.168.1.100')")]
    public string DeviceId { get; init; } = "255.255.255.255";

    [CommandOption("--model")]
    [AllenBradleyEthernetDeviceModelTypeDescription]
    public FlagValue<AllenBradleyEthernetDeviceModelType>? Model { get; init; }

    [CommandOption("--port")]
    [Description("Specify the TCP/IP port on the target device (default: 2222)")]
    public int Port { get; init; } = 2222;

    [CommandOption("--request-size")]
    [AllenBradleyEthernetRequestSizeTypeDescription]
    public FlagValue<AllenBradleyEthernetRequestSizeType>? RequestSize { get; init; }

    [CommandOption("--dst-node-address")]
    [Description("Destination Node Address for DF1 gateway applications. Enter 0 for non-gateway applications (default: 0, range: 0-255)")]
    public int DestinationNodeAddress { get; init; } = 0;
}