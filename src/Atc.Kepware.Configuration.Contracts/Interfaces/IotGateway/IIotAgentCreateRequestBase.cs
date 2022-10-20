namespace Atc.Kepware.Configuration.Contracts.Interfaces.IotGateway;

public interface IIotAgentCreateRequestBase
{
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
    bool IgnoreQualityChanges { get; set; }
}