namespace Atc.Kepware.Configuration.CLI.Commands.Settings.IotGateway;

public class IotAgentUpdateCommandBaseSettings : KepwareBaseCommandSettings
{
    [CommandOption("-n|--name <NAME>")]
    [Description("Iot Agent Name (Not updateable, but required for updating the Iot Agent!)")]
    public string Name { get; init; } = string.Empty;

    [CommandOption("--description [DESCRIPTION]")]
    [Description("Iot Agent Description")]
    public FlagValue<string>? Description { get; init; }

    [CommandOption("--ignore-quality-changes [IGNORE-QUALITY-CHANGES]")]
    [Description("Indicates whether changes in quality should be ignored and not passed on")]
    public FlagValue<bool>? IgnoreQualityChanges { get; init; }

    [CommandOption("--enabled [ENABLED]")]
    [Description("Indicates whether the Iot Item is enabled")]
    public FlagValue<bool>? Enabled { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        var isValidName = IsValidName(Name);
        if (!isValidName.Successful)
        {
            return isValidName;
        }

        return ValidationResult.Success();
    }
}