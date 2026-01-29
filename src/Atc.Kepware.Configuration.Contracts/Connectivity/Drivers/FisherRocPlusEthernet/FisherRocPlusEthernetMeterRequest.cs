namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.FisherRocPlusEthernet;

/// <summary>
/// Request for creating or updating a Fisher ROC Plus Ethernet meter.
/// </summary>
public sealed class FisherRocPlusEthernetMeterRequest : MeterRequestBase, IFisherRocPlusEthernetMeterRequest
{
    /// <inheritdoc />
    public bool NonMeterEvents { get; set; } = true;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NonMeterEvents)}: {NonMeterEvents}";
}