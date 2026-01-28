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
}
