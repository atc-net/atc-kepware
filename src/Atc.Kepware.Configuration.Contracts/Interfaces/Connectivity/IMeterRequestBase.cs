namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity;

/// <summary>
/// Base interface for meter creation/update requests.
/// </summary>
public interface IMeterRequestBase
{
    /// <summary>
    /// Name of the meter (1-256 characters).
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// Description of the meter (0-255 characters).
    /// </summary>
    string? Description { get; set; }
}
