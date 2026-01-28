namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class ChannelCreateKeyenceKvEthernetCommandSettings : ChannelCreateCommandBaseSettings
{
    [CommandOption("--port")]
    [Description("Port number for channel (default 8501)")]
    [DefaultValue(8501)]
    public int Port { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (Port < 0 || Port > 65535)
        {
            return ValidationResult.Error("--port must be between 0 and 65535.");
        }

        return ValidationResult.Success();
    }
}
