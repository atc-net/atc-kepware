namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.FanucFocasEthernet;

/// <summary>
/// Interface for Fanuc Focas Ethernet device properties.
/// </summary>
public interface IFanucFocasEthernetDevice : IDeviceBase
{
    /// <summary>
    /// Select the specific type of device associated with this ID.
    /// </summary>
    FanucFocasDeviceModelType Model { get; set; }

    /// <summary>
    /// Specify the device's driver-specific station or node (IP Address).
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
    /// Specify the TCP/IP port number that the remote device is configured to use.
    /// </summary>
    int Port { get; set; }

    /// <summary>
    /// Specify the number of bytes that may be requested from a device at one time.
    /// </summary>
    FanucFocasMaximumRequestSizeType MaximumRequestSize { get; set; }

    /// <summary>
    /// Specify enable if the device will receive unsolicited data from the CNC.
    /// When disabled, all tags belonging to the device will read and write directly to the CNC.
    /// </summary>
    bool FanucFocasServerDevice { get; set; }

    /// <summary>
    /// Specify the port that the unsolicited message server application has been configured to use.
    /// </summary>
    int UnsolicitedMessageServerPort { get; set; }

    /// <summary>
    /// Specify the registers' PMC memory type that will be used for unsolicited message transfer control.
    /// </summary>
    FanucFocasTransferControlMemoryType TransferControlMemoryType { get; set; }

    /// <summary>
    /// Specify the start address of the registers used for unsolicited message transfer control.
    /// </summary>
    int TransferControlStartAddress { get; set; }

    /// <summary>
    /// Specify the number of times that the CNC should retry sending unsolicited messages.
    /// </summary>
    int MessageRetries { get; set; }

    /// <summary>
    /// Specify the unsolicited message timeout (in seconds).
    /// The amount of time that the CNC will wait for the driver to respond to an unsolicited message.
    /// </summary>
    int MessageTimeoutSeconds { get; set; }

    /// <summary>
    /// Specify the unsolicited message alive time (in seconds).
    /// The amount of time that the CNC will retain an unsolicited message for the driver to read it.
    /// </summary>
    int MessageAliveTimeSeconds { get; set; }

    /// <summary>
    /// Specify whether Data Area 1 in PMC memory is configured for unsolicited messages.
    /// </summary>
    bool DataArea1Enable { get; set; }

    /// <summary>
    /// Specify the PMC address type for Area 1.
    /// </summary>
    FanucFocasPmcAddressType DataArea1PmcAddressType { get; set; }

    /// <summary>
    /// Specify the start address for Area 1.
    /// </summary>
    int DataArea1StartAddress { get; set; }

    /// <summary>
    /// Specify the end address for Area 1.
    /// </summary>
    int DataArea1EndAddress { get; set; }

    /// <summary>
    /// Specify whether Data Area 2 in PMC memory is configured for unsolicited messages.
    /// </summary>
    bool DataArea2Enable { get; set; }

    /// <summary>
    /// Specify the PMC address type for Area 2.
    /// </summary>
    FanucFocasPmcAddressType DataArea2PmcAddressType { get; set; }

    /// <summary>
    /// Specify the start address for Area 2.
    /// </summary>
    int DataArea2StartAddress { get; set; }

    /// <summary>
    /// Specify the end address for Area 2.
    /// </summary>
    int DataArea2EndAddress { get; set; }

    /// <summary>
    /// Specify whether Data Area 3 in PMC memory is configured for unsolicited messages.
    /// </summary>
    bool DataArea3Enable { get; set; }

    /// <summary>
    /// Specify the PMC address type for Area 3.
    /// </summary>
    FanucFocasPmcAddressType DataArea3PmcAddressType { get; set; }

    /// <summary>
    /// Specify the start address for Area 3.
    /// </summary>
    int DataArea3StartAddress { get; set; }

    /// <summary>
    /// Specify the end address for Area 3.
    /// </summary>
    int DataArea3EndAddress { get; set; }
}