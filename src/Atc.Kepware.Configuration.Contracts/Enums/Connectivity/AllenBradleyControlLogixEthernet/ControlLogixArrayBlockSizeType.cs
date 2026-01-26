// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// The maximum number of atomic array element tags to read in a single transaction.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Allen-Bradley%20ControlLogix%20Ethernet/Devices
/// Section: controllogix_ethernet.DEVICE_ARRAY_BLOCK_SIZE_ELEMENTS
/// </remarks>
[SuppressMessage("Design", "CA1008:Enums should have zero value", Justification = "Values match Kepware API.")]
public enum ControlLogixArrayBlockSizeType
{
    Elements30 = 30,
    Elements60 = 60,
    Elements120 = 120,
    Elements240 = 240,
    Elements480 = 480,
    Elements960 = 960,
    Elements1920 = 1920,
    Elements3840 = 3840,
}
