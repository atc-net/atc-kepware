namespace Atc.Kepware.Configuration.CLI.Commands.Settings;

public class DevicesGetCommandSettings : KepwareBaseCommandSettings
{
    [CommandOption("--channelname <CHANNELNAME>")]
    [Description("ChannelName for Kepware server configuration endpoint")]
    public string ChannelName { get; init; } = string.Empty;

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

        return ValidationResult.Success();
    }
}
