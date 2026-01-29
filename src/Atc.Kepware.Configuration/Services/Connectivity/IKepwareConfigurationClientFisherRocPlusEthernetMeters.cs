// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles Fisher ROC Plus Ethernet meter calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns all meter groups for the specified Fisher ROC Plus Ethernet device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<IList<FisherRocPlusEthernetMeterGroup>?>> GetFisherRocPlusEthernetMeterGroups(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified Fisher ROC Plus Ethernet meter group.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="meterGroupName">The Meter Group Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<FisherRocPlusEthernetMeterGroup?>> GetFisherRocPlusEthernetMeterGroup(
        string channelName,
        string deviceName,
        string meterGroupName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Updates an existing Fisher ROC Plus Ethernet meter group.
    /// </summary>
    /// <param name="request">The Meter Group Update Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="meterGroupName">The Meter Group Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> UpdateFisherRocPlusEthernetMeterGroup(
        MeterGroupUpdateRequest request,
        string channelName,
        string deviceName,
        string meterGroupName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns all meters for the specified Fisher ROC Plus Ethernet meter group.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="meterGroupName">The Meter Group Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<IList<FisherRocPlusEthernetMeter>?>> GetFisherRocPlusEthernetMeters(
        string channelName,
        string deviceName,
        string meterGroupName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified Fisher ROC Plus Ethernet meter.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="meterGroupName">The Meter Group Name.</param>
    /// <param name="meterName">The Meter Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<FisherRocPlusEthernetMeter?>> GetFisherRocPlusEthernetMeter(
        string channelName,
        string deviceName,
        string meterGroupName,
        string meterName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Fisher ROC Plus Ethernet meter under the specified meter group.
    /// </summary>
    /// <param name="request">The Fisher ROC Plus Ethernet Meter Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="meterGroupName">The Meter Group Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateFisherRocPlusEthernetMeter(
        FisherRocPlusEthernetMeterRequest request,
        string channelName,
        string deviceName,
        string meterGroupName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Updates an existing Fisher ROC Plus Ethernet meter.
    /// </summary>
    /// <param name="request">The Fisher ROC Plus Ethernet Meter Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="meterGroupName">The Meter Group Name.</param>
    /// <param name="meterName">The Meter Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> UpdateFisherRocPlusEthernetMeter(
        FisherRocPlusEthernetMeterRequest request,
        string channelName,
        string deviceName,
        string meterGroupName,
        string meterName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Deletes a Fisher ROC Plus Ethernet meter.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="meterGroupName">The Meter Group Name.</param>
    /// <param name="meterName">The Meter Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> DeleteFisherRocPlusEthernetMeter(
        string channelName,
        string deviceName,
        string meterGroupName,
        string meterName,
        CancellationToken cancellationToken);
}