// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// The data parity for this communication for Allen-Bradley Bulletin 900.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Allen-Bradley%20Bulletin%20900/Channels
/// Section: servermain.CHANNEL_SERIAL_COMMUNICATIONS_PARITY
/// </remarks>
[SuppressMessage("Design", "CA1008:Enums should have zero value", Justification = "Values match Kepware API.")]
public enum Bulletin900ParityType
{
    None = 78,
    Odd = 79,
    Even = 69,
}