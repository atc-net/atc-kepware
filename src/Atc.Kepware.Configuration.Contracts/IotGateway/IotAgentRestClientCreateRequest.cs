namespace Atc.Kepware.Configuration.Contracts.IotGateway;

public sealed class IotAgentRestClientCreateRequest : IotAgentCreateRequestBase, IIotAgentRestClientCreateRequest
{
    /// <inheritdoc />
    public string Url { get; set; } = string.Empty;

    /// <inheritdoc />
    public IotAgentPublishHttpMethodType PublishHttpMethod { get; set; } = IotAgentPublishHttpMethodType.Post;

    /// <inheritdoc />
    [Range(100, 60000)]
    public int Rate { get; set; } = 10000;

    /// <inheritdoc />
    public IotAgentPublishFormatType PublishFormat { get; set; } = IotAgentPublishFormatType.Narrow;

    /// <inheritdoc />
    public int MaxEventsPerPublish { get; set; } = 1000;

    /// <inheritdoc />
    [Range(1, 30)]
    public int TransactionTimeout { get; set; } = 5;

    /// <inheritdoc />
    public bool SendInitialUpdate { get; set; }

    /// <inheritdoc />
    public string HttpHeaders { get; set; } = string.Empty;

    /// <inheritdoc />
    public IotAgentPublishMessageFormatType PublishMessageFormat { get; set; } = IotAgentPublishMessageFormatType.Advanced;

    /// <inheritdoc />
    public IotAgentPublishMediaType PublishMediaType { get; set; } = IotAgentPublishMediaType.Json;

    /// <inheritdoc />
    public string? UserName { get; set; }

    /// <inheritdoc />
    public string? Password { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Url)}: {Url}, {nameof(PublishHttpMethod)}: {PublishHttpMethod}, {nameof(Rate)}: {Rate}, {nameof(PublishFormat)}: {PublishFormat}, {nameof(MaxEventsPerPublish)}: {MaxEventsPerPublish}, {nameof(TransactionTimeout)}: {TransactionTimeout}, {nameof(SendInitialUpdate)}: {SendInitialUpdate}, {nameof(HttpHeaders)}: {HttpHeaders}, {nameof(PublishMessageFormat)}: {PublishMessageFormat}, {nameof(PublishMediaType)}: {PublishMediaType}, {nameof(UserName)}: {UserName}, {nameof(Password)}: {Password}";
}