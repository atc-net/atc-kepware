namespace Atc.Kepware.Configuration.KepwareContracts.IotGateway;

internal sealed class IotAgentRestServerUpdateRequest : IotAgentUpdateRequestBase, IIotAgentRestServerUpdateRequest
{
    /// <inheritdoc />
    [Range(1, 65535)]
    [JsonPropertyName("iot_gateway.REST_SERVER_PORT")]
    public int? Port { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.REST_SERVER_ALLOW_ANONYMOUS")]
    public bool? AllowAnonymous { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.REST_SERVER_ALLOW_WRITE")]
    public bool? AllowWrite { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.REST_SERVER_CORS_ORIGIN")]
    public string? CorsAllowedOrigins { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Port)}: {Port}, {nameof(AllowAnonymous)}: {AllowAnonymous}, {nameof(AllowWrite)}: {AllowWrite}, {nameof(CorsAllowedOrigins)}: {CorsAllowedOrigins}";
}