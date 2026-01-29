// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Specifies the liquid meter type for Omni Flow Computer meters.
/// This type is applied to the EFM configuration when an upload is performed.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/omni_meters
/// Section: omni_flow_computer.METER_LIQUID_METER_TYPE
/// </remarks>
[SuppressMessage("Design", "CA1008:Enums should have zero value", Justification = "Values match Kepware API.")]
public enum OmniLiquidMeterType
{
    /// <summary>
    /// Orifice meter type.
    /// </summary>
    Orifice = 1,

    /// <summary>
    /// Ultrasonic meter type.
    /// </summary>
    Ultrasonic = 2,

    /// <summary>
    /// Coriolis meter type.
    /// </summary>
    Coriolis = 3,

    /// <summary>
    /// Positive Displacement meter type.
    /// </summary>
    PositiveDisplacement = 4,

    /// <summary>
    /// Turbine meter type.
    /// </summary>
    Turbine = 5,

    /// <summary>
    /// Line Pack meter type.
    /// </summary>
    LinePack = 6,
}