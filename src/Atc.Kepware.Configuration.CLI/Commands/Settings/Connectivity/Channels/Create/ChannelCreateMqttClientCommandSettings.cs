namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Channels.Create;

public class ChannelCreateMqttClientCommandSettings : ChannelCreateCommandBaseSettings
{
    [CommandOption("--host [HOST]")]
    [Description("MQTT server hostname or IP address")]
    public FlagValue<string>? Host { get; init; } = new();

    [CommandOption("--port")]
    [Description("MQTT server port (1-65535)")]
    [DefaultValue(1883)]
    public int Port { get; init; }

    [CommandOption("--ssl-tls")]
    [Description("Enable SSL/TLS encryption")]
    [DefaultValue(false)]
    public bool SslTls { get; init; }

    [CommandOption("--client-id [CLIENT-ID]")]
    [Description("Client ID for MQTT connection")]
    public FlagValue<string>? ClientId { get; init; } = new();

    [CommandOption("--mqtt-username [MQTT-USERNAME]")]
    [Description("Username for MQTT authentication")]
    public FlagValue<string>? MqttUsername { get; init; } = new();

    [CommandOption("--mqtt-password [MQTT-PASSWORD]")]
    [Description("Password for MQTT authentication")]
    public FlagValue<string>? MqttPassword { get; init; } = new();

    [CommandOption("--client-certificate")]
    [Description("Enable client certificate")]
    [DefaultValue(false)]
    public bool ClientCertificate { get; init; }

    [CommandOption("--mqtt-version [MQTT-VERSION]")]
    [Description("MQTT protocol version (Auto, V310, V311)")]
    public FlagValue<MqttClientServerVersionType>? MqttServerVersion { get; init; } = new();

    [CommandOption("--subscription-qos [SUBSCRIPTION-QOS]")]
    [Description("Subscription QoS (AtMostOnce, AtLeastOnce, ExactlyOnce)")]
    public FlagValue<MqttClientSubscriptionQosType>? SubscriptionQos { get; init; } = new();

    [CommandOption("--connect-timeout")]
    [Description("Connection timeout in seconds (1-600)")]
    [DefaultValue(10)]
    public int ConnectTimeout { get; init; }

    [CommandOption("--reconnect-minimum")]
    [Description("Minimum reconnect wait time in seconds (1-43200)")]
    [DefaultValue(10)]
    public int ReconnectMinimum { get; init; }

    [CommandOption("--reconnect-maximum")]
    [Description("Maximum reconnect wait time in seconds (1-43200)")]
    [DefaultValue(10)]
    public int ReconnectMaximum { get; init; }

    [CommandOption("--keep-alive")]
    [Description("Keep-alive interval in seconds (0-65535)")]
    [DefaultValue(60)]
    public int KeepAlive { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (Port < 1 || Port > 65535)
        {
            return ValidationResult.Error("--port must be between 1 and 65535.");
        }

        if (ConnectTimeout < 1 || ConnectTimeout > 600)
        {
            return ValidationResult.Error("--connect-timeout must be between 1 and 600.");
        }

        if (ReconnectMinimum < 1 || ReconnectMinimum > 43200)
        {
            return ValidationResult.Error("--reconnect-minimum must be between 1 and 43200.");
        }

        if (ReconnectMaximum < 1 || ReconnectMaximum > 43200)
        {
            return ValidationResult.Error("--reconnect-maximum must be between 1 and 43200.");
        }

        if (KeepAlive < 0 || KeepAlive > 65535)
        {
            return ValidationResult.Error("--keep-alive must be between 0 and 65535.");
        }

        return ValidationResult.Success();
    }
}