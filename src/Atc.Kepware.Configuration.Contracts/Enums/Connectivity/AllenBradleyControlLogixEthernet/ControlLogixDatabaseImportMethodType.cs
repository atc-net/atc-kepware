// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// The source of tags for creating the tag database.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Allen-Bradley%20ControlLogix%20Ethernet/Devices
/// Section: controllogix_ethernet.DEVICE_DATABASE_IMPORT_METHOD
/// </remarks>
public enum ControlLogixDatabaseImportMethodType
{
    CreateFromDevice = 0,
    CreateFromImportFile = 1,
}