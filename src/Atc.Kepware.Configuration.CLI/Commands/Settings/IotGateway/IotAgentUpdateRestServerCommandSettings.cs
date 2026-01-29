namespace Atc.Kepware.Configuration.CLI.Commands.Settings.IotGateway;

public sealed class IotAgentUpdateRestServerCommandSettings : IotAgentUpdateCommandBaseSettings
{
    [CommandOption("--port [PORT]")]
    [Description("The port number the REST server listens on")]
    public FlagValue<int>? Port { get; init; }

    [CommandOption("--allow-anonymous [ALLOW-ANONYMOUS]")]
    [Description("Indicates whether anonymous connections are allowed (skip User Manager validation)")]
    public FlagValue<bool>? AllowAnonymous { get; init; }

    [CommandOption("--allow-write [ALLOW-WRITE]")]
    [Description("Indicates whether write operations are enabled")]
    public FlagValue<bool>? AllowWrite { get; init; }

    [CommandOption("--cors-allowed-origins [CORS-ALLOWED-ORIGINS]")]
    [Description("The CORS allowed origins (* for all, or specific origins)")]
    public FlagValue<string>? CorsAllowedOrigins { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (Port is not null &&
            Port.IsSet &&
            Port.Value is < 1 or > 65535)
        {
            return ValidationResult.Error("--port must be between 1 and 65535.");
        }

        return ValidationResult.Success();
    }
}