namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.AllenBradleyControlLogixEthernet;

public interface IAllenBradleyControlLogixEthernetDeviceRequest : IDeviceRequestBase
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
