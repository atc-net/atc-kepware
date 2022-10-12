namespace Atc.Kepware.Configuration.KepwareContracts.IotGateway;

internal class IotAgentBase : IIotAgentBase
{
    /// <inheritdoc />
    [JsonPropertyName("PROJECT_ID")]
    public int ProjectId { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("common.ALLTYPES_NAME")]
    public string Name { get; set; } = string.Empty;

    /// <inheritdoc />
    [JsonPropertyName("common.ALLTYPES_DESCRIPTION")]
    public string Description { get; set; } = string.Empty;

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.AGENTTYPES_ENABLED")]
    public bool Enabled { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.AGENTTYPES_TYPE")]
    public string Agent { get; set; } = string.Empty;

    /// <inheritdoc />
    public IotAgentType AgentType
    {
        get
        {
            if (string.IsNullOrEmpty(Agent))
            {
                return IotAgentType.None;
            }

            return Enum<IotAgentType>.TryParse(Agent.Replace(" ", string.Empty, StringComparison.OrdinalIgnoreCase), true, out var agentType)
                ? agentType
                : IotAgentType.None;
        }
    }

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.AGENTTYPES_THIS_AGENT_TOTAL")]
    public int NumberOfIotItems { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(ProjectId)}: {ProjectId}, {nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(Enabled)}: {Enabled}, {nameof(AgentType)}: {AgentType}, {nameof(NumberOfIotItems)}: {NumberOfIotItems}";
}
