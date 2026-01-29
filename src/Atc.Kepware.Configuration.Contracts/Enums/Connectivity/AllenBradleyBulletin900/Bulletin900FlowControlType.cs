// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// The Flow Control required by the target device for Allen-Bradley Bulletin 900.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Allen-Bradley%20Bulletin%20900/Channels
/// Section: servermain.CHANNEL_SERIAL_COMMUNICATIONS_FLOW_CONTROL
/// </remarks>
public enum Bulletin900FlowControlType
{
    None = 0,
    Dtr = 1,
    Rts = 2,
    RtsDtr = 3,
    RtsAlways = 4,
    RtsManual = 5,
}