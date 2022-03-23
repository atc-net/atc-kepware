namespace Atc.Kepware.Configuration.Interfaces.OpcUaClient;

/// <summary>
/// Channel properties for the OPC UA Client driver.
/// </summary>
public interface IOpcUaClientChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Specify the unique URL destination of the OPC UA endpoint.
    /// </summary>
    string EndpointUrl { get; set; }

    /// <summary>
    /// Select the endpoint security policy.
    /// </summary>
    OpcUaServerSecurityPolicyType ServerSecurityPolicy { get; set; }

    /// <summary>
    /// Select the type of encryption to use for messages between the driver and server.
    /// </summary>
    OpcUaServerMessageModeType ServerMessageMode { get; set; }

    /// <summary>
    /// Specify the maximum amount of time, in seconds,
    /// the channel should wait to successfully connect after making a connect call.
    /// A shorter timeout makes the application more responsive;
    /// a longer timeout gives the channel a better chance of connecting.
    /// </summary>
    int ConnectTimeoutSeconds { get; set; }

    /// <summary>
    /// Specify the maximum amount of time, in minutes, a session remains open without activity.
    /// If the client fails to issue a request within this period, the server terminates the connection.
    /// </summary>
    int SessionTimeoutInactiveMinutes { get; set; }

    /// <summary>
    /// Specify the time, in minutes, between channel renewals.
    /// The driver refreshes the security of the channel after 75% of this time expires.
    /// Decreasing this time makes the connection more secure, but may slow data transfer.
    /// </summary>
    int SessionRenewalIntervalMinutes { get; set; }

    /// <summary>
    /// Specify the rate, in seconds, at which the channel attempts to reconnect if it fails to connect or becomes disconnected.
    /// </summary>
    int SessionFailedConnectionRetryIntervalSeconds { get; set; }

    /// <summary>
    /// Specify the rate the client reads the server status state node.
    /// </summary>
    int SessionWatchdogTimeout { get; set; }

    /// <summary>
    /// UserName to use when connecting to OPC UA endpoints that require authentication.
    /// </summary>
    string? UserName { get; set; }

    /// <summary>
    /// Password to use with the user name when connecting to OPC UA endpoints that require authentication.
    /// </summary>
    string? Password { get; set; }
}