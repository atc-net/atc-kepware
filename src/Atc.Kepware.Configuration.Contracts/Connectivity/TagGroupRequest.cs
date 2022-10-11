namespace Atc.Kepware.Configuration.Contracts.Connectivity;

public sealed class TagGroupRequest
{
    /// <summary>
    /// The name of the tag.
    /// </summary>
    [KeyString]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Description of the tag.
    /// </summary>
    [MaxLength(255)]
    public string Description { get; set; } = string.Empty;

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}";
}