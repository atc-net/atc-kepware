// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles OPC XML-DA Client calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified OPC XML-DA Client channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<OpcXmlDaClientChannel?>> GetOpcXmlDaClientChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified OPC XML-DA Client device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<OpcXmlDaClientDevice?>> GetOpcXmlDaClientDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new OPC XML-DA Client channel.
    /// </summary>
    /// <param name="request">The OPC XML-DA Client Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateOpcXmlDaClientChannel(
        OpcXmlDaClientChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new OPC XML-DA Client device under the specified channel.
    /// </summary>
    /// <param name="request">The OPC XML-DA Client Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateOpcXmlDaClientDevice(
        OpcXmlDaClientDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}