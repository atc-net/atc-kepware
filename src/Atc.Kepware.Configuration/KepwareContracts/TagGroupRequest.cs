namespace Atc.Kepware.Configuration.KepwareContracts;

internal sealed class TagGroupRequest
{
    /// <summary>
    /// Specify the identity of this object.
    /// </summary>
    [JsonPropertyName("common.ALLTYPES_NAME")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Summary of this object or its use.
    /// </summary>
    [MaxLength(255)]
    [JsonPropertyName("common.ALLTYPES_DESCRIPTION")]
    public string Description { get; set; } = string.Empty;

    public override string ToString()
        => $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}";
}