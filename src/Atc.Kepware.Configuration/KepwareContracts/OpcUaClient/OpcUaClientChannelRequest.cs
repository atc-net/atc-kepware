namespace Atc.Kepware.Configuration.KepwareContracts.OpcUaClient;

/// <summary>
/// Channel properties for the OPC UA Client driver.
/// </summary>
internal class OpcUaClientChannelRequest : ChannelRequestBase, IOpcUaClientChannelRequest
{
    public OpcUaClientChannelRequest()
        : base(DriverType.OpcUaClient)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("opcuaclient.CHANNEL_UA_SERVER_ENDPOINT_URL")]
    public string EndpointUrl { get; set; } = string.Empty;

    /// <inheritdoc />
    [JsonPropertyName("opcuaclient.CHANNEL_UA_SERVER_SECURITY_POLICY")]
    public OpcUaServerSecurityPolicyType ServerSecurityPolicy { get; set; } = OpcUaServerSecurityPolicyType.Basic256Sha256;

    /// <inheritdoc />
    [JsonPropertyName("opcuaclient.CHANNEL_UA_SERVER_MESSAGE_MODE")]
    public OpcUaServerMessageModeType ServerMessageMode { get; set; } = OpcUaServerMessageModeType.SignAndEncrypt;

    /// <inheritdoc />
    [Range(1, 30)]
    [JsonPropertyName("opcuaclient.CHANNEL_UA_SESSION_CONNECT_TIMEOUT_SECONDS")]
    public int ConnectTimeoutSeconds { get; set; } = 30;

    /// <inheritdoc />
    [Range(1, 20)]
    [JsonPropertyName("opcuaclient.CHANNEL_UA_SESSION_TIMEOUT_INACTIVE_MINUTES")]
    public int SessionTimeoutInactiveMinutes { get; set; } = 20;

    /// <inheritdoc />
    [Range(10, 60)]
    [JsonPropertyName("opcuaclient.CHANNEL_UA_SESSION_RENEWAL_INTERVAL_MINUTES")]
    public int SessionRenewalIntervalMinutes { get; set; } = 60;

    /// <inheritdoc />
    [Range(5, 600)]
    [JsonPropertyName("opcuaclient.CHANNEL_UA_SESSION_FAILED_CONNCTION_RETRY_INTERVAL_SECONDS")]
    public int SessionFailedConnectionRetryIntervalSeconds { get; set; } = 5;

    /// <inheritdoc />
    [Range(1, 60)]
    [JsonPropertyName("opcuaclient.CHANNEL_UA_SESSION_WATCHDOG_TIMEOUT")]
    public int SessionWatchdogTimeout { get; set; } = 5;

    /// <inheritdoc />
    [MaxLength(128)]
    [JsonPropertyName("opcuaclient.CHANNEL_AUTHENTICATION_USERNAME")]
    public string? UserName { get; set; }

    /// <inheritdoc />
    [MaxLength(512)]
    [JsonPropertyName("opcuaclient.CHANNEL_AUTHENTICATION_PASSWORD")]
    public string? Password { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(EndpointUrl)}: {EndpointUrl}, {nameof(ServerSecurityPolicy)}: {ServerSecurityPolicy}, {nameof(ServerMessageMode)}: {ServerMessageMode}, {nameof(ConnectTimeoutSeconds)}: {ConnectTimeoutSeconds}, {nameof(SessionTimeoutInactiveMinutes)}: {SessionTimeoutInactiveMinutes}, {nameof(SessionRenewalIntervalMinutes)}: {SessionRenewalIntervalMinutes}, {nameof(SessionFailedConnectionRetryIntervalSeconds)}: {SessionFailedConnectionRetryIntervalSeconds}, {nameof(SessionWatchdogTimeout)}: {SessionWatchdogTimeout}, {nameof(UserName)}: {UserName}, {nameof(Password)}: {Password}";
}