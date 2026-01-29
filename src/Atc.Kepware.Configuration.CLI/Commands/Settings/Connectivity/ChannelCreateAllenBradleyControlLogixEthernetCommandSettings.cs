namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class ChannelCreateAllenBradleyControlLogixEthernetCommandSettings : ChannelCreateCommandBaseSettings
{
    [CommandOption("--network-adapter")]
    [Description("Specify the name of a network adapter to bind or allow the OS to select the default")]
    public FlagValue<string>? NetworkAdapter { get; init; }
}