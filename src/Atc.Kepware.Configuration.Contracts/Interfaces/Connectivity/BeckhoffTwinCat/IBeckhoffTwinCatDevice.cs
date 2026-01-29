namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.BeckhoffTwinCat;

/// <summary>
/// Interface for Beckhoff TwinCAT device.
/// </summary>
public interface IBeckhoffTwinCatDevice : IDeviceBase
{
    /// <summary>
    /// Select the specific type of device associated with this ID.
    /// </summary>
    BeckhoffTwinCatModel Model { get; set; }

    /// <summary>
    /// Indicate the format of the device ID.
    /// </summary>
    BeckhoffTwinCatIdFormat IdFormat { get; set; }

    /// <summary>
    /// Specify the device's driver-specific station or node.
    /// Format: &lt;AmsNetId&gt; (e.g., "255.255.255.255.1.1")
    /// </summary>
    string DeviceId { get; set; }

    /// <summary>
    /// Define the maximum amount of time, in seconds, allowed to establish a connection to a remote device.
    /// </summary>
    int ConnectTimeoutSeconds { get; set; }

    /// <summary>
    /// Specify an interval, in milliseconds, to determine how long the driver waits for a response.
    /// </summary>
    int RequestTimeoutMs { get; set; }

    /// <summary>
    /// Indicate how many times the driver sends a communications request before considering it failed.
    /// </summary>
    int RetryAttempts { get; set; }

    /// <summary>
    /// Automatically remove the device from the scan due to communication failures.
    /// </summary>
    bool DemoteOnFailure { get; set; }

    /// <summary>
    /// Specify how many successive cycles of request timeouts occur before the device is placed off-scan.
    /// </summary>
    int TimeoutsToDemote { get; set; }

    /// <summary>
    /// Indicate how long, in milliseconds, before scanning is attempted again on a demoted device.
    /// </summary>
    int DemotionPeriodMs { get; set; }

    /// <summary>
    /// Select whether write requests are discarded during the off-scan period.
    /// </summary>
    bool DiscardRequestsWhenDemoted { get; set; }

    /// <summary>
    /// Select the automatic tag generation action to be taken on device startup.
    /// </summary>
    DeviceTagGenerationOnStartupType TagGenerationOnStartup { get; set; }

    /// <summary>
    /// Indicate the preferred method of avoiding creation of duplicate tags.
    /// </summary>
    DeviceTagGenerationDuplicateHandlingType TagGenerationDuplicateHandling { get; set; }

    /// <summary>
    /// Indicate a tag group name for new generated tags.
    /// </summary>
    string? TagGenerationGroup { get; set; }

    /// <summary>
    /// Instruct the server to automatically create sub groups for automatically generated tags.
    /// </summary>
    bool AllowAutomaticallyGeneratedSubgroups { get; set; }

    /// <summary>
    /// Set the port number for the specified Beckhoff device model.
    /// </summary>
    int PortNumber { get; set; }

    /// <summary>
    /// Specify the datatype that is to be used as the default datatype for tag addressing.
    /// </summary>
    BeckhoffTwinCatDefaultType DefaultType { get; set; }

    /// <summary>
    /// Specify the source from which controller Symbolic Information will be imported.
    /// Only applicable when Model is TwinCatPlc.
    /// </summary>
    BeckhoffTwinCatImportSource ImportSource { get; set; }

    /// <summary>
    /// Specify the location of the .tpy file from which tags will be imported.
    /// </summary>
    string? SymbolFile { get; set; }

    /// <summary>
    /// Specify if the Runtime database should be updated automatically whenever the symbol file is modified.
    /// Only applicable when Model is BcBxController.
    /// </summary>
    bool AutoSynchronizeFileChanges { get; set; }

    /// <summary>
    /// Specify if variables that include OPC Read/Write access rights in their comments will be assigned
    /// access rights based on those comments during import.
    /// </summary>
    bool RespectOpcReadWriteItemProperties { get; set; }

    /// <summary>
    /// Specify if the case of imported tags and address strings should be preserved on import.
    /// </summary>
    bool RespectTagCaseOnImport { get; set; }

    /// <summary>
    /// Specify if only variables which have a comment that includes the string 'OPC:1' and matches
    /// the filter should be imported into the project during Runtime.
    /// </summary>
    bool OnlyImportVariablesMarkedForOpc { get; set; }

    /// <summary>
    /// Specify the filter text that should be used to restrict the variables imported into the Runtime.
    /// </summary>
    string? AdditionalFilter { get; set; }
}