namespace Atc.Kepware.Configuration.Contracts.Drivers.OpcUaClient.Channel;

/// <summary>
/// Channel properties for the OPC UA Client driver.
/// </summary>
public class OpcUaChannelRequest : ChannelRequestBase
{
    public OpcUaChannelRequest()
        : base(DriverType.OpcUaClient)
    {
    }

    /// <summary>
    /// Specify the unique URL destination of the OPC UA endpoint.
    /// </summary>
    [JsonPropertyName("opcuaclient.CHANNEL_UA_SERVER_ENDPOINT_URL")]
    public string EndpointUrl { get; set; } = string.Empty;

    /// <summary>
    /// Select the endpoint security policy.
    /// </summary>
    [JsonPropertyName("opcuaclient.CHANNEL_UA_SERVER_SECURITY_POLICY")]
    public OpcUaServerSecurityPolicyType ServerSecurityPolicy { get; set; } = OpcUaServerSecurityPolicyType.Basic256Sha256;

    /// <summary>
    /// Select the type of encryption to use for messages between the driver and server.
    /// </summary>
    [JsonPropertyName("opcuaclient.CHANNEL_UA_SERVER_MESSAGE_MODE")]
    public OpcUaServerMessageModeType ServerMessageMode { get; set; } = OpcUaServerMessageModeType.SignAndEncrypt;

    /// <summary>
    /// Specify the maximum amount of time, in seconds,
    /// the channel should wait to successfully connect after making a connect call.
    /// A shorter timeout makes the application more responsive;
    /// a longer timeout gives the channel a better chance of connecting.
    /// </summary>
    [Range(1, 30)]
    [JsonPropertyName("opcuaclient.CHANNEL_UA_SESSION_CONNECT_TIMEOUT_SECONDS")]
    public int ConnectTimeoutSeconds { get; set; } = 30;

    /// <summary>
    /// Specify the maximum amount of time, in minutes, a session remains open without activity.
    /// If the client fails to issue a request within this period, the server terminates the connection.
    /// </summary>
    [Range(1, 20)]
    [JsonPropertyName("opcuaclient.CHANNEL_UA_SESSION_TIMEOUT_INACTIVE_MINUTES")]
    public int SessionTimeoutInactiveMinutes { get; set; } = 20;

    /// <summary>
    /// Specify the time, in minutes, between channel renewals.
    /// The driver refreshes the security of the channel after 75% of this time expires.
    /// Decreasing this time makes the connection more secure, but may slow data transfer.
    /// </summary>
    [Range(10, 60)]
    [JsonPropertyName("opcuaclient.CHANNEL_UA_SESSION_RENEWAL_INTERVAL_MINUTES")]
    public int SessionRenewalIntervalMinutes { get; set; } = 60;

    /// <summary>
    /// Specify the rate, in seconds, at which the channel attempts to reconnect if it fails to connect or becomes disconnected.
    /// </summary>
    [Range(5, 600)]
    [JsonPropertyName("opcuaclient.CHANNEL_UA_SESSION_FAILED_CONNCTION_RETRY_INTERVAL_SECONDS")]
    public int SessionFailedConnectionRetryIntervalSeconds { get; set; } = 5;

    /// <summary>
    /// Specify the rate the client reads the server status state node.
    /// </summary>
    [Range(1, 60)]
    [JsonPropertyName("opcuaclient.CHANNEL_UA_SESSION_WATCHDOG_TIMEOUT")]
    public int SessionWatchdogTimeout { get; set; } = 5;

    /// <summary>
    /// UserName to use when connecting to OPC UA endpoints that require authentication.
    /// </summary>
    [MaxLength(128)]
    [JsonPropertyName("opcuaclient.CHANNEL_AUTHENTICATION_USERNAME")]
    public string? UserName { get; set; }

    /// <summary>
    /// Password to use with the user name when connecting to OPC UA endpoints that require authentication.
    /// </summary>
    [MaxLength(512)]
    [JsonPropertyName("opcuaclient.CHANNEL_AUTHENTICATION_PASSWORD")]
    public string? Password { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(EndpointUrl)}: {EndpointUrl}, {nameof(ServerSecurityPolicy)}: {ServerSecurityPolicy}, {nameof(ServerMessageMode)}: {ServerMessageMode}, {nameof(ConnectTimeoutSeconds)}: {ConnectTimeoutSeconds}, {nameof(SessionTimeoutInactiveMinutes)}: {SessionTimeoutInactiveMinutes}, {nameof(SessionRenewalIntervalMinutes)}: {SessionRenewalIntervalMinutes}, {nameof(SessionFailedConnectionRetryIntervalSeconds)}: {SessionFailedConnectionRetryIntervalSeconds}, {nameof(SessionWatchdogTimeout)}: {SessionWatchdogTimeout}, {nameof(UserName)}: {UserName}, {nameof(Password)}: {Password}";
}