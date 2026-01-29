namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.ThermoWestronicsEthernet;

/// <summary>
/// Interface for Thermo Westronics Ethernet device request.
/// </summary>
public interface IThermoWestronicsEthernetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Specify the device's IP address.
    /// Format: &lt;IP_Address&gt; (e.g., "192.168.1.1")
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
    /// Specify the TCP/IP port number used for communication.
    /// </summary>
    int Port { get; set; }

    /// <summary>
    /// Specify the block size of the output coils in bits.
    /// A higher block size means more points will be read from the device in a single request.
    /// </summary>
    int OutputCoils { get; set; }

    /// <summary>
    /// Specify the block size of the input coils in bits.
    /// A higher block size means more points will be read from the device in a single request.
    /// </summary>
    int InputCoils { get; set; }

    /// <summary>
    /// Specify the number of internal registers to read from the device in a single request.
    /// A higher block size means more register values will be read from the device in a single request.
    /// </summary>
    int InternalRegisters { get; set; }

    /// <summary>
    /// Specify the number of holding registers to read from the device in a single request.
    /// A higher block size means more register values will be read from the device in a single request.
    /// </summary>
    int HoldingRegisters { get; set; }

    /// <summary>
    /// Specify whether the device uses 1x32 float format in Modbus communications instead of 2x16.
    /// </summary>
    bool Use1x32FloatFormat { get; set; }
}
