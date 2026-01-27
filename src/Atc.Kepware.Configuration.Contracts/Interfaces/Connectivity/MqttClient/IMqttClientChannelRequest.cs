namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.MqttClient;

/// <summary>
/// Defines the MQTT Client channel request properties.
/// </summary>
public interface IMqttClientChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Gets or sets the IP address or host name of the MQTT server.
    /// </summary>
    /// <remarks>
    /// Default: "localhost".
    /// </remarks>
    string Host { get; set; }

    /// <summary>
    /// Gets or sets the port to connect to the MQTT server.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-65535. Default: 1883.
    /// </remarks>
    int Port { get; set; }

    /// <summary>
    /// Gets or sets whether to enable SSL/TLS when connecting.
    /// </summary>
    bool SslTls { get; set; }

    /// <summary>
    /// Gets or sets the client ID used when connecting to the MQTT server.
    /// </summary>
    string? ClientId { get; set; }

    /// <summary>
    /// Gets or sets the username for MQTT server authentication.
    /// </summary>
    string? Username { get; set; }

    /// <summary>
    /// Gets or sets the password for MQTT server authentication.
    /// </summary>
    string? Password { get; set; }

    /// <summary>
    /// Gets or sets whether to send a client certificate to the MQTT server.
    /// </summary>
    bool ClientCertificate { get; set; }

    /// <summary>
    /// Gets or sets the MQTT protocol version.
    /// </summary>
    MqttClientServerVersionType MqttServerVersion { get; set; }

    /// <summary>
    /// Gets or sets the subscription Quality of Service level.
    /// </summary>
    MqttClientSubscriptionQosType SubscriptionQos { get; set; }

    /// <summary>
    /// Gets or sets the connection timeout in seconds.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-600. Default: 10.
    /// </remarks>
    int ConnectTimeout { get; set; }

    /// <summary>
    /// Gets or sets the minimum reconnect wait time in seconds.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-43200. Default: 10.
    /// </remarks>
    int ReconnectMinimum { get; set; }

    /// <summary>
    /// Gets or sets the maximum reconnect wait time in seconds.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-43200. Default: 10.
    /// </remarks>
    int ReconnectMaximum { get; set; }

    /// <summary>
    /// Gets or sets the keep-alive interval in seconds.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-65535. Default: 60.
    /// </remarks>
    int KeepAlive { get; set; }
}
