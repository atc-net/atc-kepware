namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.AbbTotalflow;

/// <summary>
/// Interface for ABB Totalflow meter creation/update requests.
/// </summary>
public interface IAbbTotalflowMeterRequest : IMeterRequestBase
{
    /// <summary>
    /// Specifies the meter type, which must match the application type configured for the meter in PCCU.
    /// </summary>
    AbbTotalflowMeterType MeterType { get; set; }
}
