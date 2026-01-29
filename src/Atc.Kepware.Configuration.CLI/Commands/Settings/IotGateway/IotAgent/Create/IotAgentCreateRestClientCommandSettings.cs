namespace Atc.Kepware.Configuration.CLI.Commands.Settings.IotGateway.IotAgent.Create;

public sealed class IotAgentCreateRestClientCommandSettings : IotAgentCreateCommandBaseSettings
{
    private readonly System.ComponentModel.DataAnnotations.UriAttribute urlValidator = new(
        required: true,
        allowHttp: true,
        allowHttps: true,
        allowFtp: false,
        allowFtps: false,
        allowFile: false,
        allowOpcTcp: false);

    [CommandOption("--url <URL>")]
    [Description("The URl of the endpoint to send data to")]
    public string Url { get; init; } = string.Empty;

    [CommandOption("--publish-http-method <PUBLISH-HTTP-METHOD>")]
    [IotAgentPublishHttpMethodTypeDescription]
    public IotAgentPublishHttpMethodType PublishHttpMethod { get; init; }

    [CommandOption("--rate <RATE>")]
    [Description("Specifies the frequency, in milliseconds, at which the agent pushes data to the endpoint")]
    [DefaultValue(10000)]
    public int Rate { get; init; }

    [CommandOption("--publish-format <PUBLISH-FORMAT>")]
    [IotAgentPublishFormatTypeDescription]
    public IotAgentPublishFormatType PublishFormat { get; init; }

    [CommandOption("--max-events-per-publish")]
    [Description("The number of tag events the gateway packages in a single transmission when using narrow format")]
    [DefaultValue(1000)]
    public int MaxEventsPerPublish { get; init; }

    [CommandOption("--transaction-timeout <TRANSACTION-TIMEOUT>")]
    [Description("Defines the maximum amount of time, in seconds, allowed for a transaction to run")]
    [DefaultValue(5)]
    public int TransactionTimeout { get; init; }

    [CommandOption("--send-initial-update")]
    [Description("Indicates if an initial update should be sent out on each tag when the Iot Agent starts up")]
    [DefaultValue(false)]
    public bool? SendInitialUpdate { get; init; }

    [CommandOption("--http-headers <KEY=VALUE>")]
    [Description("The headers to send to url on each connection")]
    public IDictionary<string, string> HttpHeaders { get; set; } = new Dictionary<string, string>(StringComparer.Ordinal);

    [CommandOption("--publish-message-format <PUBLISH-MESSAGE-FORMAT>")]
    [IotAgentPublishMessageFormatTypeDescription]
    public IotAgentPublishMessageFormatType PublishMessageFormat { get; init; }

    [CommandOption("--publish-media-type [PUBLISH-MEDIA-TYPE]")]
    [IotAgentPublishMediaTypeDescription]
    public FlagValue<IotAgentPublishMediaType>? PublishMediaType { get; init; } = new();

    [CommandOption("--url-username [URL-USERNAME]")]
    [Description("The username to use when calling the URl endpoint")]
    public FlagValue<string>? UrlUserName { get; init; }

    [CommandOption("--url-password [URL-PASSWORD]")]
    [Description("The password to use when calling the URl endpoint")]
    public FlagValue<string>? UrlPassword { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (!urlValidator.IsValid(Url))
        {
            return ValidationResult.Error("--url is not set or not valid.");
        }

        if (Rate <= 0)
        {
            return ValidationResult.Error("--rate is not set or not valid.");
        }

        if (PublishFormat == IotAgentPublishFormatType.Narrow &&
            MaxEventsPerPublish <= 0)
        {
            return ValidationResult.Error("--max-events-per-publish is not set or not valid.");
        }

        if ((UrlUserName is not null && UrlUserName.IsSet && UrlPassword is not null && !UrlPassword.IsSet) ||
            (UrlUserName is not null && !UrlUserName.IsSet && UrlPassword is not null && UrlPassword.IsSet))
        {
            return ValidationResult.Error("Both url-username and url-password must be set.");
        }

        return ValidationResult.Success();
    }
}