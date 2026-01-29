namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Devices.Create;

public class DeviceCreateThermoWestronicsEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--device-id")]
    [Description("Device IP address (e.g., \"192.168.1.1\")")]
    public string DeviceId { get; init; } = string.Empty;

    [CommandOption("--port")]
    [Description("TCP/IP port number")]
    [DefaultValue(502)]
    public int Port { get; init; } = 502;

    [CommandOption("--connect-timeout")]
    [Description("Connection timeout in seconds")]
    [DefaultValue(3)]
    public int ConnectTimeoutSeconds { get; init; } = 3;

    [CommandOption("--request-timeout")]
    [Description("Request timeout in milliseconds")]
    [DefaultValue(1000)]
    public int RequestTimeoutMs { get; init; } = 1000;

    [CommandOption("--retry-attempts")]
    [Description("Number of retry attempts")]
    [DefaultValue(3)]
    public int RetryAttempts { get; init; } = 3;

    [CommandOption("--demote-on-failure")]
    [Description("Demote device on communication failures")]
    [DefaultValue(false)]
    public bool DemoteOnFailure { get; init; }

    [CommandOption("--timeouts-to-demote")]
    [Description("Successive timeouts before demotion")]
    [DefaultValue(3)]
    public int TimeoutsToDemote { get; init; } = 3;

    [CommandOption("--demotion-period")]
    [Description("Demotion period in milliseconds")]
    [DefaultValue(10000)]
    public int DemotionPeriodMs { get; init; } = 10000;

    [CommandOption("--discard-requests-when-demoted")]
    [Description("Discard write requests when demoted")]
    [DefaultValue(false)]
    public bool DiscardRequestsWhenDemoted { get; init; }
}