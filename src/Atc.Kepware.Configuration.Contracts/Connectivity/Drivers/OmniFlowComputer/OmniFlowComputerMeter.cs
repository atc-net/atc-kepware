namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.OmniFlowComputer;

/// <summary>
/// Represents an Omni Flow Computer meter.
/// </summary>
/// <remarks>
/// Omni Flow Computer meters are auto-generated and cannot be created or deleted via API.
/// </remarks>
public sealed class OmniFlowComputerMeter : MeterBase, IOmniFlowComputerMeter
{
    /// <inheritdoc />
    public OmniArchiveNumber HourlyArchiveNumber { get; set; }

    /// <inheritdoc />
    public OmniArchiveNumber DailyArchiveNumber { get; set; }

    /// <inheritdoc />
    public OmniArchiveNumber BatchArchiveNumber { get; set; }

    /// <inheritdoc />
    public OmniLiquidMeterType LiquidMeterType { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(HourlyArchiveNumber)}: {HourlyArchiveNumber}, {nameof(DailyArchiveNumber)}: {DailyArchiveNumber}, {nameof(BatchArchiveNumber)}: {BatchArchiveNumber}, {nameof(LiquidMeterType)}: {LiquidMeterType}";
}