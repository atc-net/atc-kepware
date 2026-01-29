// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// The number of data bits per word for Allen-Bradley Bulletin 900.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Allen-Bradley%20Bulletin%20900/Channels
/// Section: servermain.CHANNEL_SERIAL_COMMUNICATIONS_DATA_BITS
/// </remarks>
[SuppressMessage("Design", "CA1008:Enums should have zero value", Justification = "Values match Kepware API.")]
public enum Bulletin900DataBitsType
{
    DataBits5 = 5,
    DataBits6 = 6,
    DataBits7 = 7,
    DataBits8 = 8,
}