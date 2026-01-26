// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// The method for reading and addressing data from the controller.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Allen-Bradley%20ControlLogix%20Ethernet/Devices
/// Section: controllogix_ethernet.DEVICE_PROTOCOL_MODE
/// </remarks>
public enum ControlLogixProtocolModeType
{
    Symbolic = 0,
    LogicalNonBlocking = 1,
    LogicalBlocking = 2,
}
