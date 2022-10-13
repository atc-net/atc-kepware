namespace Atc.Kepware.Configuration.Contracts.IotGateway;

public class IotAgentBase : IIotAgentBase
{
    /// <inheritdoc />
    public int ProjectId { get; set; }

    /// <inheritdoc />
    public string Name { get; set; } = string.Empty;

    /// <inheritdoc />
    public string Description { get; set; } = string.Empty;

    /// <inheritdoc />
    public bool Enabled { get; set; }

    /// <inheritdoc />
    public IotAgentType AgentType { get; set; }

    /// <inheritdoc />
    public int NumberOfIotItems { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(ProjectId)}: {ProjectId}, {nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(Enabled)}: {Enabled}, {nameof(AgentType)}: {AgentType}, {nameof(NumberOfIotItems)}: {NumberOfIotItems}";
}
