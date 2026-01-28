namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class ChannelCreateBristolBsapIpCommandSettings : ChannelCreateCommandBaseSettings
{
    [CommandOption("--udp-port")]
    [Description("UDP port number devices on this network use (1-65535)")]
    [DefaultValue(1234)]
    public int UdpPort { get; init; }

    [CommandOption("--transactions-per-cycle")]
    [Description("Number of transactions per cycle (1-99)")]
    [DefaultValue(1)]
    public int TransactionsPerCycle { get; init; }

    [CommandOption("--network-mode [NETWORK-MODE]")]
    [Description("Network mode (LoadBalanced, Priority)")]
    public FlagValue<BristolBsapIpChannelNetworkModeType>? NetworkMode { get; init; } = new();

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (UdpPort < 1 || UdpPort > 65535)
        {
            return ValidationResult.Error("--udp-port must be between 1 and 65535.");
        }

        if (TransactionsPerCycle < 1 || TransactionsPerCycle > 99)
        {
            return ValidationResult.Error("--transactions-per-cycle must be between 1 and 99.");
        }

        return ValidationResult.Success();
    }
}
