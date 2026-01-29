// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// The model type for an MTConnect Client device.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/MTConnect%20Client/devices
/// Section: servermain.DEVICE_MODEL
/// </remarks>
public enum MtConnectClientDeviceModelType
{
    /// <summary>
    /// MTConnect Agent.
    /// </summary>
    MtConnectAgent = 0,
}
