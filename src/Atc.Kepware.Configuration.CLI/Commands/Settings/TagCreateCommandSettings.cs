namespace Atc.Kepware.Configuration.CLI.Commands.Settings;

public class TagCreateCommandSettings : ChannelAndDeviceCommandBaseSettings
{
    [CommandOption("--tag-name <TAG-NAME>")]
    [Description("Requested TagName")]
    public string TagName { get; init; } = string.Empty;

    // TODO: Expand with request properties...

    [CommandOption("--tag-group <TAG-GROUP>")]
    [Description("Tag Groups indicating tree structure.")]
    public string[] TagGroups { get; init; } = Array.Empty<string>();

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (string.IsNullOrEmpty(TagName))
        {
            return ValidationResult.Error("--tag-name is not set.");
        }

        return ValidationResult.Success();
    }
}