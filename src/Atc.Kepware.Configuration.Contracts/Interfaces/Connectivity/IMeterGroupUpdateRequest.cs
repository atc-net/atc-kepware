namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity;

/// <summary>
/// Base interface for meter group update requests.
/// </summary>
/// <remarks>
/// Meter groups are auto-generated and can only be updated (not created or deleted).
/// </remarks>
public interface IMeterGroupUpdateRequest
{
    /// <summary>
    /// Name of the meter group (1-256 characters).
    /// </summary>
    string? Name { get; set; }

    /// <summary>
    /// Description of the meter group (0-255 characters).
    /// </summary>
    string? Description { get; set; }
}
