namespace Atc.Kepware.Configuration.Contracts.Interfaces.IotGateway;

public interface IIotAgentBase
{
    /// <summary>
    /// The ProjectId.
    /// </summary>
    long ProjectId { get; set; }

    /// <summary>
    /// Name of the Iot Agent.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// Description of the Iot Agent.
    /// </summary>
    string Description { get; set; }

    /// <summary>
    /// Should changes in quality be ignored and not passed on.
    /// Changes in quality are usually from connectivity issues and there could be situations where clients do not want those updates.
    /// </summary>
    public bool IgnoreQualityChanges { get; set; }

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