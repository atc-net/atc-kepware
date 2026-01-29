// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles AutomationDirect ECOM calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified AutomationDirect ECOM channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<AutomationDirectEcomChannel?>> GetAutomationDirectEcomChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified AutomationDirect ECOM device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<AutomationDirectEcomDevice?>> GetAutomationDirectEcomDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new AutomationDirect ECOM channel.
    /// </summary>
    /// <param name="request">The AutomationDirect ECOM Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateAutomationDirectEcomChannel(
        AutomationDirectEcomChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new AutomationDirect ECOM device under the specified channel.
    /// </summary>
    /// <param name="request">The AutomationDirect ECOM Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateAutomationDirectEcomDevice(
        AutomationDirectEcomDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}