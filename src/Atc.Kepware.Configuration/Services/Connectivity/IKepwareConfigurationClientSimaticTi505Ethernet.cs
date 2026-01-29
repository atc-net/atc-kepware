// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles Simatic/TI 505 Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified Simatic/TI 505 Ethernet channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<SimaticTi505EthernetChannel?>> GetSimaticTi505EthernetChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified Simatic/TI 505 Ethernet device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<SimaticTi505EthernetDevice?>> GetSimaticTi505EthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Simatic/TI 505 Ethernet channel.
    /// </summary>
    /// <param name="request">The Simatic/TI 505 Ethernet Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateSimaticTi505EthernetChannel(
        SimaticTi505EthernetChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Simatic/TI 505 Ethernet device under the specified channel.
    /// </summary>
    /// <param name="request">The Simatic/TI 505 Ethernet Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateSimaticTi505EthernetDevice(
        SimaticTi505EthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}
