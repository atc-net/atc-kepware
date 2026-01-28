namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class ChannelCreateCodesysCommandSettings : ChannelCreateCommandBaseSettings
{
    [CommandOption("--keep-alive-minutes")]
    [Description("Number of minutes to keep an inactive connection open (1-10)")]
    [DefaultValue(1)]
    public int KeepAliveMinutes { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (KeepAliveMinutes < 1 || KeepAliveMinutes > 10)
        {
            return ValidationResult.Error("--keep-alive-minutes must be between 1 and 10.");
        }

        return ValidationResult.Success();
    }
}
