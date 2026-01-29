namespace Atc.Kepware.Configuration.Contracts.Connectivity;

/// <summary>
/// Base class for meter objects.
/// </summary>
public class MeterBase : IMeterBase
{
    /// <inheritdoc />
    public string Name { get; set; } = string.Empty;

    /// <inheritdoc />
    public string? Description { get; set; }

    /// <inheritdoc />
    public string Driver { get; set; } = string.Empty;

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(Driver)}: {Driver}";
}
