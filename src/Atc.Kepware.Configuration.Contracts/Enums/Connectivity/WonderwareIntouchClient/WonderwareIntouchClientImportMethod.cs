namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.WonderwareIntouchClient;

/// <summary>
/// Specifies the import method for Wonderware InTouch Client devices.
/// </summary>
public enum WonderwareIntouchClientImportMethod
{
    /// <summary>
    /// Import tags directly from an InTouch project.
    /// </summary>
    ImportFromInTouchProject = 0,

    /// <summary>
    /// Import tags from an InTouch CSV file exported via the DBDump utility.
    /// </summary>
    ImportFromInTouchCsvFile = 1,
}
