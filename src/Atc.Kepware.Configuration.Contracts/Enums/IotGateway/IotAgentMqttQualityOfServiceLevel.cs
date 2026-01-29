// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Specifies the MQTT Quality of Service level for message delivery.
/// </summary>
public enum IotAgentMqttQualityOfServiceLevel
{
    /// <summary>
    /// At most once delivery (fire and forget).
    /// </summary>
    AtMostOnce = 0,

    /// <summary>
    /// At least once delivery (acknowledged delivery).
    /// </summary>
    AtLeastOnce = 1,

    /// <summary>
    /// Exactly once delivery (assured delivery).
    /// </summary>
    ExactlyOnce = 2,
}