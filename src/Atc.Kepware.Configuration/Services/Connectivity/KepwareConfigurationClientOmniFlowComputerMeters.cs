// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles Omni Flow Computer meter calls.
/// </summary>
/// <remarks>
/// Omni Flow Computer meters are auto-generated and cannot be created or deleted via API.
/// Only read and update operations are available.
/// </remarks>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public async Task<HttpClientRequestResult<IList<OmniFlowComputerMeterGroup>?>> GetOmniFlowComputerMeterGroups(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);

        var response = await Get<IList<KepwareContracts.Connectivity.OmniFlowComputer.OmniFlowComputerMeterGroup>>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}/{EndpointPathTemplateConstants.MeterGroups}",
            cancellationToken);

        return response.Adapt<HttpClientRequestResult<IList<OmniFlowComputerMeterGroup>?>>();
    }

    public async Task<HttpClientRequestResult<OmniFlowComputerMeterGroup?>> GetOmniFlowComputerMeterGroup(
        string channelName,
        string deviceName,
        string meterGroupName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);
        ArgumentNullException.ThrowIfNull(meterGroupName);

        var response = await Get<KepwareContracts.Connectivity.OmniFlowComputer.OmniFlowComputerMeterGroup>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}/{EndpointPathTemplateConstants.MeterGroups}/{meterGroupName}",
            cancellationToken);

        return response.Adapt<HttpClientRequestResult<OmniFlowComputerMeterGroup?>>();
    }

    public Task<HttpClientRequestResult<bool>> UpdateOmniFlowComputerMeterGroup(
        MeterGroupUpdateRequest request,
        string channelName,
        string deviceName,
        string meterGroupName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);
        ArgumentNullException.ThrowIfNull(meterGroupName);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return Put(
            request.Adapt<KepwareContracts.Connectivity.MeterGroupUpdateRequest>(),
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}/{EndpointPathTemplateConstants.MeterGroups}/{meterGroupName}",
            cancellationToken);
    }

    public async Task<HttpClientRequestResult<IList<OmniFlowComputerMeter>?>> GetOmniFlowComputerMeters(
        string channelName,
        string deviceName,
        string meterGroupName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);
        ArgumentNullException.ThrowIfNull(meterGroupName);

        var response = await Get<IList<KepwareContracts.Connectivity.OmniFlowComputer.OmniFlowComputerMeter>>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}/{EndpointPathTemplateConstants.MeterGroups}/{meterGroupName}/{EndpointPathTemplateConstants.OmniMeters}",
            cancellationToken);

        return response.Adapt<HttpClientRequestResult<IList<OmniFlowComputerMeter>?>>();
    }

    public async Task<HttpClientRequestResult<OmniFlowComputerMeter?>> GetOmniFlowComputerMeter(
        string channelName,
        string deviceName,
        string meterGroupName,
        string meterName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);
        ArgumentNullException.ThrowIfNull(meterGroupName);
        ArgumentNullException.ThrowIfNull(meterName);

        var response = await Get<KepwareContracts.Connectivity.OmniFlowComputer.OmniFlowComputerMeter>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}/{EndpointPathTemplateConstants.MeterGroups}/{meterGroupName}/{EndpointPathTemplateConstants.OmniMeters}/{meterName}",
            cancellationToken);

        return response.Adapt<HttpClientRequestResult<OmniFlowComputerMeter?>>();
    }

    public Task<HttpClientRequestResult<bool>> UpdateOmniFlowComputerMeter(
        OmniFlowComputerMeterUpdateRequest request,
        string channelName,
        string deviceName,
        string meterGroupName,
        string meterName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);
        ArgumentNullException.ThrowIfNull(meterGroupName);
        ArgumentNullException.ThrowIfNull(meterName);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return Put(
            request.Adapt<KepwareContracts.Connectivity.OmniFlowComputer.OmniFlowComputerMeterUpdateRequest>(),
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}/{EndpointPathTemplateConstants.MeterGroups}/{meterGroupName}/{EndpointPathTemplateConstants.OmniMeters}/{meterName}",
            cancellationToken);
    }
}