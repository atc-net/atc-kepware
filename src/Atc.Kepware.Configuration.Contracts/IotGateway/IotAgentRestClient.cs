namespace Atc.Kepware.Configuration.Contracts.IotGateway;

public sealed class IotAgentRestClient : IotAgentBase, IIotAgentRestClient
{
    /// <inheritdoc />
    public string Url { get; set; } = string.Empty;

    /// <inheritdoc />
    public IotAgentPublishHttpMethodType PublishHttpMethod { get; set; }

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
    public string HttpHeaders { get; set; } = string.Empty;

    /// <inheritdoc />
    public IotAgentPublishMessageFormatType PublishMessageFormat { get; set; }

    /// <inheritdoc />
    public IotAgentPublishMediaType PublishMediaType { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Url)}: {Url}, {nameof(PublishHttpMethod)}: {PublishHttpMethod}, {nameof(Rate)}: {Rate}, {nameof(PublishFormat)}: {PublishFormat}, {nameof(MaxEventsPerPublish)}: {MaxEventsPerPublish}, {nameof(TransactionTimeout)}: {TransactionTimeout}, {nameof(SendInitialUpdate)}: {SendInitialUpdate}, {nameof(HttpHeaders)}: {HttpHeaders}, {nameof(PublishMessageFormat)}: {PublishMessageFormat}, {nameof(PublishMediaType)}: {PublishMediaType}";
}