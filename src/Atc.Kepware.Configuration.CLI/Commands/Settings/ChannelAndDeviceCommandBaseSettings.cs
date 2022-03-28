namespace Atc.Kepware.Configuration.CLI.Commands.Settings;

public class ChannelAndDeviceCommandBaseSettings : KepwareBaseCommandSettings
{
    [CommandOption("-c|--channel-name <CHANNEL-NAME>")]
    [Description("ChannelName")]
    public string ChannelName { get; init; } = string.Empty;

    [CommandOption("-d|--device-name <DEVICE-NAME>")]
    [Description("DeviceName")]
    public string DeviceName { get; init; } = string.Empty;

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        var isValidChannelName = IsValidName("channel-name", ChannelName);
        if (!isValidChannelName.Successful)
        {
            return isValidChannelName;
        }

        var isValidDeviceName = IsValidName("device-name", DeviceName);
        if (!isValidDeviceName.Successful)
        {
            return isValidDeviceName;
        }

        return ValidationResult.Success();
    }
}