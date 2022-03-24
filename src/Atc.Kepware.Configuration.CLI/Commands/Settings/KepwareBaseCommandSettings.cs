namespace Atc.Kepware.Configuration.CLI.Commands.Settings;

public class KepwareBaseCommandSettings : BaseCommandSettings
{
    [CommandOption("--url <URL>")]
    [Description("Url for Kepserver configuration endpoint")]
    public string Url { get; init; } = string.Empty;

    [CommandOption("--username [USERNAME]")]
    [Description("UserName for Kepware server configuration endpoint")]
    public FlagValue<string>? UserName { get; init; }

    [CommandOption("--password [PASSWORD]")]
    [Description("Password for Kepware server configuration endpoint")]
    public FlagValue<string>? Password { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (string.IsNullOrEmpty(Url))
        {
            return ValidationResult.Error("url is not set.");
        }

        if (Uri.TryCreate(Url, UriKind.Relative, out _))
        {
            return ValidationResult.Error("url is invalid.");
        }

        if ((UserName is not null && UserName.IsSet && Password is not null && !Password.IsSet) ||
            (UserName is not null && !UserName.IsSet && Password is not null && Password.IsSet))
        {
            return ValidationResult.Error("Both username and password must be set.");
        }

        return ValidationResult.Success();
    }
}