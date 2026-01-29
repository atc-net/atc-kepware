namespace Atc.Kepware.Configuration.Contracts.Interfaces.IotGateway;

public interface IIotAgentMqttClient : IIotAgentBase
{
    /// <summary>
    /// The URL of the MQTT broker endpoint (e.g., tcp://host:port or ssl://host:port).
    /// </summary>
    string Url { get; set; }

    /// <summary>
    /// The topic to publish data to.
    /// </summary>
    string Topic { get; set; }

    /// <summary>
    /// The client identifier used when connecting to the MQTT broker.
    /// </summary>
    string ClientId { get; set; }

    /// <summary>
    /// The Quality of Service level for message delivery.
    /// </summary>
    IotAgentMqttQualityOfServiceLevel Qos { get; set; }

    /// <summary>
    /// Specifies the frequency, in milliseconds, at which the agent pushes data to the endpoint.
    /// </summary>
    int Rate { get; set; }

    /// <summary>
    /// Narrow format produces output based on tags that have changed value or quality.
    /// Wide format produces output that includes all enabled tags in the agent with every scan
    /// regardless of value or quality changes.
    /// </summary>
    IotAgentPublishFormatType PublishFormat { get; set; }

    /// <summary>
    /// The number of tag events the gateway packages in a single transmission when using narrow format.
    /// </summary>
    int MaxEventsPerPublish { get; set; }

    /// <summary>
    /// Defines the maximum amount of time, in seconds, allowed for a transaction to run.
    /// </summary>
    int TransactionTimeout { get; set; }

    /// <summary>
    /// Indicates if an initial update should be sent out on each tag when the Iot Agent starts up.
    /// </summary>
    bool SendInitialUpdate { get; set; }

    /// <summary>
    /// Specifies how the message should be formatted.
    /// </summary>
    IotAgentPublishMessageFormatType PublishMessageFormat { get; set; }
}