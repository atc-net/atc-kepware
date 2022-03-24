namespace Atc.Kepware.Configuration.CLI.Commands.Settings;

public class ChannelAndDeviceCommandBaseSettings : KepwareBaseCommandSettings
{
    [CommandOption("-c|--channelname <CHANNELNAME>")]
    [Description("Requested ChannelName")]
    public string ChannelName { get; init; } = string.Empty;

    [CommandOption("-d|--devicename <DEVICENAME>")]
    [Description("Requested DeviceName")]
    public string DeviceName { get; init; } = string.Empty;

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (string.IsNullOrEmpty(ChannelName))
        {
            return ValidationResult.Error("channelname is not set.");
        }

        if (string.IsNullOrEmpty(DeviceName))
        {
            return ValidationResult.Error("devicename is not set.");
        }

        return ValidationResult.Success();
    }
}