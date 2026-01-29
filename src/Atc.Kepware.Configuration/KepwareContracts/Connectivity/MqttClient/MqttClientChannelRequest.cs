namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.MqttClient;

/// <summary>
/// Channel request properties for the MQTT Client driver.
/// </summary>
internal sealed class MqttClientChannelRequest : ChannelRequestBase, IMqttClientChannelRequest
{
    public MqttClientChannelRequest()
        : base(DriverType.MqttClient)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("mqtt_client.CHANNEL_HOST_ADDRESS")]
    public string Host { get; set; } = "localhost";

    /// <inheritdoc />
    [Range(1, 65535)]
    [JsonPropertyName("mqtt_client.CHANNEL_PORT_NUMBER")]
    public int Port { get; set; } = 1883;

    /// <inheritdoc />
    [JsonPropertyName("mqtt_client.CHANNEL_SSL_TLS")]
    public bool SslTls { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("mqtt_client.CHANNEL_CLIENT_ID")]
    public string? ClientId { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("mqtt_client.CHANNEL_USERNAME")]
    public string? Username { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("mqtt_client.CHANNEL_PASSWORD")]
    public string? Password { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("mqtt_client.CHANNEL_CLIENT_CERTIFICATE")]
    public bool ClientCertificate { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("mqtt_client.CHANNEL_MQTT_SERVER_VERSION")]
    public MqttClientServerVersionType MqttServerVersion { get; set; } = MqttClientServerVersionType.Auto;

    /// <inheritdoc />
    [JsonPropertyName("mqtt_client.CHANNEL_SUBSCRIPTION_QOS")]
    public MqttClientSubscriptionQosType SubscriptionQos { get; set; } = MqttClientSubscriptionQosType.AtMostOnce;

    /// <inheritdoc />
    [Range(1, 600)]
    [JsonPropertyName("mqtt_client.CHANNEL_CONNECT_TIMEOUT")]
    public int ConnectTimeout { get; set; } = 10;

    /// <inheritdoc />
    [Range(1, 43200)]
    [JsonPropertyName("mqtt_client.CHANNEL_RECONNECT_MINIMUM")]
    public int ReconnectMinimum { get; set; } = 10;

    /// <inheritdoc />
    [Range(1, 43200)]
    [JsonPropertyName("mqtt_client.CHANNEL_RECONNECT_MAXIMUM")]
    public int ReconnectMaximum { get; set; } = 10;

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("mqtt_client.CHANNEL_KEEP_ALIVE")]
    public int KeepAlive { get; set; } = 60;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Host)}: {Host}, {nameof(Port)}: {Port}";
}