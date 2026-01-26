// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Whether the group and tag hierarchy should be based on tag address (condensed) or on RSLogix 5000 (expanded).
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Allen-Bradley%20ControlLogix%20Ethernet/Devices
/// Section: controllogix_ethernet.DEVICE_TAG_HIERARCHY
/// </remarks>
public enum ControlLogixTagHierarchyType
{
    Condensed = 0,
    Expanded = 1,
}
