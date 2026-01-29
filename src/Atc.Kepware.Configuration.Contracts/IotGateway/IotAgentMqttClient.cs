namespace Atc.Kepware.Configuration.Contracts.IotGateway;

public sealed class IotAgentMqttClient : IotAgentBase, IIotAgentMqttClient
{
    /// <inheritdoc />
    public string Url { get; set; } = string.Empty;

    /// <inheritdoc />
    public string Topic { get; set; } = string.Empty;

    /// <inheritdoc />
    public string ClientId { get; set; } = string.Empty;

    /// <inheritdoc />
    public IotAgentMqttQualityOfServiceLevel Qos { get; set; }

    /// <inheritdoc />
    public int Rate { get; set; }

    /// <inheritdoc />
    public IotAgentPublishFormatType PublishFormat { get; set; }

    /// <inheritdoc />
    public int MaxEventsPerPublish { get; set; }

    /// <inheritdoc />
    public int TransactionTimeout { get; set; }

    /// <inheritdoc />
    public bool SendInitialUpdate { get; set; }

    /// <inheritdoc />
    public IotAgentPublishMessageFormatType PublishMessageFormat { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Url)}: {Url}, {nameof(Topic)}: {Topic}, {nameof(ClientId)}: {ClientId}, {nameof(Qos)}: {Qos}, {nameof(Rate)}: {Rate}, {nameof(PublishFormat)}: {PublishFormat}, {nameof(MaxEventsPerPublish)}: {MaxEventsPerPublish}, {nameof(TransactionTimeout)}: {TransactionTimeout}, {nameof(SendInitialUpdate)}: {SendInitialUpdate}, {nameof(PublishMessageFormat)}: {PublishMessageFormat}";
}