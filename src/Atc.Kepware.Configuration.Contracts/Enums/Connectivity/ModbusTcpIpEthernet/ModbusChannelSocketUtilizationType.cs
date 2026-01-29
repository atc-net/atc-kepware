// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Specifies how sockets are utilized for device communication.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Modbus%20TCP~IP%20Ethernet/Channels
/// Section: modbus_ethernet.CHANNEL_USE_ONE_OR_MORE_SOCKETS_PER_DEVICE
/// </remarks>
public enum ModbusChannelSocketUtilizationType
{
    /// <summary>
    /// The driver communicates with all devices through the same shared socket,
    /// closing and opening the socket for each device.
    /// </summary>
    OneSocketPerChannelShared = 0,

    /// <summary>
    /// Disables sharing and devices use up to the specified number of private sockets
    /// independently maintained as active connections, improving performance.
    /// </summary>
    OneOrMoreSocketsPerDevice = 1,
}