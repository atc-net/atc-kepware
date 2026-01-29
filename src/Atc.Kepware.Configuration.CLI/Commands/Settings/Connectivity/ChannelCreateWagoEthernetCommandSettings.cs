namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class ChannelCreateWagoEthernetCommandSettings : ChannelCreateCommandBaseSettings
{
    [CommandOption("--network-adapter [NETWORK-ADAPTER]")]
    [Description("Network adapter to bind for Ethernet communication")]
    public FlagValue<string>? NetworkAdapter { get; init; } = new();
}