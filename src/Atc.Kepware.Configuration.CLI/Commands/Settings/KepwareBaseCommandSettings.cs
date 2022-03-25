namespace Atc.Kepware.Configuration.CLI.Commands.Settings;

public class KepwareBaseCommandSettings : BaseCommandSettings
{
    [CommandOption("-s|--serverurl <SERVERURL>")]
    [Description("Server Url for Kepserver configuration endpoint")]
    public string ServerUrl { get; init; } = string.Empty;

    [CommandOption("-u|--username [USERNAME]")]
    [Description("UserName for Kepware server configuration endpoint")]
    public FlagValue<string>? UserName { get; init; }

    [CommandOption("-p|--password [PASSWORD]")]
    [Description("Password for Kepware server configuration endpoint")]
    public FlagValue<string>? Password { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (string.IsNullOrEmpty(ServerUrl))
        {
            return ValidationResult.Error("serverurl is not set.");
        }

        if (Uri.TryCreate(ServerUrl, UriKind.Relative, out _))
        {
            return ValidationResult.Error("serverurl is invalid.");
        }

        if ((UserName is not null && UserName.IsSet && Password is not null && !Password.IsSet) ||
            (UserName is not null && !UserName.IsSet && Password is not null && Password.IsSet))
        {
            return ValidationResult.Error("Both username and password must be set.");
        }

        return ValidationResult.Success();
    }
}