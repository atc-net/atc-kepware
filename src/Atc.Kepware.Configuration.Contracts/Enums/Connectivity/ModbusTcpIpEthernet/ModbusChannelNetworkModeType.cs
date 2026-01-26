// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Choose whether to Load Balance for channels to communicate in a fixed order
/// or Priority for order based on the type of operations pending.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Modbus%20TCP~IP%20Ethernet/Channels
/// Section: servermain.CHANNEL_COMMUNICATIONS_SERIALIZATION_NETWORK_MODE
/// </remarks>
public enum ModbusChannelNetworkModeType
{
    LoadBalanced = 0,
    Priority = 1,
}
