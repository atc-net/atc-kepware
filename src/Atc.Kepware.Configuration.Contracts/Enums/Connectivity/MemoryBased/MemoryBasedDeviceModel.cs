// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Select the specific type of device associated with this ID. Options depend on the type of communications in use.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Memory%20Based/devices
/// Section: servermain.DEVICE_MODEL
/// </remarks>
public enum MemoryBasedDeviceModel
{
    /// <summary>
    /// Not applicable for Memory Based devices.
    /// </summary>
    [Description("N/A")]
    NotApplicable = 0,
}
