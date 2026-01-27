namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.MitsubishiFxNet;

/// <summary>
/// Defines the Mitsubishi FX Net device request properties.
/// </summary>
public interface IMitsubishiFxNetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the device model.
    /// </summary>
    MitsubishiFxNetModel Model { get; set; }

    /// <summary>
    /// Gets or sets the device's driver-specific station or node.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-15.
    /// </remarks>
    int DeviceId { get; set; }

    /// <summary>
    /// Gets or sets the IP address of the device.
    /// </summary>
    string IpAddress { get; set; }

    /// <summary>
    /// Gets or sets the port number for device communication.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-65535. Default: 2101.
    /// </remarks>
    int Port { get; set; }

    /// <summary>
    /// Gets or sets the IP protocol type for communication.
    /// </summary>
    MitsubishiFxNetProtocolType Protocol { get; set; }

    /// <summary>
    /// Gets or sets the connection timeout in seconds.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-30. Default: 3.
    /// </remarks>
    int ConnectTimeout { get; set; }

    /// <summary>
    /// Gets or sets the request timeout in milliseconds.
    /// </summary>
    /// <remarks>
    /// Valid range: 50-9999999. Default: 1000.
    /// </remarks>
    int RequestTimeout { get; set; }

    /// <summary>
    /// Gets or sets the number of retry attempts before timeout.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-10. Default: 3.
    /// </remarks>
    int RetryAttempts { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to demote the device on communication failures.
    /// </summary>
    bool DemoteOnFailure { get; set; }

    /// <summary>
    /// Gets or sets the number of successive timeouts before demotion.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-30. Default: 3.
    /// </remarks>
    int TimeoutsToDemote { get; set; }

    /// <summary>
    /// Gets or sets the demotion period in milliseconds.
    /// </summary>
    /// <remarks>
    /// Valid range: 100-3600000. Default: 10000.
    /// </remarks>
    int DemotionPeriod { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to discard write requests when demoted.
    /// </summary>
    bool DiscardRequestsWhenDemoted { get; set; }
}
