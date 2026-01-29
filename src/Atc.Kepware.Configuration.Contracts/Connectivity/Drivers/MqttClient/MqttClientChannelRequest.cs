namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.MqttClient;

/// <summary>
/// Represents an MQTT Client channel creation request.
/// </summary>
public class MqttClientChannelRequest : ChannelRequestBase, IMqttClientChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MqttClientChannelRequest"/> class.
    /// </summary>
    public MqttClientChannelRequest()
        : base(DriverType.MqttClient)
    {
    }

    /// <inheritdoc />
    [MaxLength(1024)]
    public string Host { get; set; } = "localhost";

    /// <inheritdoc />
    [Range(1, 65535)]
    public int Port { get; set; } = 1883;

    /// <inheritdoc />
    public bool SslTls { get; set; }

    /// <inheritdoc />
    [MaxLength(1024)]
    public string? ClientId { get; set; }

    /// <inheritdoc />
    [MaxLength(1024)]
    public string? Username { get; set; }

    /// <inheritdoc />
    [MaxLength(1024)]
    public string? Password { get; set; }

    /// <inheritdoc />
    public bool ClientCertificate { get; set; }

    /// <inheritdoc />
    public MqttClientServerVersionType MqttServerVersion { get; set; } = MqttClientServerVersionType.Auto;

    /// <inheritdoc />
    public MqttClientSubscriptionQosType SubscriptionQos { get; set; } = MqttClientSubscriptionQosType.AtMostOnce;

    /// <inheritdoc />
    [Range(1, 600)]
    public int ConnectTimeout { get; set; } = 10;

    /// <inheritdoc />
    [Range(1, 43200)]
    public int ReconnectMinimum { get; set; } = 10;

    /// <inheritdoc />
    [Range(1, 43200)]
    public int ReconnectMaximum { get; set; } = 10;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int KeepAlive { get; set; } = 60;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Host)}: {Host}, {nameof(Port)}: {Port}";
}