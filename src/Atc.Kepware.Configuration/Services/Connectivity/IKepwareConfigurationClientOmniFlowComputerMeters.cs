// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles Omni Flow Computer meter calls.
/// </summary>
/// <remarks>
/// Omni Flow Computer meters are auto-generated and cannot be created or deleted via API.
/// Only read and update operations are available.
/// </remarks>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    /// <summary>
    /// Returns all meter groups for the specified Omni Flow Computer device.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<IList<OmniFlowComputerMeterGroup>?>> GetOmniFlowComputerMeterGroups(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified Omni Flow Computer meter group.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="meterGroupName">The Meter Group Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<OmniFlowComputerMeterGroup?>> GetOmniFlowComputerMeterGroup(
        string channelName,
        string deviceName,
        string meterGroupName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Updates an existing Omni Flow Computer meter group.
    /// </summary>
    /// <param name="request">The Meter Group Update Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="meterGroupName">The Meter Group Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> UpdateOmniFlowComputerMeterGroup(
        MeterGroupUpdateRequest request,
        string channelName,
        string deviceName,
        string meterGroupName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns all meters for the specified Omni Flow Computer meter group.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="meterGroupName">The Meter Group Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<IList<OmniFlowComputerMeter>?>> GetOmniFlowComputerMeters(
        string channelName,
        string deviceName,
        string meterGroupName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Returns the properties of the specified Omni Flow Computer meter.
    /// </summary>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="meterGroupName">The Meter Group Name.</param>
    /// <param name="meterName">The Meter Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<OmniFlowComputerMeter?>> GetOmniFlowComputerMeter(
        string channelName,
        string deviceName,
        string meterGroupName,
        string meterName,
        CancellationToken cancellationToken);

    /// <summary>
    /// Updates an existing Omni Flow Computer meter.
    /// </summary>
    /// <remarks>
    /// Omni Flow Computer meters are auto-generated and can only be updated, not created or deleted.
    /// </remarks>
    /// <param name="request">The Omni Flow Computer Meter Update Request.</param>
    /// <param name="channelName">The Channel Name.</param>
    /// <param name="deviceName">The Device Name.</param>
    /// <param name="meterGroupName">The Meter Group Name.</param>
    /// <param name="meterName">The Meter Name.</param>
    /// <param name="cancellationToken">The CancellationToken.</param>
    Task<HttpClientRequestResult<bool>> UpdateOmniFlowComputerMeter(
        OmniFlowComputerMeterUpdateRequest request,
        string channelName,
        string deviceName,
        string meterGroupName,
        string meterName,
        CancellationToken cancellationToken);
}