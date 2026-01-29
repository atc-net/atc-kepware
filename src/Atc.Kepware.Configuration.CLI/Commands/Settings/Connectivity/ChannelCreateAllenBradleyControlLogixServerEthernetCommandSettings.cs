namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class ChannelCreateAllenBradleyControlLogixServerEthernetCommandSettings : ChannelCreateCommandBaseSettings
{
    [CommandOption("--port")]
    [Description("TCP/IP and UDP port for EtherNet/IP communication (1-65535)")]
    [DefaultValue(44818)]
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