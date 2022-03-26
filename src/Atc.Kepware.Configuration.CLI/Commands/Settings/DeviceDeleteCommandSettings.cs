namespace Atc.Kepware.Configuration.CLI.Commands.Settings;

public class DeviceDeleteCommandSettings : KepwareBaseCommandSettings
{
    [CommandOption("-c|--channel-name <CHANNEL-NAME>")]
    [Description("Requested ChannelName")]
    public string ChannelName { get; init; } = string.Empty;

    [CommandOption("-d|--device-name <DEVICE-NAME>")]
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
            return ValidationResult.Error("--channel-name is not set.");
        }

        if (string.IsNullOrEmpty(DeviceName))
        {
            return ValidationResult.Error("--device-name is not set.");
        }

        return ValidationResult.Success();
    }
}