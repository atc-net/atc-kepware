namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.WonderwareIntouchClient;

/// <summary>
/// Defines the Wonderware InTouch Client device request properties.
/// </summary>
public interface IWonderwareIntouchClientDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the device model.
    /// </summary>
    /// <remarks>
    /// Specifies the type of device: InTouch (read/write) or InTouch (Read Only).
    /// </remarks>
    WonderwareIntouchClientDeviceModel? Model { get; set; }

    /// <summary>
    /// Gets or sets the import method for tags.
    /// </summary>
    /// <remarks>
    /// Import from InTouch Project allows tags to be imported directly from an InTouch project.
    /// Import from InTouch CSV File requires the tag database to be exported to a CSV file first
    /// through the use of the InTouch DBDump utility.
    /// Default is ImportFromInTouchProject (0).
    /// </remarks>
    WonderwareIntouchClientImportMethod? ImportMethod { get; set; }

    /// <summary>
    /// Gets or sets the InTouch project folder path.
    /// </summary>
    /// <remarks>
    /// The root folder of the InTouch project from which tags are imported.
    /// Used with the Import from InTouch project method.
    /// If no folder is specified, the most recent InTouch project is used.
    /// Maximum length is 260 characters.
    /// </remarks>
    string? InTouchProjectFolder { get; set; }

    /// <summary>
    /// Gets or sets the InTouch CSV file path.
    /// </summary>
    /// <remarks>
    /// The name and path of the InTouch CSV file from which tags are imported.
    /// Used with the Import from InTouch CSV file method.
    /// Default is "*.csv".
    /// Maximum length is 260 characters.
    /// </remarks>
    string? InTouchCsvFile { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to include tag descriptions.
    /// </summary>
    /// <remarks>
    /// When enabled, includes the descriptions attached to each InTouch tag when auto-generating tags.
    /// Default is true.
    /// </remarks>
    bool? IncludeTagDescriptions { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to import system tags.
    /// </summary>
    /// <remarks>
    /// When enabled, imports InTouch system tags (such as $ApplicationVersion, $Date, $Time, etc.).
    /// Note that since tag names in the OPC server must start with an alphanumeric character,
    /// the dollar sign in each imported system tag name is changed to a zero (0).
    /// Default is true.
    /// </remarks>
    bool? ImportSystemTags { get; set; }

    /// <summary>
    /// Gets or sets the tag naming option.
    /// </summary>
    /// <remarks>
    /// Enhanced has fewer naming constraints and is consistent with current OPC server naming requirements.
    /// Legacy enforces the stricter naming requirements of previous versions of this driver.
    /// Default is Enhanced (1).
    /// </remarks>
    WonderwareIntouchClientTagNaming? TagNaming { get; set; }

    /// <summary>
    /// Gets or sets the mode of data access.
    /// </summary>
    /// <remarks>
    /// Specifies the mode of data access used to optimize communications with InTouch.
    /// These settings affect how data is acquired for all tags associated with the device.
    /// Default is DriverPollsInTouch (0).
    /// </remarks>
    WonderwareIntouchClientMode? Mode { get; set; }

    /// <summary>
    /// Gets or sets the maximum active time in milliseconds.
    /// </summary>
    /// <remarks>
    /// Specifies how long the driver should keep tags active in milliseconds.
    /// Since many active tags can burden the InTouch memory manager, tags associated with
    /// slowly changing data should not be kept active. Care should be taken not to make
    /// this value too low, since repeated activation/re-activation requires processing time.
    /// Valid range is 0-3600000 ms.
    /// Default is 60000 ms.
    /// Only applies when Mode is DriverPollsInTouch or Combination.
    /// </remarks>
    int? MaximumActiveTimeMs { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to delete inactive tags.
    /// </summary>
    /// <remarks>
    /// When enabled, tags are completely deleted in between reads, reducing the workload on InTouch.
    /// Use this option with care since repeated creation and destruction of tags requires processing time.
    /// Default is true.
    /// Only applies when Mode is DriverPollsInTouch.
    /// </remarks>
    bool? DeleteInactiveTags { get; set; }
}