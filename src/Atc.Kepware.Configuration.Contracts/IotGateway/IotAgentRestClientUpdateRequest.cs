namespace Atc.Kepware.Configuration.Contracts.IotGateway;

public sealed class IotAgentRestClientUpdateRequest : IotAgentUpdateRequestBase, IIotAgentRestClientUpdateRequest
{
    /// <inheritdoc />
    public string? Url { get; set; }

    /// <inheritdoc />
    public IotAgentPublishHttpMethodType? PublishHttpMethod { get; set; }

    /// <inheritdoc />
    [Range(100, 60000)]
    public int? Rate { get; set; }

    /// <inheritdoc />
    public IotAgentPublishFormatType? PublishFormat { get; set; }

    /// <inheritdoc />
    public int? MaxEventsPerPublish { get; set; }

    /// <inheritdoc />
    [Range(1, 30)]
    public int? TransactionTimeout { get; set; }

    /// <inheritdoc />
    public bool? SendInitialUpdate { get; set; }

    /// <inheritdoc />
    public string? HttpHeaders { get; set; }

    /// <inheritdoc />
    public IotAgentPublishMessageFormatType? PublishMessageFormat { get; set; }

    /// <inheritdoc />
    public IotAgentPublishMediaType? PublishMediaType { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Url)}: {Url}, {nameof(PublishHttpMethod)}: {PublishHttpMethod}, {nameof(Rate)}: {Rate}, {nameof(PublishFormat)}: {PublishFormat}, {nameof(MaxEventsPerPublish)}: {MaxEventsPerPublish}, {nameof(TransactionTimeout)}: {TransactionTimeout}, {nameof(SendInitialUpdate)}: {SendInitialUpdate}, {nameof(HttpHeaders)}: {HttpHeaders}, {nameof(PublishMessageFormat)}: {PublishMessageFormat}, {nameof(PublishMediaType)}: {PublishMediaType}";
}