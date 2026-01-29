// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles IEC 61850 MMS Client calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified IEC 61850 MMS Client channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<Iec61850MmsClientChannel?>> GetIec61850MmsClientChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified IEC 61850 MMS Client device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<Iec61850MmsClientDevice?>> GetIec61850MmsClientDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new IEC 61850 MMS Client channel.
    /// </summary>
    /// <param name="request">The IEC 61850 MMS Client Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateIec61850MmsClientChannel(
        Iec61850MmsClientChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new IEC 61850 MMS Client device under the specified channel.
    /// </summary>
    /// <param name="request">The IEC 61850 MMS Client Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateIec61850MmsClientDevice(
        Iec61850MmsClientDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}