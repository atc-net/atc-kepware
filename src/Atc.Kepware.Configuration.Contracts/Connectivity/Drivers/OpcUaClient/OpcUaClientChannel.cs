namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.OpcUaClient;

public sealed class OpcUaClientChannel : ChannelBase, IOpcUaClientChannel
{
    public string EndpointUrl { get; set; } = string.Empty;

    public OpcUaServerSecurityPolicyType ServerSecurityPolicy { get; set; }

    public OpcUaServerMessageModeType ServerMessageMode { get; set; }

    public int ConnectTimeoutSeconds { get; set; }

    public int SessionTimeoutInactiveMinutes { get; set; }

    public int SessionRenewalIntervalMinutes { get; set; }

    public int SessionFailedConnectionRetryIntervalSeconds { get; set; }

    public int SessionWatchdogTimeout { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }
}