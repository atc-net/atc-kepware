namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.DnpClientEthernet;

/// <summary>
/// Defines the DNP Client Ethernet device request properties.
/// </summary>
public interface IDnpClientEthernetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the 16-bit address for the DNP client (this device).
    /// </summary>
    /// <remarks>
    /// Valid range: 0-65519. Default: 3.
    /// </remarks>
    int DnpClientAddress { get; set; }

    /// <summary>
    /// Gets or sets the 16-bit address for the DNP server (remote device).
    /// </summary>
    /// <remarks>
    /// Valid range: 0-65519. Default: 4.
    /// </remarks>
    int DnpServerAddress { get; set; }

    /// <summary>
    /// Gets or sets the request timeout in milliseconds.
    /// </summary>
    /// <remarks>
    /// Valid range: 100-3600000. Default: 30000.
    /// </remarks>
    int RequestTimeout { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of successive timeouts before error.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-10. Default: 1.
    /// </remarks>
    int MaxTimeouts { get; set; }

    /// <summary>
    /// Gets or sets the keep-alive interval in seconds.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-86400. Default: 0 (disabled).
    /// </remarks>
    int KeepAliveInterval { get; set; }

    /// <summary>
    /// Gets or sets whether the DNP server uses UTC time.
    /// </summary>
    bool DnpServerUsesUtc { get; set; }

    /// <summary>
    /// Gets or sets whether the DNP server respects daylight saving time.
    /// </summary>
    bool DnpServerRespectsDst { get; set; }

    /// <summary>
    /// Gets or sets whether to honor time sync requests from the DNP server.
    /// </summary>
    bool HonorTimeSyncRequests { get; set; }
}