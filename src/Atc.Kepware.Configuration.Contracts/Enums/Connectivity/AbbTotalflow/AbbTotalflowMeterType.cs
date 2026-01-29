// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Specifies the meter type, which must match the application type configured for the meter in PCCU.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/abb_totalflow_meters
/// Section: abb_totalflow.METER_TYPE
/// </remarks>
public enum AbbTotalflowMeterType
{
    /// <summary>
    /// Gas meter type.
    /// </summary>
    Gas = 0,

    /// <summary>
    /// Liquid meter type.
    /// </summary>
    Liquid = 1,
}
