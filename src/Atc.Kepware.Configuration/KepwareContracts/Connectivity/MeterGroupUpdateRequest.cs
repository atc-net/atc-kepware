namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity;

/// <summary>
/// Base class for meter group update requests with JSON serialization attributes.
/// </summary>
internal class MeterGroupUpdateRequest : IMeterGroupUpdateRequest
{
    /// <inheritdoc />
    [JsonPropertyName("common.ALLTYPES_NAME")]
    public string? Name { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("common.ALLTYPES_DESCRIPTION")]
    public string? Description { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}";
}