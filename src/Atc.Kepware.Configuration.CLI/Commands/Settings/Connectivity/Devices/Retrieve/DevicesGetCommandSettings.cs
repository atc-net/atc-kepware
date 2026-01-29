namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Devices.Retrieve;

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

        var isValidName = IsValidName(ChannelName);
        return isValidName.Successful
            ? ValidationResult.Success()
            : isValidName;
    }
}