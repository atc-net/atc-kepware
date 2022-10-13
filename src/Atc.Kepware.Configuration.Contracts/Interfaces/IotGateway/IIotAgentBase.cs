namespace Atc.Kepware.Configuration.Contracts.Interfaces.IotGateway;

public interface IIotAgentBase
{
    /// <summary>
    /// The ProjectId.
    /// </summary>
    int ProjectId { get; set; }

    /// <summary>
    /// Name of the Iot Agent.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// Description of the Iot Agent.
    /// </summary>
    string Description { get; set; }

    /// <summary>
    /// Indicates whether the Iot Agent is enabled.
    /// </summary>
    bool Enabled { get; set; }

    /// <summary>
    /// The type of Iot Agent.
    /// </summary>
    IotAgentType AgentType { get; }

    /// <summary>
    /// Total number of tags configured under this agent.
    /// </summary>
    public int NumberOfIotItems { get; set; }
}