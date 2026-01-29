// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// The hardware device type for data communications for Allen-Bradley Bulletin 900.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Allen-Bradley%20Bulletin%20900/Channels
/// Section: servermain.CHANNEL_SERIAL_COMMUNICATIONS_PHYSICAL_MEDIUM
/// </remarks>
public enum Bulletin900SerialPhysicalMediumType
{
    None = 0,
    ComPort = 1,
    Modem = 2,
    EthernetEncapsulation = 3,
}