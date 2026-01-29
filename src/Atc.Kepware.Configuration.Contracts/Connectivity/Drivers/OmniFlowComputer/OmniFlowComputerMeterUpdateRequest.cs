namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.OmniFlowComputer;

/// <summary>
/// Request for updating an Omni Flow Computer meter.
/// </summary>
/// <remarks>
/// Omni Flow Computer meters are auto-generated and can only be updated (not created or deleted).
/// </remarks>
public sealed class OmniFlowComputerMeterUpdateRequest : IOmniFlowComputerMeterUpdateRequest
{
    /// <inheritdoc />
    [KeyString]
    public string? Name { get; set; }

    /// <inheritdoc />
    [MaxLength(255)]
    public string? Description { get; set; }

    /// <inheritdoc />
    public OmniArchiveNumber? HourlyArchiveNumber { get; set; }

    /// <inheritdoc />
    public OmniArchiveNumber? DailyArchiveNumber { get; set; }

    /// <inheritdoc />
    public OmniArchiveNumber? BatchArchiveNumber { get; set; }

    /// <inheritdoc />
    public OmniLiquidMeterType? LiquidMeterType { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(HourlyArchiveNumber)}: {HourlyArchiveNumber}, {nameof(DailyArchiveNumber)}: {DailyArchiveNumber}, {nameof(BatchArchiveNumber)}: {BatchArchiveNumber}, {nameof(LiquidMeterType)}: {LiquidMeterType}";
}