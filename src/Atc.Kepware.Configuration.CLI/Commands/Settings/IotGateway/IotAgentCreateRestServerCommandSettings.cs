namespace Atc.Kepware.Configuration.CLI.Commands.Settings.IotGateway;

public sealed class IotAgentCreateRestServerCommandSettings : IotAgentCreateCommandBaseSettings
{
    [CommandOption("--port <PORT>")]
    [Description("The port number the REST server listens on")]
    [DefaultValue(39320)]
    public int Port { get; init; }

    [CommandOption("--allow-anonymous")]
    [Description("Indicates whether anonymous connections are allowed (skip User Manager validation)")]
    [DefaultValue(false)]
    public bool? AllowAnonymous { get; init; }

    [CommandOption("--allow-write")]
    [Description("Indicates whether write operations are enabled")]
    [DefaultValue(false)]
    public bool? AllowWrite { get; init; }

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

        if (Port is < 1 or > 65535)
        {
            return ValidationResult.Error("--port must be between 1 and 65535.");
        }

        return ValidationResult.Success();
    }
}