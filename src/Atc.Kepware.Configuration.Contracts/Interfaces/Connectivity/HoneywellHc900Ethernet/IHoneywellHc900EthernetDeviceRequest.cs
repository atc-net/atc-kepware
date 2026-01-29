namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.HoneywellHc900Ethernet;

public interface IHoneywellHc900EthernetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Select the specific type of device associated with this ID.
    /// </summary>
    HoneywellHc900EthernetDeviceModelType Model { get; set; }

    /// <summary>
    /// Indicate the format of the device ID.
    /// </summary>
    HoneywellHc900EthernetDeviceIdFormatType IdFormat { get; set; }

    /// <summary>
    /// Specify the device's driver-specific station or node.
    /// Format: IP Address (e.g., "192.168.1.1")
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
    /// Specify the TCP/IP port this device will be using.
    /// </summary>
    int Port { get; set; }

    /// <summary>
    /// Specify if the driver should assume the first word is the low or high word in 32-bit values.
    /// If disabled, the driver will use the Honeywell default FP B. If enabled, the FP LB format will be used.
    /// </summary>
    bool FirstWordLow { get; set; }

    /// <summary>
    /// Specify the number of output coils that should be read from the device in a single request.
    /// Value must be a multiple of 8.
    /// </summary>
    int OutputCoils { get; set; }

    /// <summary>
    /// Specify the number of input coils that should be read from the device in a single request.
    /// Value must be a multiple of 8.
    /// </summary>
    int InputCoils { get; set; }

    /// <summary>
    /// Specify the number of internal registers that should be read from the device in a single request.
    /// </summary>
    int InternalRegisters { get; set; }

    /// <summary>
    /// Specify the number of holding registers that should be read from the device in a single request.
    /// </summary>
    int HoldingRegisters { get; set; }

    /// <summary>
    /// Specify the number of control loops used in the controller (0-32).
    /// Tags for the most important loop parameters are created for each loop.
    /// WARNING: Generated tags may not be valid if Custom Modbus Map is in use in controller.
    /// </summary>
    int NumberOfLoops { get; set; }

    /// <summary>
    /// Specify the number of Read/Write variables used in the controller configuration.
    /// Variables are listed by number in the same sequence as in the controller configuration.
    /// Each variable will have an analog (Float) and a digital (Boolean) parameter listing.
    /// WARNING: Generated tags may not be valid if Custom Modbus Map is in use in controller.
    /// </summary>
    int NumberOfVariables { get; set; }

    /// <summary>
    /// Specify the number of Read Only signal tags used in the controller configuration.
    /// Signal tags are listed by number in the same sequence as in the controller configuration.
    /// Each signal tag will have an analog (Float) and a digital (Boolean) parameter listing.
    /// WARNING: Generated tags may not be valid if Custom Modbus Map is in use in controller.
    /// </summary>
    int NumberOfSignalTags { get; set; }

    /// <summary>
    /// Specify the number of set point programmers used in the controller (0-8).
    /// WARNING: Generated tags may not be valid if Custom Modbus Map is in use in controller.
    /// </summary>
    int NumberOfSpProgrammers { get; set; }

    /// <summary>
    /// Specify the number of segments configured for set point programmer 1.
    /// </summary>
    int Segments1 { get; set; }

    /// <summary>
    /// Specify the number of segments configured for set point programmer 2.
    /// </summary>
    int Segments2 { get; set; }

    /// <summary>
    /// Specify the number of segments configured for set point programmer 3.
    /// </summary>
    int Segments3 { get; set; }

    /// <summary>
    /// Specify the number of segments configured for set point programmer 4.
    /// </summary>
    int Segments4 { get; set; }

    /// <summary>
    /// Specify the number of segments configured for set point programmer 5.
    /// </summary>
    int Segments5 { get; set; }

    /// <summary>
    /// Specify the number of segments configured for set point programmer 6.
    /// </summary>
    int Segments6 { get; set; }

    /// <summary>
    /// Specify the number of segments configured for set point programmer 7.
    /// </summary>
    int Segments7 { get; set; }

    /// <summary>
    /// Specify the number of segments configured for set point programmer 8.
    /// </summary>
    int Segments8 { get; set; }

    /// <summary>
    /// Specify the tag import files to be used when automatically generating tags.
    /// </summary>
    string? TagImportFiles { get; set; }

    /// <summary>
    /// Specify if descriptions should be displayed if provided.
    /// </summary>
    bool DisplayDescriptions { get; set; }

    /// <summary>
    /// Specify the tag naming option.
    /// </summary>
    HoneywellHc900EthernetDeviceTagNamingType TagNaming { get; set; }

    /// <summary>
    /// Controls whether or not this device will automatically generate new tags whenever certain properties are changed.
    /// </summary>
    bool TagGenerationOnPropertyChange { get; set; }

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
    /// If empty, generated tags are added at the device level.
    /// </summary>
    string? TagGenerationGroup { get; set; }

    /// <summary>
    /// Instruct the server to automatically create sub groups for automatically generated tags.
    /// </summary>
    bool AllowAutomaticallyGeneratedSubgroups { get; set; }
}