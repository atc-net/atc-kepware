namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class ChannelDeleteCommandSettings : KepwareBaseCommandSettings
{
    [CommandOption("-n|--name <NAME>")]
    [Description("Channel Name")]
    public string Name { get; init; } = string.Empty;

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