namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.FisherRocEthernet;

/// <summary>
/// Request for creating or updating a Fisher ROC Ethernet meter.
/// </summary>
public sealed class FisherRocEthernetMeterRequest : MeterRequestBase, IFisherRocEthernetMeterRequest
{
    /// <inheritdoc />
    public bool NonMeterEvents { get; set; } = true;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NonMeterEvents)}: {NonMeterEvents}";
}