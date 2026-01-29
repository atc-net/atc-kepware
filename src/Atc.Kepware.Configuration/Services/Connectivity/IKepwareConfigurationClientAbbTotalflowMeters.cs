// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles ABB Totalflow meter calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns all meter groups for the specified ABB Totalflow device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<IList<AbbTotalflowMeterGroup>?>> GetAbbTotalflowMeterGroups(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified ABB Totalflow meter group.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="meterGroupName">The Meter Group Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<AbbTotalflowMeterGroup?>> GetAbbTotalflowMeterGroup(
        string channelName,
        string deviceName,
        string meterGroupName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Updates an existing ABB Totalflow meter group.
    /// </summary>
    /// <param name="request">The Meter Group Update Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="meterGroupName">The Meter Group Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> UpdateAbbTotalflowMeterGroup(
        MeterGroupUpdateRequest request,
        string channelName,
        string deviceName,
        string meterGroupName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns all meters for the specified ABB Totalflow meter group.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="meterGroupName">The Meter Group Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<IList<AbbTotalflowMeter>?>> GetAbbTotalflowMeters(
        string channelName,
        string deviceName,
        string meterGroupName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified ABB Totalflow meter.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="meterGroupName">The Meter Group Name.</param>
    /// <param name="meterName">The Meter Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<AbbTotalflowMeter?>> GetAbbTotalflowMeter(
        string channelName,
        string deviceName,
        string meterGroupName,
        string meterName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Creates a new ABB Totalflow meter under the specified meter group.
    /// </summary>
    /// <param name="request">The ABB Totalflow Meter Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="meterGroupName">The Meter Group Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> CreateAbbTotalflowMeter(
        AbbTotalflowMeterRequest request,
        string channelName,
        string deviceName,
        string meterGroupName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Updates an existing ABB Totalflow meter.
    /// </summary>
    /// <param name="request">The ABB Totalflow Meter Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="meterGroupName">The Meter Group Name.</param>
    /// <param name="meterName">The Meter Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> UpdateAbbTotalflowMeter(
        AbbTotalflowMeterRequest request,
        string channelName,
        string deviceName,
        string meterGroupName,
        string meterName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Deletes an ABB Totalflow meter.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="meterGroupName">The Meter Group Name.</param>
    /// <param name="meterName">The Meter Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> DeleteAbbTotalflowMeter(
        string channelName,
        string deviceName,
        string meterGroupName,
        string meterName,
        CancellationToken cancellationToken);
}