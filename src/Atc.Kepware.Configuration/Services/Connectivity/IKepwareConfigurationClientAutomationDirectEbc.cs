// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles AutomationDirect EBC calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns the properties of the specified AutomationDirect EBC channel.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<AutomationDirectEbcChannel?>> GetAutomationDirectEbcChannel(
        string channelName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified AutomationDirect EBC device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<AutomationDirectEbcDevice?>> GetAutomationDirectEbcDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new AutomationDirect EBC channel.
    /// </summary>
    /// <param name="request">The AutomationDirect EBC Channel Request.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateAutomationDirectEbcChannel(
        AutomationDirectEbcChannelRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new AutomationDirect EBC device under the specified channel.
    /// </summary>
    /// <param name="request">The AutomationDirect EBC Device Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateAutomationDirectEbcDevice(
        AutomationDirectEbcDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken);
}