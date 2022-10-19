namespace Atc.Kepware.Configuration.KepwareContracts.IotGateway;

internal sealed class IotAgentEnableDisableRequest
{
    /// <summary>
    /// The ProjectId.
    /// </summary>
    [JsonPropertyName("PROJECT_ID")]
    public long ProjectId { get; set; }

    /// <summary>
    /// Indicates whether the Iot Agent is enabled.
    /// </summary>
    [JsonPropertyName("iot_gateway.AGENTTYPES_ENABLED")]
    public bool Enabled { get; set; }
}