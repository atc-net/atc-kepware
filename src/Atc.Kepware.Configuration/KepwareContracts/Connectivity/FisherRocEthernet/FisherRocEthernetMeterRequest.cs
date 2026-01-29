namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.FisherRocEthernet;

/// <summary>
/// Request for creating or updating a Fisher ROC Ethernet meter with JSON serialization attributes.
/// </summary>
internal sealed class FisherRocEthernetMeterRequest : MeterRequestBase, IFisherRocEthernetMeterRequest
{
    /// <inheritdoc />
    [JsonPropertyName("fisher_roc_ethernet.METER_NON_METER_EVENTS")]
    public bool NonMeterEvents { get; set; } = true;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NonMeterEvents)}: {NonMeterEvents}";
}
