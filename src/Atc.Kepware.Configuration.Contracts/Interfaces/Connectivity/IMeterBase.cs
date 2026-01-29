namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity;

/// <summary>
/// Base interface for meter objects.
/// </summary>
public interface IMeterBase
{
    /// <summary>
    /// Name of the meter.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// Description of the meter.
    /// </summary>
    string? Description { get; set; }

    /// <summary>
    /// The driver associated with this meter (read-only from API).
    /// </summary>
    string Driver { get; set; }
}