namespace Atc.Kepware.Configuration.CLI.Commands.Settings.IotGateway;

public class IotAgentCreateCommandBaseSettings : KepwareBaseCommandSettings
{
    [CommandOption("-n|--name <NAME>")]
    [Description("Iot Agent Name")]
    public string Name { get; init; } = string.Empty;

    [CommandOption("--description [DESCRIPTION]")]
    [Description("Iot Agent Description")]
    public FlagValue<string>? Description { get; init; }

    [CommandOption("--ignore-quality-changes")]
    [Description("Indicates whether changes in quality should be ignored and not passed on")]
    [DefaultValue(false)]
    public bool? IgnoreQualityChanges { get; init; }

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