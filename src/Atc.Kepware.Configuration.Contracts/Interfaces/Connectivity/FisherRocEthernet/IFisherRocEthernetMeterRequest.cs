namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.FisherRocEthernet;

/// <summary>
/// Interface for Fisher ROC Ethernet meter creation/update requests.
/// </summary>
public interface IFisherRocEthernetMeterRequest : IMeterRequestBase
{
    /// <summary>
    /// Set to true to enable this meter to receive non-meter events.
    /// </summary>
    bool NonMeterEvents { get; set; }
}
