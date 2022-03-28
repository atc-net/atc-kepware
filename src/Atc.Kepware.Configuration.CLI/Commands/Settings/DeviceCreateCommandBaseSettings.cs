namespace Atc.Kepware.Configuration.CLI.Commands.Settings;

public class DeviceCreateCommandBaseSettings : ChannelAndDeviceCommandBaseSettings
{
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

        return ValidationResult.Success();
    }
}