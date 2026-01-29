namespace Atc.Kepware.Configuration.KepwareContracts.IotGateway;

internal sealed class IotAgentMqttClientUpdateRequest : IotAgentUpdateRequestBase, IIotAgentMqttClientUpdateRequest
{
    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.MQTT_CLIENT_URL")]
    public string? Url { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.MQTT_CLIENT_TOPIC")]
    public string? Topic { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.MQTT_CLIENT_CLIENT_ID")]
    public string? ClientId { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.MQTT_CLIENT_QOS")]
    public IotAgentMqttQualityOfServiceLevel? Qos { get; set; }

    /// <inheritdoc />
    [Range(10, 99999990)]
    [JsonPropertyName("iot_gateway.AGENTTYPES_RATE_MS")]
    public int? Rate { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.AGENTTYPES_PUBLISH_FORMAT")]
    public IotAgentPublishFormatType? PublishFormat { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.AGENTTYPES_MAX_EVENTS")]
    public int? MaxEventsPerPublish { get; set; }

    /// <inheritdoc />
    [Range(1, 60)]
    [JsonPropertyName("iot_gateway.AGENTTYPES_TIMEOUT_S")]
    public int? TransactionTimeout { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.AGENTTYPES_SEND_INITIAL_UPDATE")]
    public bool? SendInitialUpdate { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.AGENTTYPES_MESSAGE_FORMAT")]
    public IotAgentPublishMessageFormatType? PublishMessageFormat { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.MQTT_CLIENT_USERNAME")]
    public string? UserName { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.MQTT_CLIENT_PASSWORD")]
    public string? Password { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Url)}: {Url}, {nameof(Topic)}: {Topic}, {nameof(ClientId)}: {ClientId}, {nameof(Qos)}: {Qos}, {nameof(Rate)}: {Rate}, {nameof(PublishFormat)}: {PublishFormat}, {nameof(MaxEventsPerPublish)}: {MaxEventsPerPublish}, {nameof(TransactionTimeout)}: {TransactionTimeout}, {nameof(SendInitialUpdate)}: {SendInitialUpdate}, {nameof(PublishMessageFormat)}: {PublishMessageFormat}, {nameof(UserName)}: {UserName}, {nameof(Password)}: {Password}";
}