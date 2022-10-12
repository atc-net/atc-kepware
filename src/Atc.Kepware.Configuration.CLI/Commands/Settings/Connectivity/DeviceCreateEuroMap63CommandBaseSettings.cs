namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateEuroMap63CommandBaseSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--session-file-path <SESSION-FILE-PATH>")]
    [Description("The path to the session file directory")]
    public string SessionFilePath { get; init; } = string.Empty;

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (string.IsNullOrEmpty(SessionFilePath))
        {
            return ValidationResult.Error("--session-file-path is not set.");
        }

        return ValidationResult.Success();
    }
}