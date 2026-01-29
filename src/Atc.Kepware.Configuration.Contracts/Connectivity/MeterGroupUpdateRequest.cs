namespace Atc.Kepware.Configuration.Contracts.Connectivity;

/// <summary>
/// Base class for meter group update requests.
/// </summary>
/// <remarks>
/// Meter groups are auto-generated and can only be updated (not created or deleted).
/// </remarks>
public class MeterGroupUpdateRequest : IMeterGroupUpdateRequest
{
    /// <inheritdoc />
    [KeyString]
    public string? Name { get; set; }

    /// <inheritdoc />
    [MaxLength(255)]
    public string? Description { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}";
}
