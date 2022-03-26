namespace Atc.Kepware.Configuration.CLI.Commands.Settings;

public class TagGroupDeleteCommandSettings : ChannelAndDeviceCommandBaseSettings
{
    [CommandOption("--name <NAME>")]
    [Description("Tag Group Name")]
    public string Name { get; init; } = string.Empty;

    [CommandOption("--tag-group")]
    [Description("Tag Groups indicating tree structure.")]
    public string[] TagGroups { get; init; } = Array.Empty<string>();

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (string.IsNullOrEmpty(Name))
        {
            return ValidationResult.Error("--name is not set.");
        }

        return ValidationResult.Success();
    }
}