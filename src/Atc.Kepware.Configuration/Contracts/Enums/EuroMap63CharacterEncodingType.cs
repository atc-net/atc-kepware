// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Specify the character encoding corresponding to the character definition code page defined by the device.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/EUROMAP%2063/Devices
/// Section: euromap_63.DEVICE_CHARACTER_ENCODING
/// </remarks>
public enum EuroMap63CharacterEncodingType
{
    Utf8 = 0,
    Ansi = 1,
}