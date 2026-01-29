namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class ChannelCreateFanucFocasEthernetCommandSettings : ChannelCreateCommandBaseSettings
{
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