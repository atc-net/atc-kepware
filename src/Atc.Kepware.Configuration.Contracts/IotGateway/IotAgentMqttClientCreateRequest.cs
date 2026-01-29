namespace Atc.Kepware.Configuration.Contracts.IotGateway;

public sealed class IotAgentMqttClientCreateRequest : IotAgentCreateRequestBase, IIotAgentMqttClientCreateRequest
{
    /// <inheritdoc />
    public string Url { get; set; } = string.Empty;

    /// <inheritdoc />
    public string Topic { get; set; } = string.Empty;

    /// <inheritdoc />
    public string ClientId { get; set; } = string.Empty;

    /// <inheritdoc />
    public IotAgentMqttQualityOfServiceLevel Qos { get; set; } = IotAgentMqttQualityOfServiceLevel.AtMostOnce;

    /// <inheritdoc />
    [Range(10, 99999990)]
    public int Rate { get; set; } = 10000;

    /// <inheritdoc />
    public IotAgentPublishFormatType PublishFormat { get; set; } = IotAgentPublishFormatType.Narrow;

    /// <inheritdoc />
    public int MaxEventsPerPublish { get; set; } = 1000;

    /// <inheritdoc />
    [Range(1, 60)]
    public int TransactionTimeout { get; set; } = 5;

    /// <inheritdoc />
    public bool SendInitialUpdate { get; set; }

    /// <inheritdoc />
    public IotAgentPublishMessageFormatType PublishMessageFormat { get; set; } = IotAgentPublishMessageFormatType.Advanced;

    /// <inheritdoc />
    public string? UserName { get; set; }

    /// <inheritdoc />
    public string? Password { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Url)}: {Url}, {nameof(Topic)}: {Topic}, {nameof(ClientId)}: {ClientId}, {nameof(Qos)}: {Qos}, {nameof(Rate)}: {Rate}, {nameof(PublishFormat)}: {PublishFormat}, {nameof(MaxEventsPerPublish)}: {MaxEventsPerPublish}, {nameof(TransactionTimeout)}: {TransactionTimeout}, {nameof(SendInitialUpdate)}: {SendInitialUpdate}, {nameof(PublishMessageFormat)}: {PublishMessageFormat}, {nameof(UserName)}: {UserName}, {nameof(Password)}: {Password}";
}