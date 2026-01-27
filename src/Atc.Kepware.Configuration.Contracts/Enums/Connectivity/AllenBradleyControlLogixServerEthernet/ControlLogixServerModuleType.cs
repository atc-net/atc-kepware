// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Specifies whether the controller module should be treated as local to or remote to the simulated EtherNet/IP module.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Allen-Bradley%20ControlLogix%20Server%20Ethernet/Devices
/// Section: controllogix_unsolicited_ethernet.DEVICE_MODULE_TYPE
/// </remarks>
public enum ControlLogixServerModuleType
{
    Local = 0,
    Remote = 1,
}
