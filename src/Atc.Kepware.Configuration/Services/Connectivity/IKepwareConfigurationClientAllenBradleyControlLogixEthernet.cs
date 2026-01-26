// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles Allen-Bradley ControlLogix Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified Allen-Bradley ControlLogix Ethernet channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<AllenBradleyControlLogixEthernetChannel?>> GetAllenBradleyControlLogixEthernetChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified Allen-Bradley ControlLogix Ethernet device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<AllenBradleyControlLogixEthernetDevice?>> GetAllenBradleyControlLogixEthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Allen-Bradley ControlLogix Ethernet channel.
    /// </summary>
    /// <param name="request">The Allen-Bradley ControlLogix Ethernet Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateAllenBradleyControlLogixEthernetChannel(
        AllenBradleyControlLogixEthernetChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Allen-Bradley ControlLogix Ethernet device under the specified channel.
    /// </summary>
    /// <param name="request">The Allen-Bradley ControlLogix Ethernet Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateAllenBradleyControlLogixEthernetDevice(
        AllenBradleyControlLogixEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}
