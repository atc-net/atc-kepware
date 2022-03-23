namespace Atc.Kepware.Configuration.Contracts.OpcUaClient;

/// <summary>
/// Channel properties for the OPC UA Client driver.
/// </summary>
public class OpcUaClientChannelRequest : ChannelRequestBase
{
    public OpcUaClientChannelRequest()
        : base(DriverType.OpcUaClient)
    {
    }

    /// <summary>
    /// Specify the unique URL destination of the OPC UA endpoint.
    /// </summary>
    public string EndpointUrl { get; set; } = string.Empty;

    /// <summary>
    /// Select the endpoint security policy.
    /// </summary>
    public OpcUaServerSecurityPolicyType ServerSecurityPolicy { get; set; } = OpcUaServerSecurityPolicyType.Basic256Sha256;

    /// <summary>
    /// Select the type of encryption to use for messages between the driver and server.
    /// </summary>
    public OpcUaServerMessageModeType ServerMessageMode { get; set; } = OpcUaServerMessageModeType.SignAndEncrypt;

    /// <summary>
    /// Specify the maximum amount of time, in seconds,
    /// the channel should wait to successfully connect after making a connect call.
    /// A shorter timeout makes the application more responsive;
    /// a longer timeout gives the channel a better chance of connecting.
    /// </summary>
    [Range(1, 30)]
    public int ConnectTimeoutSeconds { get; set; } = 30;

    /// <summary>
    /// Specify the maximum amount of time, in minutes, a session remains open without activity.
    /// If the client fails to issue a request within this period, the server terminates the connection.
    /// </summary>
    [Range(1, 20)]
    public int SessionTimeoutInactiveMinutes { get; set; } = 20;

    /// <summary>
    /// Specify the time, in minutes, between channel renewals.
    /// The driver refreshes the security of the channel after 75% of this time expires.
    /// Decreasing this time makes the connection more secure, but may slow data transfer.
    /// </summary>
    [Range(10, 60)]
    public int SessionRenewalIntervalMinutes { get; set; } = 60;

    /// <summary>
    /// Specify the rate, in seconds, at which the channel attempts to reconnect if it fails to connect or becomes disconnected.
    /// </summary>
    [Range(5, 600)]
    public int SessionFailedConnectionRetryIntervalSeconds { get; set; } = 5;

    /// <summary>
    /// Specify the rate the client reads the server status state node.
    /// </summary>
    [Range(1, 60)]
    public int SessionWatchdogTimeout { get; set; } = 5;

    /// <summary>
    /// UserName to use when connecting to OPC UA endpoints that require authentication.
    /// </summary>
    [MaxLength(128)]
    public string? UserName { get; set; }

    /// <summary>
    /// Password to use with the user name when connecting to OPC UA endpoints that require authentication.
    /// </summary>
    [MaxLength(512)]
    public string? Password { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(EndpointUrl)}: {EndpointUrl}, {nameof(ServerSecurityPolicy)}: {ServerSecurityPolicy}, {nameof(ServerMessageMode)}: {ServerMessageMode}, {nameof(ConnectTimeoutSeconds)}: {ConnectTimeoutSeconds}, {nameof(SessionTimeoutInactiveMinutes)}: {SessionTimeoutInactiveMinutes}, {nameof(SessionRenewalIntervalMinutes)}: {SessionRenewalIntervalMinutes}, {nameof(SessionFailedConnectionRetryIntervalSeconds)}: {SessionFailedConnectionRetryIntervalSeconds}, {nameof(SessionWatchdogTimeout)}: {SessionWatchdogTimeout}, {nameof(UserName)}: {UserName}, {nameof(Password)}: {Password}";
}