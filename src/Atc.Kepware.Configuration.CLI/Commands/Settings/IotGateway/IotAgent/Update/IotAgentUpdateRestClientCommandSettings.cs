namespace Atc.Kepware.Configuration.CLI.Commands.Settings.IotGateway.IotAgent.Update;

public class IotAgentUpdateRestClientCommandSettings : IotAgentUpdateCommandBaseSettings
{
    private readonly System.ComponentModel.DataAnnotations.UriAttribute urlValidator = new(
        required: true,
        allowHttp: true,
        allowHttps: true,
        allowFtp: false,
        allowFtps: false,
        allowFile: false,
        allowOpcTcp: false);

    [CommandOption("--url [URL]")]
    [Description("The URl of the endpoint to send data to")]
    public FlagValue<string>? Url { get; init; }

    [CommandOption("--publish-http-method [PUBLISH-HTTP-METHOD]")]
    [IotAgentPublishHttpMethodTypeDescription]
    public FlagValue<IotAgentPublishHttpMethodType>? PublishHttpMethod { get; init; }

    [CommandOption("--rate [RATE]")]
    [Description("Specifies the frequency, in milliseconds, at which the agent pushes data to the endpoint")]
    public FlagValue<int>? Rate { get; init; }

    [CommandOption("--publish-format [PUBLISH-FORMAT]")]
    [IotAgentPublishFormatTypeDescription]
    public FlagValue<IotAgentPublishFormatType>? PublishFormat { get; init; }

    [CommandOption("--max-events-per-publish [MAX-EVENTS-PER-PUBLISH]")]
    [Description("The number of tag events the gateway packages in a single transmission when using narrow format")]
    public FlagValue<int>? MaxEventsPerPublish { get; init; }

    [CommandOption("--transaction-timeout [TRANSACTION-TIMEOUT]")]
    [Description("Defines the maximum amount of time, in seconds, allowed for a transaction to run")]
    public FlagValue<int>? TransactionTimeout { get; init; }

    [CommandOption("--send-initial-update [SEND-INITIAL-UPDATE]")]
    [Description("Indicates if an initial update should be sent out on each tag when the Iot Agent starts up")]
    [DefaultValue(false)]
    public FlagValue<bool>? SendInitialUpdate { get; init; }

    [CommandOption("--http-headers [KEY=VALUE]")]
    [Description("The headers to send to url on each connection")]
    public FlagValue<IDictionary<string, string>>? HttpHeaders { get; set; }

    [CommandOption("--publish-message-format [PUBLISH-MESSAGE-FORMAT]")]
    [IotAgentPublishMessageFormatTypeDescription]
    public FlagValue<IotAgentPublishMessageFormatType>? PublishMessageFormat { get; init; }

    [CommandOption("--publish-media-type [PUBLISH-MEDIA-TYPE]")]
    [IotAgentPublishMediaTypeDescription]
    public FlagValue<IotAgentPublishMediaType>? PublishMediaType { get; init; }

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

        if (Url is not null &&
            Url.IsSet &&
            !urlValidator.IsValid(Url.Value))
        {
            return ValidationResult.Error("--url is not valid.");
        }

        if (Rate is not null &&
            Rate.IsSet &&
            Rate.Value <= 0)
        {
            return ValidationResult.Error("--rate is not valid.");
        }

        if (PublishFormat is not null &&
            PublishFormat.IsSet &&
            PublishFormat.Value == IotAgentPublishFormatType.Narrow &&
            MaxEventsPerPublish is not null &&
            MaxEventsPerPublish.IsSet &&
            MaxEventsPerPublish.Value <= 0)
        {
            return ValidationResult.Error("--max-events-per-publish is not valid.");
        }

        if ((UrlUserName is not null && UrlUserName.IsSet && UrlPassword is not null && !UrlPassword.IsSet) ||
            (UrlUserName is not null && !UrlUserName.IsSet && UrlPassword is not null && UrlPassword.IsSet))
        {
            return ValidationResult.Error("Both url-username and url-password must be set.");
        }

        return ValidationResult.Success();
    }
}