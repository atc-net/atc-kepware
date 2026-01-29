// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// The specific type of device model for Allen-Bradley Bulletin 900.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Allen-Bradley%20Bulletin%20900/Devices
/// Section: servermain.DEVICE_MODEL
/// </remarks>
public enum Bulletin900DeviceModelType
{
    [Description("900-TC8")]
    Tc8 = 0,

    [Description("900-TC16")]
    Tc16 = 1,

    [Description("900-TC32")]
    Tc32 = 2,

    [Description("900-TC8 Enhanced")]
    Tc8Enhanced = 3,

    [Description("900-TC16 Enhanced")]
    Tc16Enhanced = 4,
}