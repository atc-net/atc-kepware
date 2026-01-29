// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles Bristol BSAP IP calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified Bristol BSAP IP channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<BristolBsapIpChannel?>> GetBristolBsapIpChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified Bristol BSAP IP device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<BristolBsapIpDevice?>> GetBristolBsapIpDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Bristol BSAP IP channel.
    /// </summary>
    /// <param name="request">The Bristol BSAP IP Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateBristolBsapIpChannel(
        BristolBsapIpChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Bristol BSAP IP device under the specified channel.
    /// </summary>
    /// <param name="request">The Bristol BSAP IP Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateBristolBsapIpDevice(
        BristolBsapIpDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}