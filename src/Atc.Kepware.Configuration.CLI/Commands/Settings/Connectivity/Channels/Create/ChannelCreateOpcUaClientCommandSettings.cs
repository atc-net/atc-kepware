namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Channels.Create;

public class ChannelCreateOpcUaClientCommandSettings : ChannelCreateCommandBaseSettings
{
    [CommandOption("--endpoint-url <ENDPOINT-URL>")]
    [Description("Endpoint Url for OPC UA Client Channel")]
    public string EndpointUrl { get; init; } = string.Empty;

    [CommandOption("--server-security-policy [SERVER-SECURITY-POLICY]")]
    [OpcUaServerSecurityPolicyTypeDescription]
    public FlagValue<OpcUaServerSecurityPolicyType>? ServerSecurityPolicy { get; init; } = new();

    [CommandOption("--opc-ua-username [OPC-UA-USERNAME]")]
    [Description("UserName for OPC UA Client Channel")]
    public FlagValue<string>? OpcUaUserName { get; init; }

    [CommandOption("--opc-ua-password [OPC-UA-PASSWORD]")]
    [Description("Password for OPC UA Client Channel")]
    public FlagValue<string>? OpcUaPassword { get; init; }

    [CommandOption("--server-message-mode [SERVER-MESSAGE-MODE]")]
    [OpcUaServerMessageModeTypeDescription]
    public FlagValue<OpcUaServerMessageModeType>? ServerMessageMode { get; init; } = new();

    [CommandOption("--connect-timeout-seconds")]
    [Description("Specify the maximum amount of time, in seconds the channel should wait to successfully connect after making a connect call")]
    [DefaultValue(30)]
    public int ConnectTimeoutSeconds { get; init; }

    [CommandOption("--session-timeout-inactive-minutes")]
    [Description("Specifies the maximum amount of time, in minutes, a session remains open without activity")]
    [DefaultValue(20)]
    public int SessionTimeoutInactiveMinutes { get; init; }

    [CommandOption("--session-renewal-interval-minutes")]
    [Description("Specifies the time, in minutes, between channel renewals")]
    [DefaultValue(60)]
    public int SessionRenewalIntervalMinutes { get; init; }

    [CommandOption("--session-failed-connection-retry-interval-seconds")]
    [Description("Specifies the rate, in seconds, at which the channel attempts to reconnect if it fails to connect or becomes disconnected")]
    [DefaultValue(5)]
    public int SessionFailedConnectionRetryIntervalSeconds { get; init; }

    [CommandOption("--session-watchdog-timeout")]
    [Description("Specifies the rate the client reads the server status state node")]
    [DefaultValue(5)]
    public int SessionWatchdogTimeout { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (string.IsNullOrEmpty(EndpointUrl))
        {
            return ValidationResult.Error("--endpoint-url is not set.");
        }

        if (Uri.TryCreate(EndpointUrl, UriKind.Relative, out _))
        {
            return ValidationResult.Error("--endpoint-url is invalid.");
        }

        if (ServerSecurityPolicy is not null &&
            ServerSecurityPolicy.IsSet &&
            ServerSecurityPolicy.Value != OpcUaServerSecurityPolicyType.None &&
            ((UserName is not null && UserName.IsSet && Password is not null && !Password.IsSet) ||
             (UserName is not null && !UserName.IsSet && Password is not null && Password.IsSet)))
        {
            return ValidationResult.Error("Both username and password must be set when ServerSecurityPolicy is in effect.");
        }

        return ValidationResult.Success();
    }
}