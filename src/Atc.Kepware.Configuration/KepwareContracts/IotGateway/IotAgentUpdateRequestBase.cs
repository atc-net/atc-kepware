namespace Atc.Kepware.Configuration.KepwareContracts.IotGateway;

internal class IotAgentUpdateRequestBase : IIotAgentUpdateRequestBase
{
    /// <summary>
    /// The ProjectId.
    /// </summary>
    [JsonPropertyName("PROJECT_ID")]
    public long ProjectId { get; set; }

    /// <inheritdoc />
    [MaxLength(255)]
    [JsonPropertyName("common.ALLTYPES_DESCRIPTION")]
    public string? Description { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.IGNORE_QUALITY_CHANGES")]
    public bool? IgnoreQualityChanges { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.AGENTTYPES_ENABLED")]
    public bool? Enabled { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(ProjectId)}: {ProjectId}, {nameof(Description)}: {Description}, {nameof(IgnoreQualityChanges)}: {IgnoreQualityChanges}, {nameof(Enabled)}: {Enabled}";
}