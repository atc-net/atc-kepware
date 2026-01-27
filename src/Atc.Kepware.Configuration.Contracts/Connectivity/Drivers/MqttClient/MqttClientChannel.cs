namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.MqttClient;

/// <summary>
/// Represents an MQTT Client channel.
/// </summary>
public class MqttClientChannel : ChannelBase, IMqttClientChannel
{
    /// <inheritdoc />
    public string Host { get; set; } = "localhost";

    /// <inheritdoc />
    public int Port { get; set; }

    /// <inheritdoc />
    public bool SslTls { get; set; }

    /// <inheritdoc />
    public string? ClientId { get; set; }

    /// <inheritdoc />
    public string? Username { get; set; }

    /// <inheritdoc />
    public string? Password { get; set; }

    /// <inheritdoc />
    public bool ClientCertificate { get; set; }

    /// <inheritdoc />
    public MqttClientServerVersionType MqttServerVersion { get; set; }

    /// <inheritdoc />
    public MqttClientSubscriptionQosType SubscriptionQos { get; set; }

    /// <inheritdoc />
    public int ConnectTimeout { get; set; }

    /// <inheritdoc />
    public int ReconnectMinimum { get; set; }

    /// <inheritdoc />
    public int ReconnectMaximum { get; set; }

    /// <inheritdoc />
    public int KeepAlive { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Host)}: {Host}, {nameof(Port)}: {Port}";
}
