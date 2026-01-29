namespace Atc.Kepware.Configuration.CLI.Commands.Settings.IotGateway.IotAgent.Create;

public sealed class IotAgentCreateMqttClientCommandSettings : IotAgentCreateCommandBaseSettings
{
    [CommandOption("--url <URL>")]
    [Description("The URL of the MQTT broker endpoint (e.g., tcp://host:port or ssl://host:port)")]
    public string Url { get; init; } = string.Empty;

    [CommandOption("--topic <TOPIC>")]
    [Description("The topic to publish data to")]
    public string Topic { get; init; } = string.Empty;

    [CommandOption("--client-id <CLIENT-ID>")]
    [Description("The client identifier used when connecting to the MQTT broker")]
    public string ClientId { get; init; } = string.Empty;

    [CommandOption("--qos <QOS>")]
    [Description("The Quality of Service level (AtMostOnce=0, AtLeastOnce=1, ExactlyOnce=2)")]
    [DefaultValue(IotAgentMqttQualityOfServiceLevel.AtMostOnce)]
    public IotAgentMqttQualityOfServiceLevel Qos { get; init; }

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

    [CommandOption("--publish-message-format <PUBLISH-MESSAGE-FORMAT>")]
    [IotAgentPublishMessageFormatTypeDescription]
    public IotAgentPublishMessageFormatType PublishMessageFormat { get; init; }

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

        if (string.IsNullOrWhiteSpace(Url))
        {
            return ValidationResult.Error("--url is not set or not valid.");
        }

        if (string.IsNullOrWhiteSpace(Topic))
        {
            return ValidationResult.Error("--topic is not set or not valid.");
        }

        if (string.IsNullOrWhiteSpace(ClientId))
        {
            return ValidationResult.Error("--client-id is not set or not valid.");
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

        if ((MqttUserName is not null && MqttUserName.IsSet && MqttPassword is not null && !MqttPassword.IsSet) ||
            (MqttUserName is not null && !MqttUserName.IsSet && MqttPassword is not null && MqttPassword.IsSet))
        {
            return ValidationResult.Error("Both mqtt-username and mqtt-password must be set.");
        }

        return ValidationResult.Success();
    }
}