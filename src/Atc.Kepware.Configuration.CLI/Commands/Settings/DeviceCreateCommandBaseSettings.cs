namespace Atc.Kepware.Configuration.CLI.Commands.Settings;

public class DeviceCreateCommandBaseSettings : KepwareBaseCommandSettings
{
    [CommandOption("-n|--name <NAME>")]
    [Description("Requested Name")]
    public string Name { get; init; } = string.Empty;

    [CommandOption("--description [DESCRIPTION]")]
    [Description("Requested Description")]
    public FlagValue<string>? Description { get; init; }

    // TODO: Expand

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

        // TODO: Expand

        return ValidationResult.Success();
    }
}