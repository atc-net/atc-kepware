namespace Atc.Kepware.Configuration.CLI.Commands.Settings;

public class ChannelDeleteCommandSettings : KepwareBaseCommandSettings
{
    [CommandOption("-n|--name <NAME>")]
    [Description("Requested Name")]
    public string Name { get; init; } = string.Empty;

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