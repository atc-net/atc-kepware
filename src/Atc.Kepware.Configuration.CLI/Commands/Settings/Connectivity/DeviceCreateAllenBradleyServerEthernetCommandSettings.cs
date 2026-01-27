namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateAllenBradleyServerEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--port")]
    [Description("Port number for the target device (0-65535)")]
    [DefaultValue(2222)]
    public int Port { get; init; } = 2222;

    [CommandOption("--first-word-low")]
    [Description("Specifies the word order for 32-bit data types")]
    [DefaultValue(false)]
    public bool FirstWordLow { get; init; }

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
