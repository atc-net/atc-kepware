namespace Atc.Kepware.Configuration.CLI.Commands.Settings;

public class ChannelCreateOpcUaClientCommandSettings : ChannelCreateCommandBaseSettings
{
    [CommandOption("--endpointUrl <ENDPOINTURL>")]
    [Description("Endpoint Url for OPC UA Client Channel")]
    public string EndpointUrl { get; init; } = string.Empty;

    [CommandOption("--serversecuritypolicy [SERVERSECURITYPOLICY]")]
    [OpcUaServerSecurityPolicyTypeDescription]
    public FlagValue<OpcUaServerSecurityPolicyType>? ServerSecurityPolicy { get; init; } = new();

    [CommandOption("--opcuausername [OPCUAUSERNAME]")]
    [Description("UserName for OPC UA Client Channel")]
    public FlagValue<string>? OpcUaUserName { get; init; }

    [CommandOption("--opcuapassword [OPCUAPASSWORD]")]
    [Description("Password for OPC UA Client Channel")]
    public FlagValue<string>? OpcUaPassword { get; init; }

    [CommandOption("--servermessagemode [SERVERMESSAGEMODE]")]
    [OpcUaServerMessageModeTypeDescription]
    public FlagValue<OpcUaServerMessageModeType>? ServerMessageMode { get; init; } = new();

    [CommandOption("--connecttimeoutseconds")]
    [Description("Specify the maximum amount of time, in seconds the channel should wait to successfully connect after making a connect call")]
    [DefaultValue(30)]
    public int ConnectTimeoutSeconds { get; init; }

    [CommandOption("--sessiontimeoutinactiveminutes")]
    [Description("Specifies the maximum amount of time, in minutes, a session remains open without activity")]
    [DefaultValue(20)]
    public int SessionTimeoutInactiveMinutes { get; init; }

    [CommandOption("--sessionrenewalintervalminutes")]
    [Description("Specifies the time, in minutes, between channel renewals")]
    [DefaultValue(60)]
    public int SessionRenewalIntervalMinutes { get; init; }

    [CommandOption("--sessionfailedconnectionretryintervalseconds")]
    [Description("Specifies the rate, in seconds, at which the channel attempts to reconnect if it fails to connect or becomes disconnected")]
    [DefaultValue(5)]
    public int SessionFailedConnectionRetryIntervalSeconds { get; init; }

    [CommandOption("--sessionwatchdogtimeout")]
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
            return ValidationResult.Error("endpointUrl is not set.");
        }

        if (Uri.TryCreate(EndpointUrl, UriKind.Relative, out _))
        {
            return ValidationResult.Error("endpointUrl is invalid.");
        }

        // TODO: Validate if ServerSecurityPolicy != None -> Så er username//Password required

        // TODO: Expand

        return ValidationResult.Success();
    }
}