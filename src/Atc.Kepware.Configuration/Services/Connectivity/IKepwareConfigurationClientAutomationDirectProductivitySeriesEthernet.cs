// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles AutomationDirect Productivity Series Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified AutomationDirect Productivity Series Ethernet channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<AutomationDirectProductivitySeriesEthernetChannel?>> GetAutomationDirectProductivitySeriesEthernetChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified AutomationDirect Productivity Series Ethernet device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<AutomationDirectProductivitySeriesEthernetDevice?>> GetAutomationDirectProductivitySeriesEthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new AutomationDirect Productivity Series Ethernet channel.
    /// </summary>
    /// <param name="request">The AutomationDirect Productivity Series Ethernet Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateAutomationDirectProductivitySeriesEthernetChannel(
        AutomationDirectProductivitySeriesEthernetChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new AutomationDirect Productivity Series Ethernet device under the specified channel.
    /// </summary>
    /// <param name="request">The AutomationDirect Productivity Series Ethernet Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateAutomationDirectProductivitySeriesEthernetDevice(
        AutomationDirectProductivitySeriesEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}
