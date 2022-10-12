namespace Atc.Kepware.Configuration.Contracts.IotGateway;

public abstract class IotAgentRequestBase : IIotAgentRequestBase
{
    /// <inheritdoc />
    [KeyString]
    public string Name { get; set; } = string.Empty;

    /// <inheritdoc />
    [MaxLength(255)]
    public string Description { get; set; } = string.Empty;

    /// <inheritdoc />
    public bool IgnoreQualityChanges { get; set; } = true;

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(IgnoreQualityChanges)}: {IgnoreQualityChanges}";
}