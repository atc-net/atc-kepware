// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles Fisher ROC Ethernet meter calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns all meter groups for the specified Fisher ROC Ethernet device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<IList<FisherRocEthernetMeterGroup>?>> GetFisherRocEthernetMeterGroups(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified Fisher ROC Ethernet meter group.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="meterGroupName">The Meter Group Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<FisherRocEthernetMeterGroup?>> GetFisherRocEthernetMeterGroup(
        string channelName,
        string deviceName,
        string meterGroupName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Updates an existing Fisher ROC Ethernet meter group.
    /// </summary>
    /// <param name="request">The Meter Group Update Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="meterGroupName">The Meter Group Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> UpdateFisherRocEthernetMeterGroup(
        MeterGroupUpdateRequest request,
        string channelName,
        string deviceName,
        string meterGroupName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns all meters for the specified Fisher ROC Ethernet meter group.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="meterGroupName">The Meter Group Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<IList<FisherRocEthernetMeter>?>> GetFisherRocEthernetMeters(
        string channelName,
        string deviceName,
        string meterGroupName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified Fisher ROC Ethernet meter.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="meterGroupName">The Meter Group Name.</param>
    /// <param name="meterName">The Meter Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<FisherRocEthernetMeter?>> GetFisherRocEthernetMeter(
        string channelName,
        string deviceName,
        string meterGroupName,
        string meterName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new Fisher ROC Ethernet meter under the specified meter group.
    /// </summary>
    /// <param name="request">The Fisher ROC Ethernet Meter Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="meterGroupName">The Meter Group Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateFisherRocEthernetMeter(
        FisherRocEthernetMeterRequest request,
        string channelName,
        string deviceName,
        string meterGroupName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Updates an existing Fisher ROC Ethernet meter.
    /// </summary>
    /// <param name="request">The Fisher ROC Ethernet Meter Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="meterGroupName">The Meter Group Name.</param>
    /// <param name="meterName">The Meter Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> UpdateFisherRocEthernetMeter(
        FisherRocEthernetMeterRequest request,
        string channelName,
        string deviceName,
        string meterGroupName,
        string meterName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Deletes a Fisher ROC Ethernet meter.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="meterGroupName">The Meter Group Name.</param>
    /// <param name="meterName">The Meter Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> DeleteFisherRocEthernetMeter(
        string channelName,
        string deviceName,
        string meterGroupName,
        string meterName,
        CancellationToken cancellationToken);
}
