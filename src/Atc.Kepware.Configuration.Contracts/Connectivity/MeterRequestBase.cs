namespace Atc.Kepware.Configuration.Contracts.Connectivity;

/// <summary>
/// Base class for meter creation/update requests.
/// </summary>
public abstract class MeterRequestBase : IMeterRequestBase
{
    /// <inheritdoc />
    [KeyString]
    public string Name { get; set; } = string.Empty;

    /// <inheritdoc />
    [MaxLength(255)]
    public string? Description { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}";
}
