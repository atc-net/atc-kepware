namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity;

/// <summary>
/// Base class for meter objects with JSON serialization attributes.
/// </summary>
internal class MeterBase : IMeterBase
{
    /// <inheritdoc />
    [JsonPropertyName("common.ALLTYPES_NAME")]
    public string Name { get; set; } = string.Empty;

    /// <inheritdoc />
    [JsonPropertyName("common.ALLTYPES_DESCRIPTION")]
    public string? Description { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("servermain.MULTIPLE_TYPES_DEVICE_DRIVER")]
    public string Driver { get; set; } = string.Empty;

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(Driver)}: {Driver}";
}
