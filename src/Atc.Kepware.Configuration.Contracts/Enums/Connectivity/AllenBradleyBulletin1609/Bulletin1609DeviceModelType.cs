// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// The specific type of device model for Allen-Bradley Bulletin 1609.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Allen-Bradley%20Bulletin%201609/Devices
/// Section: servermain.DEVICE_MODEL
/// </remarks>
public enum Bulletin1609DeviceModelType
{
    Bulletin1609Ups = 0,
    Generic = 1,
}