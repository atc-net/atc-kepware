namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

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

        return System.ComponentModel.DataAnnotations.KeyStringAttribute.TryIsValid(
            ChannelName,
            out var errorMessage)
            ? ValidationResult.Success()
            : ValidationResult.Error($"--{ChannelName}: {errorMessage}");
    }
}