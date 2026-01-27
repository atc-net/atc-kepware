// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Whether the group and tag hierarchy should be based on tag address (condensed) or on RSLogix 5000 (expanded).
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Allen-Bradley%20ControlLogix%20Server%20Ethernet/Devices
/// Section: controllogix_unsolicited_ethernet.DEVICE_TAG_HIERARCHY
/// </remarks>
public enum ControlLogixServerTagHierarchyType
{
    Expanded = 0,
    Condensed = 1,
}
