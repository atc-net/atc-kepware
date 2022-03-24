namespace Atc.Kepware.Configuration.CLI.Commands.Settings;

public class DevicesGetCommandSettings : KepwareBaseCommandSettings
{
    [CommandOption("-c|--channelname <CHANNELNAME>")]
    [Description("Requested ChannelName")]
    public string ChannelName { get; init; } = string.Empty;

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        return string.IsNullOrEmpty(ChannelName)
            ? ValidationResult.Error("channelname is not set.")
            : ValidationResult.Success();
    }
}