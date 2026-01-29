// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Select bit ordering for 16 bit memory cell tags (M, MW, XW).
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/SattBus%20Ethernet/devices
/// Section: sattbus_ethernet.DEVICE_BIT_ORDERING
/// </remarks>
public enum SattBusEthernetBitOrderingType
{
    /// <summary>
    /// MSBit 0| 1| 2| 3| 4| 5| 6| 7| 8| 9| 10| 11| 12| 13| 14| 15 LSBit.
    /// </summary>
    MsBit0To15 = 0,

    /// <summary>
    /// MSBit 15| 14| 13| 12| 11| 10| 9| 8| 7| 6| 5| 4| 3| 2| 1| 0 LSBit.
    /// </summary>
    MsBit15To0 = 1,

    /// <summary>
    /// MSBit 7| 6| 5| 4| 3| 2| 1| 0| 15| 14| 13| 12| 11| 10| 9| 8 LSBit.
    /// </summary>
    MsBit7To0Then15To8 = 2,
}