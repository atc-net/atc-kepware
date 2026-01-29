namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.MqttClient;

/// <summary>
/// Channel properties for the MQTT Client driver.
/// </summary>
internal sealed class MqttClientChannel : ChannelBase, IMqttClientChannel
{
    [JsonPropertyName("mqtt_client.CHANNEL_HOST_ADDRESS")]
    public string Host { get; set; } = "localhost";

    [JsonPropertyName("mqtt_client.CHANNEL_PORT_NUMBER")]
    public int Port { get; set; }

    [JsonPropertyName("mqtt_client.CHANNEL_SSL_TLS")]
    public bool SslTls { get; set; }

    [JsonPropertyName("mqtt_client.CHANNEL_CLIENT_ID")]
    public string? ClientId { get; set; }

    [JsonPropertyName("mqtt_client.CHANNEL_USERNAME")]
    public string? Username { get; set; }

    [JsonPropertyName("mqtt_client.CHANNEL_PASSWORD")]
    public string? Password { get; set; }

    [JsonPropertyName("mqtt_client.CHANNEL_CLIENT_CERTIFICATE")]
    public bool ClientCertificate { get; set; }

    [JsonPropertyName("mqtt_client.CHANNEL_MQTT_SERVER_VERSION")]
    public MqttClientServerVersionType MqttServerVersion { get; set; }

    [JsonPropertyName("mqtt_client.CHANNEL_SUBSCRIPTION_QOS")]
    public MqttClientSubscriptionQosType SubscriptionQos { get; set; }

    [JsonPropertyName("mqtt_client.CHANNEL_CONNECT_TIMEOUT")]
    public int ConnectTimeout { get; set; }

    [JsonPropertyName("mqtt_client.CHANNEL_RECONNECT_MINIMUM")]
    public int ReconnectMinimum { get; set; }

    [JsonPropertyName("mqtt_client.CHANNEL_RECONNECT_MAXIMUM")]
    public int ReconnectMaximum { get; set; }

    [JsonPropertyName("mqtt_client.CHANNEL_KEEP_ALIVE")]
    public int KeepAlive { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(Host)}: {Host}, {nameof(Port)}: {Port}";
}