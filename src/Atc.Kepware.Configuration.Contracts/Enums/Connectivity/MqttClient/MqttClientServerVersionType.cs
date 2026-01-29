namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.MqttClient;

/// <summary>
/// MQTT server version type.
/// </summary>
public enum MqttClientServerVersionType
{
    /// <summary>
    /// Auto-detect MQTT version.
    /// </summary>
    Auto = 0,

    /// <summary>
    /// MQTT version 3.1.0.
    /// </summary>
    V310 = 3,

    /// <summary>
    /// MQTT version 3.1.1.
    /// </summary>
    V311 = 4,
}