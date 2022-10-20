namespace Atc.Kepware.Configuration.KepwareContracts.IotGateway;

internal abstract class IotAgentCreateRequestBase : IIotAgentCreateRequestBase
{
    /// <inheritdoc />
    [KeyString]
    [JsonPropertyName("common.ALLTYPES_NAME")]
    public string Name { get; set; } = string.Empty;

    /// <inheritdoc />
    [MaxLength(255)]
    [JsonPropertyName("common.ALLTYPES_DESCRIPTION")]
    public string Description { get; set; } = string.Empty;

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.IGNORE_QUALITY_CHANGES")]
    public bool IgnoreQualityChanges { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(IgnoreQualityChanges)}: {IgnoreQualityChanges}";
}