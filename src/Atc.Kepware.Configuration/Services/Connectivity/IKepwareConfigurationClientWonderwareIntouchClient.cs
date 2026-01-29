// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles Wonderware InTouch Client calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified Wonderware InTouch Client channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<WonderwareIntouchClientChannel?>> GetWonderwareIntouchClientChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified Wonderware InTouch Client device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<WonderwareIntouchClientDevice?>> GetWonderwareIntouchClientDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Wonderware InTouch Client channel.
    /// </summary>
    /// <param name="request">The Wonderware InTouch Client Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateWonderwareIntouchClientChannel(
        WonderwareIntouchClientChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Wonderware InTouch Client device under the specified channel.
    /// </summary>
    /// <param name="request">The Wonderware InTouch Client Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateWonderwareIntouchClientDevice(
        WonderwareIntouchClientDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}
