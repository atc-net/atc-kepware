namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.OpcXmlDaClient;

/// <summary>
/// Defines the OPC XML-DA Client channel request properties.
/// </summary>
public interface IOpcXmlDaClientChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Gets or sets the URL of the OPC XML-DA server to connect to.
    /// </summary>
    string ServerUrl { get; set; }

    /// <summary>
    /// Gets or sets the keep alive interval in seconds.
    /// </summary>
    /// <remarks>
    /// Specifies the rate at which a GetStatus call is sent to the remote server to check the server's operational status.
    /// When 0 is specified, no Keep Alive is sent.
    /// Valid range: 0-3600 seconds.
    /// </remarks>
    int KeepAlive { get; set; }

    /// <summary>
    /// Gets or sets the path to a file that contains certificates that the client driver should trust.
    /// </summary>
    /// <remarks>
    /// This is required when using SSL.
    /// </remarks>
    string? TrustedCertificatesPath { get; set; }

    /// <summary>
    /// Gets or sets the item path delimiter.
    /// </summary>
    /// <remarks>
    /// Specifies the item path delimiter, which is used in the tag address with the format ItemPath + Delimiter + ItemName.
    /// If the server does not use item paths, then the item path and delimiter are not needed.
    /// </remarks>
    OpcXmlDaClientItemPathDelimiter ItemPathDelimiter { get; set; }

    /// <summary>
    /// Gets or sets the proxy server address.
    /// </summary>
    /// <remarks>
    /// Specifies the address of a proxy server if a proxy is required. Either an IP or a domain name may be used.
    /// </remarks>
    string? ProxyServerAddress { get; set; }

    /// <summary>
    /// Gets or sets the proxy port.
    /// </summary>
    /// <remarks>
    /// Specifies the port used to connect to the proxy.
    /// Valid range: 0-65535.
    /// </remarks>
    int ProxyPort { get; set; }

    /// <summary>
    /// Gets or sets the proxy username.
    /// </summary>
    /// <remarks>
    /// Specifies a username if one is required to connect to the proxy server.
    /// </remarks>
    string? ProxyUsername { get; set; }

    /// <summary>
    /// Gets or sets the proxy password.
    /// </summary>
    /// <remarks>
    /// Specifies a password if one is required to connect to the proxy server.
    /// </remarks>
    string? ProxyPassword { get; set; }

    /// <summary>
    /// Gets or sets the HTTP authentication username.
    /// </summary>
    /// <remarks>
    /// Specifies a username if required by the remote XML-DA server.
    /// </remarks>
    string? HttpAuthUsername { get; set; }

    /// <summary>
    /// Gets or sets the HTTP authentication password.
    /// </summary>
    /// <remarks>
    /// Specifies a password if required by the remote XML-DA server.
    /// </remarks>
    string? HttpAuthPassword { get; set; }
}
