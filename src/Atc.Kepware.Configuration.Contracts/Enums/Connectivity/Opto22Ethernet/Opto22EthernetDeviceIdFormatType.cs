namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.Opto22Ethernet;

/// <summary>
/// The format of the device ID for Opto 22 Ethernet driver.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Opto%2022%20Ethernet/devices
/// Section: servermain.DEVICE_ID_FORMAT
/// </remarks>
[SuppressMessage("Naming", "CA1720:Identifier contains type name", Justification = "Matches Kepware API naming convention.")]
public enum Opto22EthernetDeviceIdFormatType
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
