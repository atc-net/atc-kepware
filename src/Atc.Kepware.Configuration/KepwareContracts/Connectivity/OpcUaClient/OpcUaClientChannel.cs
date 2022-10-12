namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.OpcUaClient;

/// <summary>
/// Channel properties for the OPC UA Client driver.
/// </summary>
internal class OpcUaClientChannel : ChannelBase, IOpcUaClientChannel
{
    [JsonPropertyName("opcuaclient.CHANNEL_UA_SERVER_ENDPOINT_URL")]
    public string EndpointUrl { get; set; } = string.Empty;

    [JsonPropertyName("opcuaclient.CHANNEL_UA_SERVER_SECURITY_POLICY")]
    public OpcUaServerSecurityPolicyType ServerSecurityPolicy { get; set; }

    [JsonPropertyName("opcuaclient.CHANNEL_UA_SERVER_MESSAGE_MODE")]
    public OpcUaServerMessageModeType ServerMessageMode { get; set; }

    [JsonPropertyName("opcuaclient.CHANNEL_UA_SESSION_CONNECT_TIMEOUT_SECONDS")]
    public int ConnectTimeoutSeconds { get; set; }

    [JsonPropertyName("opcuaclient.CHANNEL_UA_SESSION_TIMEOUT_INACTIVE_MINUTES")]
    public int SessionTimeoutInactiveMinutes { get; set; }

    [JsonPropertyName("opcuaclient.CHANNEL_UA_SESSION_RENEWAL_INTERVAL_MINUTES")]
    public int SessionRenewalIntervalMinutes { get; set; }

    [JsonPropertyName("opcuaclient.CHANNEL_UA_SESSION_FAILED_CONNCTION_RETRY_INTERVAL_SECONDS")]
    public int SessionFailedConnectionRetryIntervalSeconds { get; set; }

    [JsonPropertyName("opcuaclient.CHANNEL_UA_SESSION_WATCHDOG_TIMEOUT")]
    public int SessionWatchdogTimeout { get; set; }

    [JsonPropertyName("opcuaclient.CHANNEL_AUTHENTICATION_USERNAME")]
    public string? UserName { get; set; }

    [JsonPropertyName("opcuaclient.CHANNEL_AUTHENTICATION_PASSWORD")]
    public string? Password { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(EndpointUrl)}: {EndpointUrl}, {nameof(ServerSecurityPolicy)}: {ServerSecurityPolicy}, {nameof(ServerMessageMode)}: {ServerMessageMode}, {nameof(ConnectTimeoutSeconds)}: {ConnectTimeoutSeconds}, {nameof(SessionTimeoutInactiveMinutes)}: {SessionTimeoutInactiveMinutes}, {nameof(SessionRenewalIntervalMinutes)}: {SessionRenewalIntervalMinutes}, {nameof(SessionFailedConnectionRetryIntervalSeconds)}: {SessionFailedConnectionRetryIntervalSeconds}, {nameof(SessionWatchdogTimeout)}: {SessionWatchdogTimeout}, {nameof(UserName)}: {UserName}, {nameof(Password)}: {Password}";
}