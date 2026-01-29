namespace Atc.Kepware.Configuration.Contracts.IotGateway;

public sealed class IotAgentRestServerCreateRequest : IotAgentCreateRequestBase, IIotAgentRestServerCreateRequest
{
    /// <inheritdoc />
    [Range(1, 65535)]
    public int Port { get; set; } = 39320;

    /// <inheritdoc />
    public bool AllowAnonymous { get; set; }

    /// <inheritdoc />
    public bool AllowWrite { get; set; }

    /// <inheritdoc />
    public string CorsAllowedOrigins { get; set; } = "*";

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Port)}: {Port}, {nameof(AllowAnonymous)}: {AllowAnonymous}, {nameof(AllowWrite)}: {AllowWrite}, {nameof(CorsAllowedOrigins)}: {CorsAllowedOrigins}";
}