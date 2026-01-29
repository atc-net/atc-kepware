// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Select the specific type of device associated with this ID.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Torque%20Tool%20Ethernet/devices
/// Section: servermain.DEVICE_MODEL
/// </remarks>
public enum TorqueToolEthernetDeviceModel
{
    /// <summary>
    /// Open Protocol
    /// </summary>
    OpenProtocol = 0,

    /// <summary>
    /// FEP
    /// </summary>
    Fep = 1,
}