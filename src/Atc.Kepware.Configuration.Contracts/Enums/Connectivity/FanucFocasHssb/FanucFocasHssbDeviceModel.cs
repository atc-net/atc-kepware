// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Select the specific type of device associated with this ID.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Fanuc%20Focas%20HSSB/devices
/// Section: servermain.DEVICE_MODEL
/// </remarks>
public enum FanucFocasHssbDeviceModel
{
    /// <summary>
    /// Series 15i.
    /// </summary>
    Series15i = 0,

    /// <summary>
    /// Series 16i.
    /// </summary>
    Series16i = 1,

    /// <summary>
    /// Series 18i.
    /// </summary>
    Series18i = 2,

    /// <summary>
    /// Series 21i.
    /// </summary>
    Series21i = 3,

    /// <summary>
    /// Power Mate i.
    /// </summary>
    PowerMateI = 4,

    /// <summary>
    /// Open.
    /// </summary>
    Open = 5,
}