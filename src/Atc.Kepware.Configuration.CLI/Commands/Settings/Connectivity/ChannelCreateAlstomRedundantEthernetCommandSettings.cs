namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public sealed class ChannelCreateAlstomRedundantEthernetCommandSettings : ChannelCreateCommandBaseSettings
{
    [CommandOption("--primary-network-adapter [PRIMARY_NETWORK_ADAPTER]")]
    [Description("Specify the Network Interface Card (NIC) that should be used to connect to the primary network.")]
    public FlagValue<string>? PrimaryNetworkAdapter { get; init; }

    [CommandOption("--secondary-network-adapter [SECONDARY_NETWORK_ADAPTER]")]
    [Description("Specify the Network Interface Card (NIC) that should be used to connect to the secondary network.")]
    public FlagValue<string>? SecondaryNetworkAdapter { get; init; }
}
