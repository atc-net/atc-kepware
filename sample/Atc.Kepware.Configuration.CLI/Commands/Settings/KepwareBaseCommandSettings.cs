namespace Atc.Kepware.Configuration.CLI.Commands.Settings;

public class KepwareBaseCommandSettings : BaseCommandSettings
{
    [CommandOption("--url <URL>")]
    [Description("Url for Kepserver configuration endpoint")]
    public string Url { get; init; } = string.Empty;

    [CommandOption("--username <USERNAME>")]
    [Description("UserName for Kepware server configuration endpoint")]
    public string UserName { get; init; } = string.Empty;

    [CommandOption("--password <PASSWORD>")]
    [Description("Password for Kepware server configuration endpoint")]
    public string Password { get; init; } = string.Empty;

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

        if (string.IsNullOrEmpty(UserName))
        {
            return ValidationResult.Error("username is not set.");
        }

        if (string.IsNullOrEmpty(Password))
        {
            return ValidationResult.Error("password is not set.");
        }

        return ValidationResult.Success();
    }
}