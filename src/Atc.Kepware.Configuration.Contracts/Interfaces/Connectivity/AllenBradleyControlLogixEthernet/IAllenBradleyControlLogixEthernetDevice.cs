namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.AllenBradleyControlLogixEthernet;

public interface IAllenBradleyControlLogixEthernetDevice : IDeviceBase
{
    /// <summary>
    /// Select the specific type of device associated with this ID.
    /// </summary>
    ControlLogixDeviceModelType Model { get; set; }

    /// <summary>
    /// Specify the device's driver-specific station or node.
    /// Format: &lt;IP or Hostname&gt;,1,[&lt;Optional Routing Path&gt;],&lt;CPU Slot&gt;
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
    /// Define how long, in milliseconds, the driver waits before sending the next request.
    /// </summary>
    int InterRequestDelayMs { get; set; }

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
    /// Specify the EtherNet/IP port on the target device.
    /// </summary>
    int Port { get; set; }

    /// <summary>
    /// Specify the maximum number of bytes available on the CIP connection for data requests and responses.
    /// </summary>
    int ConnectionSizeBytes { get; set; }

    /// <summary>
    /// Specify the amount of time, in seconds, a connection can remain idle before being closed by the controller.
    /// </summary>
    ControlLogixInactivityWatchdogType InactivityWatchdog { get; set; }

    /// <summary>
    /// Specify the maximum number of atomic array element tags to read in a single transaction.
    /// </summary>
    ControlLogixArrayBlockSizeType ArrayBlockSize { get; set; }

    /// <summary>
    /// Select the method for reading and addressing data from the controller.
    /// </summary>
    ControlLogixProtocolModeType ProtocolMode { get; set; }

    /// <summary>
    /// Indicate if the server should synchronize with the controller after an online edit or download.
    /// </summary>
    bool SynchronizeAfterOnlineEdits { get; set; }

    /// <summary>
    /// Indicate if the server should synchronize with the controller after an offline edit or download.
    /// </summary>
    bool SynchronizeAfterOfflineEdits { get; set; }

    /// <summary>
    /// Specify if string values should be terminated according to the value of LEN.
    /// </summary>
    bool TerminateStringDataAtLen { get; set; }

    /// <summary>
    /// Select the data type to assign to a tag when the default type is selected.
    /// </summary>
    ControlLogixDefaultDataType DefaultDataType { get; set; }

    /// <summary>
    /// Write performance statistics to the Event Log on shutdown or when this setting is changed.
    /// </summary>
    bool PerformanceStatistics { get; set; }

    /// <summary>
    /// Choose the source of tags for creating the tag database.
    /// </summary>
    ControlLogixDatabaseImportMethodType DatabaseImportMethod { get; set; }

    /// <summary>
    /// Specify the exact location of the L5K/L5X file from which to import tags.
    /// </summary>
    string? TagImportFile { get; set; }

    /// <summary>
    /// Specify if tag descriptions should be imported.
    /// </summary>
    bool TagDescriptions { get; set; }

    /// <summary>
    /// Set tag and group names created through automatic tag generation to 31 characters maximum.
    /// </summary>
    bool LimitNameLength { get; set; }

    /// <summary>
    /// Specify whether the group and tag hierarchy should be based on tag address (condensed) or RSLogix 5000 (expanded).
    /// </summary>
    ControlLogixTagHierarchyType TagHierarchy { get; set; }

    /// <summary>
    /// Choose if the number of elements generated for an array is limited to user-defined count.
    /// </summary>
    bool ImposeArrayLimit { get; set; }

    /// <summary>
    /// Specify the maximum number of array elements allowed when generating arrays.
    /// </summary>
    int ArrayCountUpperLimit { get; set; }
}