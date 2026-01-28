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
    /// Gets or sets the HTTP timeout in seconds.
    /// </summary>
    /// <remarks>
    /// The maximum amount of time to wait for a response from the server.
    /// Valid range: 1-999 seconds.
    /// </remarks>
    int HttpTimeout { get; set; }

    /// <summary>
    /// Gets or sets the subscription update rate in milliseconds.
    /// </summary>
    /// <remarks>
    /// The rate at which the driver will poll the server for subscription updates.
    /// Valid range: 100-3600000 ms.
    /// </remarks>
    int SubscriptionUpdateRate { get; set; }

    /// <summary>
    /// Gets or sets the read timeout in milliseconds.
    /// </summary>
    /// <remarks>
    /// Valid range: 100-30000 ms.
    /// </remarks>
    int ReadTimeout { get; set; }

    /// <summary>
    /// Gets or sets the write timeout in milliseconds.
    /// </summary>
    /// <remarks>
    /// Valid range: 100-30000 ms.
    /// </remarks>
    int WriteTimeout { get; set; }

    /// <summary>
    /// Gets or sets the locale ID for the server.
    /// </summary>
    /// <remarks>
    /// The locale ID determines the language for text operations.
    /// </remarks>
    string? LocaleId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to use HTTP authentication.
    /// </summary>
    bool UseHttpAuthentication { get; set; }

    /// <summary>
    /// Gets or sets the HTTP authentication user name.
    /// </summary>
    /// <remarks>
    /// Only used when UseHttpAuthentication is enabled.
    /// </remarks>
    string? HttpAuthenticationUserName { get; set; }

    /// <summary>
    /// Gets or sets the HTTP authentication password.
    /// </summary>
    /// <remarks>
    /// Only used when UseHttpAuthentication is enabled.
    /// </remarks>
    string? HttpAuthenticationPassword { get; set; }
}
