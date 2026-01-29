namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity;

/// <summary>
/// Base class for meter creation/update requests with JSON serialization attributes.
/// </summary>
internal abstract class MeterRequestBase : IMeterRequestBase
{
    /// <inheritdoc />
    [JsonPropertyName("common.ALLTYPES_NAME")]
    public string Name { get; set; } = string.Empty;

    /// <inheritdoc />
    [JsonPropertyName("common.ALLTYPES_DESCRIPTION")]
    public string? Description { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}";
}