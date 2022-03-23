namespace Atc.Kepware.Configuration.Contracts.OpcUaClient;

/// <summary>
/// Channel properties for the OPC UA Client driver.
/// </summary>
public class OpcUaClientChannelRequest : ChannelRequestBase, IOpcUaClientChannelRequest
{
    public OpcUaClientChannelRequest()
        : base(DriverType.OpcUaClient)
    {
    }

    /// <inheritdoc />
    public string EndpointUrl { get; set; } = string.Empty;

    /// <inheritdoc />
    public OpcUaServerSecurityPolicyType ServerSecurityPolicy { get; set; } = OpcUaServerSecurityPolicyType.Basic256Sha256;

    /// <inheritdoc />
    public OpcUaServerMessageModeType ServerMessageMode { get; set; } = OpcUaServerMessageModeType.SignAndEncrypt;

    /// <inheritdoc />
    [Range(1, 30)]
    public int ConnectTimeoutSeconds { get; set; } = 30;

    /// <inheritdoc />
    [Range(1, 20)]
    public int SessionTimeoutInactiveMinutes { get; set; } = 20;

    /// <inheritdoc />
    [Range(10, 60)]
    public int SessionRenewalIntervalMinutes { get; set; } = 60;

    /// <inheritdoc />
    [Range(5, 600)]
    public int SessionFailedConnectionRetryIntervalSeconds { get; set; } = 5;

    /// <inheritdoc />
    [Range(1, 60)]
    public int SessionWatchdogTimeout { get; set; } = 5;

    /// <inheritdoc />
    [MaxLength(128)]
    public string? UserName { get; set; }

    /// <inheritdoc />
    [MaxLength(512)]
    public string? Password { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(EndpointUrl)}: {EndpointUrl}, {nameof(ServerSecurityPolicy)}: {ServerSecurityPolicy}, {nameof(ServerMessageMode)}: {ServerMessageMode}, {nameof(ConnectTimeoutSeconds)}: {ConnectTimeoutSeconds}, {nameof(SessionTimeoutInactiveMinutes)}: {SessionTimeoutInactiveMinutes}, {nameof(SessionRenewalIntervalMinutes)}: {SessionRenewalIntervalMinutes}, {nameof(SessionFailedConnectionRetryIntervalSeconds)}: {SessionFailedConnectionRetryIntervalSeconds}, {nameof(SessionWatchdogTimeout)}: {SessionWatchdogTimeout}, {nameof(UserName)}: {UserName}, {nameof(Password)}: {Password}";
}