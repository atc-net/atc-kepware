namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.AutomationDirectEcom;

/// <summary>
/// The format of the device ID for AutomationDirect ECOM driver.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/AutomationDirect%20ECOM/Devices
/// Section: servermain.DEVICE_ID_FORMAT
/// </remarks>
[SuppressMessage("Naming", "CA1720:Identifier contains type name", Justification = "Matches Kepware API naming convention.")]
public enum AutomationDirectEcomDeviceIdFormatType
{
    Octal = 0,
    Decimal = 1,
    Hex = 2,
}