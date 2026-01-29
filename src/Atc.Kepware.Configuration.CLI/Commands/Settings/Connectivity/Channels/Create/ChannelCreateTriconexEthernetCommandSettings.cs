namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Channels.Create;

public class ChannelCreateTriconexEthernetCommandSettings : ChannelCreateCommandBaseSettings
{
    [CommandOption("--enable-network-redundancy")]
    [Description("Enable network redundancy")]
    [DefaultValue(false)]
    public bool EnableNetworkRedundancy { get; init; }

    [CommandOption("--primary-network-adapter [PRIMARY-NETWORK-ADAPTER]")]
    [Description("NIC to which the primary network is connected")]
    public FlagValue<string>? PrimaryNetworkAdapter { get; init; } = new();

    [CommandOption("--secondary-network-adapter [SECONDARY-NETWORK-ADAPTER]")]
    [Description("NIC to which the secondary network is connected (only applicable when network redundancy is enabled)")]
    public FlagValue<string>? SecondaryNetworkAdapter { get; init; } = new();
}