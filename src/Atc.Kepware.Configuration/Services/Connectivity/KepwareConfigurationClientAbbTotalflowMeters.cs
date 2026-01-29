// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles ABB Totalflow meter calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public async Task<HttpClientRequestResult<IList<AbbTotalflowMeterGroup>?>> GetAbbTotalflowMeterGroups(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);

        var response = await Get<IList<KepwareContracts.Connectivity.AbbTotalflow.AbbTotalflowMeterGroup>>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}/{EndpointPathTemplateConstants.MeterGroups}",
            cancellationToken);

        return response.Adapt<HttpClientRequestResult<IList<AbbTotalflowMeterGroup>?>>();
    }

    public async Task<HttpClientRequestResult<AbbTotalflowMeterGroup?>> GetAbbTotalflowMeterGroup(
        string channelName,
        string deviceName,
        string meterGroupName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);
        ArgumentNullException.ThrowIfNull(meterGroupName);

        var response = await Get<KepwareContracts.Connectivity.AbbTotalflow.AbbTotalflowMeterGroup>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}/{EndpointPathTemplateConstants.MeterGroups}/{meterGroupName}",
            cancellationToken);

        return response.Adapt<HttpClientRequestResult<AbbTotalflowMeterGroup?>>();
    }

    public Task<HttpClientRequestResult<bool>> UpdateAbbTotalflowMeterGroup(
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

    public async Task<HttpClientRequestResult<IList<AbbTotalflowMeter>?>> GetAbbTotalflowMeters(
        string channelName,
        string deviceName,
        string meterGroupName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);
        ArgumentNullException.ThrowIfNull(meterGroupName);

        var response = await Get<IList<KepwareContracts.Connectivity.AbbTotalflow.AbbTotalflowMeter>>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}/{EndpointPathTemplateConstants.MeterGroups}/{meterGroupName}/{EndpointPathTemplateConstants.AbbTotalflowMeters}",
            cancellationToken);

        return response.Adapt<HttpClientRequestResult<IList<AbbTotalflowMeter>?>>();
    }

    public async Task<HttpClientRequestResult<AbbTotalflowMeter?>> GetAbbTotalflowMeter(
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

        var response = await Get<KepwareContracts.Connectivity.AbbTotalflow.AbbTotalflowMeter>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}/{EndpointPathTemplateConstants.MeterGroups}/{meterGroupName}/{EndpointPathTemplateConstants.AbbTotalflowMeters}/{meterName}",
            cancellationToken);

        return response.Adapt<HttpClientRequestResult<AbbTotalflowMeter?>>();
    }

    public Task<HttpClientRequestResult<bool>> CreateAbbTotalflowMeter(
        AbbTotalflowMeterRequest request,
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

        return Post(
            request.Adapt<KepwareContracts.Connectivity.AbbTotalflow.AbbTotalflowMeterRequest>(),
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}/{EndpointPathTemplateConstants.MeterGroups}/{meterGroupName}/{EndpointPathTemplateConstants.AbbTotalflowMeters}",
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> UpdateAbbTotalflowMeter(
        AbbTotalflowMeterRequest request,
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
            request.Adapt<KepwareContracts.Connectivity.AbbTotalflow.AbbTotalflowMeterRequest>(),
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}/{EndpointPathTemplateConstants.MeterGroups}/{meterGroupName}/{EndpointPathTemplateConstants.AbbTotalflowMeters}/{meterName}",
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> DeleteAbbTotalflowMeter(
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

        return Delete(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}/{EndpointPathTemplateConstants.MeterGroups}/{meterGroupName}/{EndpointPathTemplateConstants.AbbTotalflowMeters}/{meterName}",
            cancellationToken);
    }
}
