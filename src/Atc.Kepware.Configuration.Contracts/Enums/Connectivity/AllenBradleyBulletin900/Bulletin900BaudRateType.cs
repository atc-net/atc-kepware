// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// The communications speed of the hardware in bits per second for Allen-Bradley Bulletin 900.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Allen-Bradley%20Bulletin%20900/Channels
/// Section: servermain.CHANNEL_SERIAL_COMMUNICATIONS_BAUD_RATE
/// </remarks>
[SuppressMessage("Design", "CA1008:Enums should have zero value", Justification = "Values match Kepware API.")]
public enum Bulletin900BaudRateType
{
    Baud300 = 300,
    Baud600 = 600,
    Baud1200 = 1200,
    Baud2400 = 2400,
    Baud4800 = 4800,
    Baud9600 = 9600,
    Baud14400 = 14400,
    Baud19200 = 19200,
    Baud28800 = 28800,
    Baud38400 = 38400,
    Baud56000 = 56000,
    Baud57600 = 57600,
    Baud115200 = 115200,
    Baud128000 = 128000,
    Baud256000 = 256000,
}