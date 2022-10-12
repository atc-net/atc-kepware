namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.OpcUaClient;

public interface IOpcUaClientChannel : IChannelBase
{
    string EndpointUrl { get; set; }

    OpcUaServerSecurityPolicyType ServerSecurityPolicy { get; set; }

    OpcUaServerMessageModeType ServerMessageMode { get; set; }

    int ConnectTimeoutSeconds { get; set; }

    int SessionTimeoutInactiveMinutes { get; set; }

    int SessionRenewalIntervalMinutes { get; set; }

    int SessionFailedConnectionRetryIntervalSeconds { get; set; }

    int SessionWatchdogTimeout { get; set; }

    string? UserName { get; set; }

    string? Password { get; set; }
}