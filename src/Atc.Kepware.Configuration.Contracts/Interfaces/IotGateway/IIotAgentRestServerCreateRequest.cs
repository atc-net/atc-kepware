namespace Atc.Kepware.Configuration.Contracts.Interfaces.IotGateway;

public interface IIotAgentRestServerCreateRequest : IIotAgentCreateRequestBase
{
    /// <summary>
    /// The port number the REST server listens on.
    /// </summary>
    int Port { get; set; }

    /// <summary>
    /// Indicates whether anonymous connections are allowed (skip User Manager validation).
    /// </summary>
    bool AllowAnonymous { get; set; }

    /// <summary>
    /// Indicates whether write operations are enabled.
    /// </summary>
    bool AllowWrite { get; set; }

    /// <summary>
    /// The CORS allowed origins (* for all, or specific origins).
    /// </summary>
    string CorsAllowedOrigins { get; set; }
}