namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.OmniFlowComputer;

/// <summary>
/// Represents an Omni Flow Computer meter with JSON serialization attributes.
/// </summary>
internal sealed class OmniFlowComputerMeter : MeterBase, IOmniFlowComputerMeter
{
    /// <inheritdoc />
    [JsonPropertyName("omni_flow_computer.METER_HOURLY_ARCHIVE_NUMBER")]
    public OmniArchiveNumber HourlyArchiveNumber { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("omni_flow_computer.METER_DAILY_ARCHIVE_NUMBER")]
    public OmniArchiveNumber DailyArchiveNumber { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("omni_flow_computer.METER_BATCH_ARCHIVE_NUMBER")]
    public OmniArchiveNumber BatchArchiveNumber { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("omni_flow_computer.METER_LIQUID_METER_TYPE")]
    public OmniLiquidMeterType LiquidMeterType { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(HourlyArchiveNumber)}: {HourlyArchiveNumber}, {nameof(DailyArchiveNumber)}: {DailyArchiveNumber}, {nameof(BatchArchiveNumber)}: {BatchArchiveNumber}, {nameof(LiquidMeterType)}: {LiquidMeterType}";
}
