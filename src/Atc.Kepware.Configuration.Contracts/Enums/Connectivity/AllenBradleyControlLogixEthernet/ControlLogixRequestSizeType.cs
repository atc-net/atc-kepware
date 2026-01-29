// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// The maximum number of bytes that may be requested from a device at one time.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Allen-Bradley%20ControlLogix%20Ethernet/Devices
/// Section: controllogix_ethernet.DEVICE_REQUEST_SIZE
/// </remarks>
[SuppressMessage("Design", "CA1008:Enums should have zero value", Justification = "Values match Kepware API.")]
public enum ControlLogixRequestSizeType
{
    Bytes32 = 32,
    Bytes64 = 64,
    Bytes128 = 128,
    Bytes232 = 232,
}