namespace Atc.Kepware.Configuration.Contracts.IotGateway;

public sealed class IotAgentMqttClientUpdateRequest : IotAgentUpdateRequestBase, IIotAgentMqttClientUpdateRequest
{
    /// <inheritdoc />
    public string? Url { get; set; }

    /// <inheritdoc />
    public string? Topic { get; set; }

    /// <inheritdoc />
    public string? ClientId { get; set; }

    /// <inheritdoc />
    public IotAgentMqttQualityOfServiceLevel? Qos { get; set; }

    /// <inheritdoc />
    [Range(10, 99999990)]
    public int? Rate { get; set; }

    /// <inheritdoc />
    public IotAgentPublishFormatType? PublishFormat { get; set; }

    /// <inheritdoc />
    public int? MaxEventsPerPublish { get; set; }

    /// <inheritdoc />
    [Range(1, 60)]
    public int? TransactionTimeout { get; set; }

    /// <inheritdoc />
    public bool? SendInitialUpdate { get; set; }

    /// <inheritdoc />
    public IotAgentPublishMessageFormatType? PublishMessageFormat { get; set; }

    /// <inheritdoc />
    public string? UserName { get; set; }

    /// <inheritdoc />
    public string? Password { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Url)}: {Url}, {nameof(Topic)}: {Topic}, {nameof(ClientId)}: {ClientId}, {nameof(Qos)}: {Qos}, {nameof(Rate)}: {Rate}, {nameof(PublishFormat)}: {PublishFormat}, {nameof(MaxEventsPerPublish)}: {MaxEventsPerPublish}, {nameof(TransactionTimeout)}: {TransactionTimeout}, {nameof(SendInitialUpdate)}: {SendInitialUpdate}, {nameof(PublishMessageFormat)}: {PublishMessageFormat}, {nameof(UserName)}: {UserName}, {nameof(Password)}: {Password}";
}