// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// The preferred method of avoiding creation of duplicate tags.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/{driver}/Devices
/// Section: servermain.DEVICE_TAG_GENERATION_DUPLICATE_HANDLING
/// </remarks>
public enum DeviceTagGenerationDuplicateHandlingType
{
    DeleteOnCreate = 0,
    OverwriteAsNecessary = 1,
    DoNotOverwrite = 2,
    DoNotOverwriteLogError = 3,
}
