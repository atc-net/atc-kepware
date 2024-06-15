// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Select the specific type of device associated with this ID. Options depend on the type of communications in use.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Simulator/devices
/// Section: servermain.DEVICE_MODEL
/// </remarks>
public enum SimulatorDeviceModel
{
    /// <summary>
    /// 16 bit device
    /// </summary>
    SixteenBit = 0,

    /// <summary>
    /// 8 bit device
    /// </summary>
    EightBit = 1,
}
