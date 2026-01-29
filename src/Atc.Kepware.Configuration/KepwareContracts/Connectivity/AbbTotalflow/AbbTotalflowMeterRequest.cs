namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AbbTotalflow;

/// <summary>
/// Request for creating or updating an ABB Totalflow meter with JSON serialization attributes.
/// </summary>
internal sealed class AbbTotalflowMeterRequest : MeterRequestBase, IAbbTotalflowMeterRequest
{
    /// <inheritdoc />
    [JsonPropertyName("abb_totalflow.METER_TYPE")]
    public AbbTotalflowMeterType MeterType { get; set; } = AbbTotalflowMeterType.Gas;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(MeterType)}: {MeterType}";
}
