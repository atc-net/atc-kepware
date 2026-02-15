namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Meters;

public class MeterCreateCommandBaseSettings : MeterCommandBaseSettings
{
    [CommandOption("-n|--name <NAME>")]
    [Description("Requested Name")]
    public string Name { get; init; } = string.Empty;

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

        var isValidName = IsValidName(Name);
        return isValidName.Successful
            ? ValidationResult.Success()
            : isValidName;
    }
}