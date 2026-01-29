// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Specify how the driver should format the revision number for commands that use the default revision (revision 0).
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Torque%20Tool%20Ethernet/devices
/// Section: torque_tool_ethernet.DEVICE_REVISION_FORMAT
/// </remarks>
public enum TorqueToolEthernetRevisionFormat
{
    /// <summary>
    /// Empty
    /// </summary>
    Empty = -1,

    /// <summary>
    /// Zero
    /// </summary>
    Zero = 0,

    /// <summary>
    /// One
    /// </summary>
    One = 1,
}
