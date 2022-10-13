namespace Atc.Kepware.Configuration.Contracts.IotGateway;

public class IotAgentRestClient : IotAgentBase, IIotAgentRestClient
{
    public string Url { get; set; } = string.Empty;

    public IotAgentPublishHttpMethodType PublishHttpMethod { get; set; }

    public int Rate { get; set; }

    public IotAgentPublishFormatType PublishFormat { get; set; }

    public int MaxEventsPerPublish { get; set; }

    public int TransactionTimeout { get; set; }

    public bool SendInitialUpdate { get; set; }

    public string HttpHeaders { get; set; } = string.Empty;

    public IotAgentPublishMessageFormatType PublishMessageFormat { get; set; }

    public IotAgentPublishMediaType PublishMediaType { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(Url)}: {Url}, {nameof(PublishHttpMethod)}: {PublishHttpMethod}, {nameof(Rate)}: {Rate}, {nameof(PublishFormat)}: {PublishFormat}, {nameof(MaxEventsPerPublish)}: {MaxEventsPerPublish}, {nameof(TransactionTimeout)}: {TransactionTimeout}, {nameof(SendInitialUpdate)}: {SendInitialUpdate}, {nameof(HttpHeaders)}: {HttpHeaders}, {nameof(PublishMessageFormat)}: {PublishMessageFormat}, {nameof(PublishMediaType)}: {PublishMediaType}";
}