// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Indicate the format of the device ID for an MTConnect Client device.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/MTConnect%20Client/devices
/// Section: servermain.DEVICE_ID_FORMAT
/// </remarks>
[SuppressMessage("Naming", "CA1720:Identifier contains type name", Justification = "Actually means that an integer is formatted as a decimal value")]
public enum MtConnectClientDeviceIdFormatType
{
    /// <summary>
    /// Format the device ID as an octal value.
    /// </summary>
    Octal = 0,

    /// <summary>
    /// Format the device ID as a decimal value.
    /// </summary>
    Decimal = 1,

    /// <summary>
    /// Format the device ID as a hexadecimal value.
    /// </summary>
    Hex = 2,
}
