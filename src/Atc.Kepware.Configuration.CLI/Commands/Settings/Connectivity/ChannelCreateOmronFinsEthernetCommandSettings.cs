namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class ChannelCreateOmronFinsEthernetCommandSettings : ChannelCreateCommandBaseSettings
{
    [CommandOption("--network-adapter [NETWORK-ADAPTER]")]
    [Description("Network adapter to bind for Ethernet communication")]
    public FlagValue<string>? NetworkAdapter { get; init; } = new();

    [CommandOption("--port")]
    [Description("Port number used by devices (1-65535)")]
    [DefaultValue(9600)]
    public int Port { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (Port < 1 || Port > 65535)
        {
            return ValidationResult.Error("--port must be between 1 and 65535.");
        }

        return ValidationResult.Success();
    }
}