namespace Atc.Kepware.Configuration.CLI.Commands.Settings;

public class DevicesGetCommandSettings : KepwareBaseCommandSettings
{
    [CommandOption("-c|--channel-name <CHANNEL-NAME>")]
    [Description("Requested ChannelName")]
    public string ChannelName { get; init; } = string.Empty;

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        var validationError = KepwareConfigurationValidationHelper.GetErrorForName("channel-name", ChannelName);
        return validationError is not null
            ? ValidationResult.Error(validationError)
            : ValidationResult.Success();
    }
}