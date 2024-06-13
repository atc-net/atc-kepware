namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class TagGroupCreateCommandSettings : ChannelAndDeviceCommandBaseSettings
{
    [CommandOption("--name <NAME>")]
    [Description("Tag Group Name")]
    public string Name { get; init; } = string.Empty;

    [CommandOption("--description")]
    [Description("Tag Group Description")]
    public string Description { get; init; } = string.Empty;

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

        var isValidName = IsValidName(Name);
        return isValidName.Successful
            ? ValidationResult.Success()
            : isValidName;
    }
}