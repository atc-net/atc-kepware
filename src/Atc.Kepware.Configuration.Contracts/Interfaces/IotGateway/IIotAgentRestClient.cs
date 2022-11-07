namespace Atc.Kepware.Configuration.Contracts.Interfaces.IotGateway;

public interface IIotAgentRestClient : IIotAgentBase
{
    /// <summary>
    /// The IP address or URL and port of the endpoint for the agent connection.
    /// If the endpoint uses an SSL connection, adjust the URl to use 'https://'.
    /// </summary>
    string Url { get; set; }

    /// <summary>
    /// The way the Iot Agent publishes data to the endpoint.
    /// </summary>
    IotAgentPublishHttpMethodType PublishHttpMethod { get; set; }

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
    /// Name-value pairs to be sent to the REST server endpoint.
    /// The information is static and is sent with each connection to the endpoint.
    /// </summary>
    string HttpHeaders { get; set; }

    /// <summary>
    /// Specifies how the message should be formatted.
    /// </summary>
    IotAgentPublishMessageFormatType PublishMessageFormat { get; set; }

    /// <summary>
    /// Specifies the content-type header of the REST client to be specific for the output of the template.
    /// </summary>
    /// <remarks>
    /// This setting is only valid for <see cref="IotAgentPublishMessageFormatType.Advanced"/>.
    /// </remarks>
    IotAgentPublishMediaType PublishMediaType { get; set; }

    /// <summary>
    /// Indicates if the Url endpoint is protected with Basic Authentication.
    /// </summary>
    bool IsBasicAuthenticationEnabled { get; }
}