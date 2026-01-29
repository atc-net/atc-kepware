namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Channels.Create;

public class ChannelCreateBeckhoffTwinCatCommandSettings : ChannelCreateCommandBaseSettings
{
    [CommandOption("--network-adapter [NETWORK-ADAPTER]")]
    [Description("Specify the name of a network adapter to bind or allow the OS to select the default")]
    public FlagValue<string>? NetworkAdapter { get; init; }
}