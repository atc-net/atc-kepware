namespace Atc.Kepware.Configuration.CLI.Commands.Settings.IotGateway;

public sealed class IotAgentUpdateMqttClientCommandSettings : IotAgentUpdateCommandBaseSettings
{
    [CommandOption("--url [URL]")]
    [Description("The URL of the MQTT broker endpoint (e.g., tcp://host:port or ssl://host:port)")]
    public FlagValue<string>? Url { get; init; }

    [CommandOption("--topic [TOPIC]")]
    [Description("The topic to publish data to")]
    public FlagValue<string>? Topic { get; init; }

    [CommandOption("--client-id [CLIENT-ID]")]
    [Description("The client identifier used when connecting to the MQTT broker")]
    public FlagValue<string>? ClientId { get; init; }

    [CommandOption("--qos [QOS]")]
    [Description("The Quality of Service level (AtMostOnce=0, AtLeastOnce=1, ExactlyOnce=2)")]
    public FlagValue<IotAgentMqttQualityOfServiceLevel>? Qos { get; init; }

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
    public FlagValue<bool>? SendInitialUpdate { get; init; }

    [CommandOption("--publish-message-format [PUBLISH-MESSAGE-FORMAT]")]
    [IotAgentPublishMessageFormatTypeDescription]
    public FlagValue<IotAgentPublishMessageFormatType>? PublishMessageFormat { get; init; }

    [CommandOption("--mqtt-username [MQTT-USERNAME]")]
    [Description("The username to use when connecting to the MQTT broker")]
    public FlagValue<string>? MqttUserName { get; init; }

    [CommandOption("--mqtt-password [MQTT-PASSWORD]")]
    [Description("The password to use when connecting to the MQTT broker")]
    public FlagValue<string>? MqttPassword { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
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

        if ((MqttUserName is not null && MqttUserName.IsSet && MqttPassword is not null && !MqttPassword.IsSet) ||
            (MqttUserName is not null && !MqttUserName.IsSet && MqttPassword is not null && MqttPassword.IsSet))
        {
            return ValidationResult.Error("Both mqtt-username and mqtt-password must be set.");
        }

        return ValidationResult.Success();
    }
}