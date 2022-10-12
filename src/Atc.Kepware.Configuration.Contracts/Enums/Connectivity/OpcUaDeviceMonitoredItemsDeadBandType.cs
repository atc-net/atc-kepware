// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Select the type of deadband filter to be applied to data changes.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/OPC%20UA%20Client/Devices
/// Section: opcuaclient.DEVICE_MONITORED_ITEMS_DEADBAND_TYPE
/// </remarks>
public enum OpcUaDeviceMonitoredItemsDeadBandType
{
    /// <summary>
    /// None disables deadband.
    /// </summary>
    None = 0,

    /// <summary>
    /// Percent sends data changes larger than a percentage of the maximum range for the tag.
    /// </summary>
    Percent = 1,

    /// <summary>
    /// Absolute sends data changes if the change is greater than some absolute value.
    /// </summary>
    Absolute = 2,
}