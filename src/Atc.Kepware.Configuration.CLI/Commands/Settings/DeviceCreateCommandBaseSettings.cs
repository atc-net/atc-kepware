namespace Atc.Kepware.Configuration.CLI.Commands.Settings;

public class DeviceCreateCommandBaseSettings : ChannelAndDeviceCommandBaseSettings
{
    [CommandOption("--session-file-path <SESSION-FILE-PATH>")]
    [Description("The path to the session file directory")]
    public string SessionFilePath { get; set; } = string.Empty;

    [CommandOption("--description [DESCRIPTION]")]
    [Description("Requested Description")]
    public FlagValue<string>? Description { get; init; }

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