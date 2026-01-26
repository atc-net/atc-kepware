// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Specify the source from which tags will be imported.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/EUROMAP%2063/Devices
/// Section: euromap_63.DEVICE_TAG_IMPORT_SOURCE
/// </remarks>
public enum EuroMap63DeviceTagImportSourceType
{
    Device = 0,
    File = 1,
}