// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// What occurs when an explicit device read is requested for Allen-Bradley Bulletin 900.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Allen-Bradley%20Bulletin%20900/Channels
/// Section: servermain.CHANNEL_SERIAL_COMMUNICATIONS_READ_PROCESSING
/// </remarks>
public enum Bulletin900SerialReadProcessingType
{
    Ignore = 0,
    Fail = 1,
}
