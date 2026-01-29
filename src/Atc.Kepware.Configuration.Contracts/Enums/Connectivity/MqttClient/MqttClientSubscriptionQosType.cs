namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.MqttClient;

/// <summary>
/// MQTT subscription Quality of Service type.
/// </summary>
public enum MqttClientSubscriptionQosType
{
    /// <summary>
    /// At most once (QoS 0).
    /// </summary>
    AtMostOnce = 0,

    /// <summary>
    /// At least once (QoS 1).
    /// </summary>
    AtLeastOnce = 1,

    /// <summary>
    /// Exactly once (QoS 2).
    /// </summary>
    ExactlyOnce = 2,
}