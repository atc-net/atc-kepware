namespace Atc.Kepware.Configuration.CLI.Commands.Settings;

public class TagGroupCreateCommandSettings : ChannelAndDeviceCommandBaseSettings
{
    // TODO: Expand

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        // TODO: Expand

        return ValidationResult.Success();
    }
}