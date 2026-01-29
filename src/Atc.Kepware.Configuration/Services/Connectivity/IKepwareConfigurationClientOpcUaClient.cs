// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles OpcUaClient calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified OpcUaClient channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<OpcUaClientChannel?>> GetOpcUaClientChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified OpcUaClient device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<OpcUaClientDevice?>> GetOpcUaClientDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new OpcUaClient channel.
    /// </summary>
    /// <param name="request">The OpcUaClient Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateOpcUaClientChannel(
        OpcUaClientChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new OpcUaClient device under the specified channel.
    /// </summary>
    /// <param name="request">The OpcUaClient Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateOpcUaClientDevice(
        OpcUaClientDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}