namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.FisherRocPlusEthernet;

/// <summary>
/// Interface for Fisher ROC Plus Ethernet meter objects.
/// </summary>
public interface IFisherRocPlusEthernetMeter : IMeterBase
{
    /// <summary>
    /// Indicates whether this meter receives non-meter events.
    /// </summary>
    bool NonMeterEvents { get; set; }
}
