// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles BACnet/IP calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified BACnet/IP channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<BacNetIpChannel?>> GetBacNetIpChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified BACnet/IP device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<BacNetIpDevice?>> GetBacNetIpDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new BACnet/IP channel.
    /// </summary>
    /// <param name="request">The BACnet/IP Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateBacNetIpChannel(
        BacNetIpChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new BACnet/IP device under the specified channel.
    /// </summary>
    /// <param name="request">The BACnet/IP Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateBacNetIpDevice(
        BacNetIpDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}