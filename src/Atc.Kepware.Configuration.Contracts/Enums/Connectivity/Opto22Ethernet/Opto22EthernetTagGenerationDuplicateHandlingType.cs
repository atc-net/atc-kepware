namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.Opto22Ethernet;

/// <summary>
/// Preferred method of avoiding creation of duplicate tags.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Opto%2022%20Ethernet/devices
/// Section: servermain.DEVICE_TAG_GENERATION_DUPLICATE_HANDLING
/// </remarks>
public enum Opto22EthernetTagGenerationDuplicateHandlingType
{
    /// <summary>
    /// Delete existing tags before creating new ones.
    /// </summary>
    [Description("Delete on Create")]
    DeleteOnCreate = 0,

    /// <summary>
    /// Overwrite existing tags as necessary.
    /// </summary>
    [Description("Overwrite as Necessary")]
    OverwriteAsNecessary = 1,

    /// <summary>
    /// Do not overwrite existing tags.
    /// </summary>
    [Description("Do Not Overwrite")]
    DoNotOverwrite = 2,

    /// <summary>
    /// Do not overwrite existing tags, log an error.
    /// </summary>
    [Description("Do Not Overwrite, Log Error")]
    DoNotOverwriteLogError = 3,
}
