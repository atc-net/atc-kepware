// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Specifies the sub-model for the Applicom device.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Modbus%20TCP~IP%20Ethernet/Devices
/// Section: modbus_ethernet.DEVICE_SUB_MODEL
/// Only applicable when Device Model is Applicom.
/// </remarks>
[SuppressMessage("Design", "CA1008:Enums should have zero value", Justification = "Kepware API does not define a zero value for this enum.")]
public enum ModbusApplicomSubModelType
{
    GenericModbus = 1,
    TsxPremium = 2,
    TsxQuantum = 3,
}
