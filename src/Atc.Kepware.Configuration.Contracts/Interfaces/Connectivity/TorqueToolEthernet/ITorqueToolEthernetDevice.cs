namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.TorqueToolEthernet;

/// <summary>
/// Interface for Torque Tool Ethernet device.
/// </summary>
public interface ITorqueToolEthernetDevice : IDeviceBase
{
    /// <summary>
    /// Specify the device's IP address.
    /// Format: &lt;IP_Address&gt; (e.g., "192.168.1.1")
    /// </summary>
    string DeviceId { get; set; }

    /// <summary>
    /// Specify the TCP/IP port number used for communication.
    /// </summary>
    int Port { get; set; }

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
    /// Specify Enable to set the error state if the device does not respond (DNR) to writes or subscription requests.
    /// The driver always sets the error state if the device does not respond to reads.
    /// </summary>
    bool SetErrorStateForAllDnrs { get; set; }

    /// <summary>
    /// Specify the amount of inactive time, in seconds, before the driver sends a Keep-Alive message to the device.
    /// </summary>
    int PollTimeSeconds { get; set; }

    /// <summary>
    /// Specify the amount of time, in milliseconds, that the driver waits for a response from a Keep-Alive message.
    /// </summary>
    int ReplyTimeoutMs { get; set; }

    /// <summary>
    /// Specify the number of times the driver attempts to send a Keep-Alive message before determining it has failed.
    /// </summary>
    int Retries { get; set; }

    /// <summary>
    /// Specify the revision number for the Alarm messages. This affects MIDs 0070 through 0078.
    /// Only applies when Model is OpenProtocol.
    /// </summary>
    int AlarmRevision { get; set; }

    /// <summary>
    /// Specify the revision number for the Application Communication messages. This affects MIDs 0001 and 0002.
    /// Only applies when Model is OpenProtocol.
    /// </summary>
    int CommunicationRevision { get; set; }

    /// <summary>
    /// Specify the revision number for Job Data messages. This affects MIDs 0032 and 0033.
    /// Only applies when Model is OpenProtocol.
    /// </summary>
    int JobDataRevision { get; set; }

    /// <summary>
    /// Specify the revision number for Job Info messages. This affects MIDs 0034 through 0037.
    /// Only applies when Model is OpenProtocol.
    /// </summary>
    int JobInfoRevision { get; set; }

    /// <summary>
    /// Specify the revision number for the Job Upload, Select, and Restart messages. This affects MIDs 0030, 0031, 0038, and 0039.
    /// Only applies when Model is OpenProtocol.
    /// </summary>
    int JobStateRevision { get; set; }

    /// <summary>
    /// Specify the revision number for the Last Tightening Results messages. This affects MIDs 0060 through 0063.
    /// Only applies when Model is OpenProtocol.
    /// </summary>
    int LastTighteningRevision { get; set; }

    /// <summary>
    /// Specify the revision number for the Old Tightening Results messages. This affects MIDs 0064 and 0065.
    /// Only applies when Model is OpenProtocol.
    /// </summary>
    int OldTighteningRevision { get; set; }

    /// <summary>
    /// Specify the revision number for the Selector Control Light messages. This affects MIDs 0254 and 0255.
    /// Only applies when Model is OpenProtocol.
    /// </summary>
    int SelectorLightsRevision { get; set; }

    /// <summary>
    /// Specify the revision number for the Tool Data messages. This affects MIDs 0040 and 0041.
    /// Only applies when Model is OpenProtocol.
    /// </summary>
    int ToolDataRevision { get; set; }

    /// <summary>
    /// Specify the revision number for the Vehicle Identification Number messages. This affects MIDs 0051 through 0054.
    /// Only applies when Model is OpenProtocol.
    /// </summary>
    int VinRevision { get; set; }

    /// <summary>
    /// Select Enable to have the driver disable the tool whenever a Last Tightening Results (LTR) message is received.
    /// This ensures that no LTR data is overwritten before the system has had time to process it.
    /// </summary>
    bool DisableToolOnLtr { get; set; }

    /// <summary>
    /// Specify how the driver should format the revision number for commands that use the default revision (revision 0).
    /// Only applies when Model is OpenProtocol.
    /// </summary>
    TorqueToolEthernetRevisionFormat RevisionFormat { get; set; }

    /// <summary>
    /// When enabled, the common generic subscription MID 0008 is used to subscribe.
    /// See the Open Protocol document for more information.
    /// </summary>
    bool UseGenericSubscribe { get; set; }

    /// <summary>
    /// Specify the way the driver handles tags for unsolicited message data.
    /// When Enabled, the driver will update all tags for a given command set at once.
    /// When disabled, the driver will update those tags individually at their specified scan rate.
    /// </summary>
    bool UseUnsolicitedDataPacking { get; set; }
}