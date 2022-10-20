namespace Atc.Kepware.Configuration.Contracts.IotGateway;

public class IotAgentUpdateRequestBase : IIotAgentUpdateRequestBase
{
    /// <inheritdoc />
    public long ProjectId { get; set; }

    /// <inheritdoc />
    [MaxLength(255)]
    public string? Description { get; set; }

    /// <inheritdoc />
    public bool? IgnoreQualityChanges { get; set; }

    /// <inheritdoc />
    public bool? Enabled { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(ProjectId)}: {ProjectId}, {nameof(Description)}: {Description}, {nameof(IgnoreQualityChanges)}: {IgnoreQualityChanges}, {nameof(Enabled)}: {Enabled}";
}