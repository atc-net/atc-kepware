// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Select the relative priority of the subscription.
/// When more than one subscription needs to send notifications,
/// the OPC UA server sends data from the subscription with the highest priority first.
/// Applications that do not require special priority should be set to the lowest priority possible.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/OPC%20UA%20Client/Devices
/// Section: opcuaclient.DEVICE_CONNECTION_PRIORITY
/// </remarks>
public enum OpcUaDeviceConnectionPriorityType
{
    Lowest = 0,
    Low = 64,
    Medium = 128,
    High = 192,
    Highest = 255,
}