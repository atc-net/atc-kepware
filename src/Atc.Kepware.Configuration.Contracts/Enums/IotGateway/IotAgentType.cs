// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Specifies the type of agent.
/// </summary>
public enum IotAgentType
{
    None,

    [Description("MQTT Client")]
    MqttClient,

    [Description("REST Client")]
    RestClient,

    [Description("REST Server")]
    RestServer,
}