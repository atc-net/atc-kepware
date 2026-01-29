namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.FisherRocPlusEthernet;

/// <summary>
/// Request for creating or updating a Fisher ROC Plus Ethernet meter with JSON serialization attributes.
/// </summary>
internal sealed class FisherRocPlusEthernetMeterRequest : MeterRequestBase, IFisherRocPlusEthernetMeterRequest
{
    /// <inheritdoc />
    [JsonPropertyName("fisher_rocplus_ethernet.METER_NON_METER_EVENTS")]
    public bool NonMeterEvents { get; set; } = true;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NonMeterEvents)}: {NonMeterEvents}";
}