namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.OmronNjEthernet;

/// <summary>
/// Interface for Omron NJ Ethernet device request.
/// </summary>
public interface IOmronNjEthernetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the device model.
    /// </summary>
    OmronNjEthernetModel Model { get; set; }

    /// <summary>
    /// Gets or sets the TCP/IP port number on the target device.
    /// </summary>
    int Port { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of bytes available on the CIP connection for data requests and responses.
    /// </summary>
    int ConnectionSize { get; set; }

    /// <summary>
    /// Gets or sets the amount of time, in seconds, the CIP connection can be idle before being closed.
    /// </summary>
    OmronNjEthernetInactivityWatchdog InactivityWatchdog { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of array elements to be read in a single transaction.
    /// </summary>
    OmronNjEthernetArrayBlockSize ArrayBlockSize { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to track and record performance metrics.
    /// </summary>
    bool PerformanceStatistics { get; set; }

    /// <summary>
    /// Gets or sets the tag hierarchy display mode.
    /// </summary>
    OmronNjEthernetTagHierarchy TagHierarchy { get; set; }
}
