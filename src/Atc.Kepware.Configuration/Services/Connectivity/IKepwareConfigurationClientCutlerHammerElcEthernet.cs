// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles Cutler-Hammer ELC Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified Cutler-Hammer ELC Ethernet channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<CutlerHammerElcEthernetChannel?>> GetCutlerHammerElcEthernetChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified Cutler-Hammer ELC Ethernet device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<CutlerHammerElcEthernetDevice?>> GetCutlerHammerElcEthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Cutler-Hammer ELC Ethernet channel.
    /// </summary>
    /// <param name="request">The Cutler-Hammer ELC Ethernet Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateCutlerHammerElcEthernetChannel(
        CutlerHammerElcEthernetChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Cutler-Hammer ELC Ethernet device under the specified channel.
    /// </summary>
    /// <param name="request">The Cutler-Hammer ELC Ethernet Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateCutlerHammerElcEthernetDevice(
        CutlerHammerElcEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}