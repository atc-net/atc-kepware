namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.KraussMaffeiMc4Ethernet;

/// <summary>
/// Interface for KraussMaffei MC4 Ethernet device request properties.
/// </summary>
public interface IKraussMaffeiMc4EthernetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Specify the device's driver-specific station or node (IP Address).
    /// </summary>
    string DeviceId { get; set; }

    /// <summary>
    /// Define the maximum amount of time, in seconds, allowed to establish a connection to a remote device.
    /// Valid range: 1-30. Default: 3.
    /// </summary>
    int ConnectTimeoutSeconds { get; set; }

    /// <summary>
    /// Specify an interval, in milliseconds, to determine how long the driver waits for a response.
    /// Valid range: 50-9999999. Default: 1000.
    /// </summary>
    int RequestTimeoutMs { get; set; }

    /// <summary>
    /// Indicate how many times the driver sends a communications request before considering it failed.
    /// Valid range: 1-10. Default: 3.
    /// </summary>
    int RetryAttempts { get; set; }

    /// <summary>
    /// Specify the TCP/IP port number the device is configured to use.
    /// Valid range: 0-65535. Default: 18901.
    /// </summary>
    int Port { get; set; }

    /// <summary>
    /// Specify the Ethernet protocol used by the device.
    /// Default: TcpIp.
    /// </summary>
    KraussMaffeiMc4ProtocolType Protocol { get; set; }

    /// <summary>
    /// Specify the Request Size Operating Mode.
    /// In Standard Mode, up to 4 parameters per request can be sent.
    /// In Extended Mode, up to 16 parameters per request can be sent.
    /// Default: ExtendedMode.
    /// </summary>
    KraussMaffeiMc4RequestSizeModeType RequestSizeMode { get; set; }

    /// <summary>
    /// Specify whether to use Parameter Handles.
    /// If enabled, Parameter Handles will be acquired and used for all Tags.
    /// Default: true.
    /// </summary>
    bool ParameterHandles { get; set; }
}
