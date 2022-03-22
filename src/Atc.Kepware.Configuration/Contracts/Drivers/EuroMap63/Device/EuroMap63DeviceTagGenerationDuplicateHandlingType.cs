namespace Atc.Kepware.Configuration.Contracts.Drivers.EuroMap63.Device;

/// <summary>
/// Indicates the preferred method of avoiding creation of duplicate tags.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/EUROMAP%2063/Devices
/// Section: servermain.DEVICE_TAG_GENERATION_DUPLICATE_HANDLING
/// </remarks>
public enum EuroMap63DeviceTagGenerationDuplicateHandlingType
{
    /// <summary>
    /// Deletes any tags that were previously added to the tag space
    /// before any new tags are added.
    /// This is the default setting.
    /// </summary>
    DeleteOnCreate = 0,

    /// <summary>
    /// Instructs the server to only remove the tags that the communications driver is replacing with new tags.
    /// Any tags that are not being overwritten remain in the server's tag space.
    /// </summary>
    OverwriteAsNecessary = 1,

    /// <summary>
    /// Prevents the server from removing any tags that were previously generated
    /// or already existed in the server.
    /// The communications driver can only add tags that are completely new.
    /// </summary>
    DoNotOverwrite = 2,

    /// <summary>
    /// Same effect as the prior option,
    /// and also posts an error message to the server's Event Log when a tag overwrite would have occurred.
    /// </summary>
    DoNotOverwriteWithLogError = 3,
}