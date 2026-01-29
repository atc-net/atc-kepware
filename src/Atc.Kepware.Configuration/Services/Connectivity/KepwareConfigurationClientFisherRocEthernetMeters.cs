// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles Fisher ROC Ethernet meter calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public async Task<HttpClientRequestResult<IList<FisherRocEthernetMeterGroup>?>> GetFisherRocEthernetMeterGroups(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);

        var response = await Get<IList<KepwareContracts.Connectivity.FisherRocEthernet.FisherRocEthernetMeterGroup>>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}/{EndpointPathTemplateConstants.MeterGroups}",
            cancellationToken);

        return response.Adapt<HttpClientRequestResult<IList<FisherRocEthernetMeterGroup>?>>();
    }

    public async Task<HttpClientRequestResult<FisherRocEthernetMeterGroup?>> GetFisherRocEthernetMeterGroup(
        string channelName,
        string deviceName,
        string meterGroupName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);
        ArgumentNullException.ThrowIfNull(meterGroupName);

        var response = await Get<KepwareContracts.Connectivity.FisherRocEthernet.FisherRocEthernetMeterGroup>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}/{EndpointPathTemplateConstants.MeterGroups}/{meterGroupName}",
            cancellationToken);

        return response.Adapt<HttpClientRequestResult<FisherRocEthernetMeterGroup?>>();
    }

    public Task<HttpClientRequestResult<bool>> UpdateFisherRocEthernetMeterGroup(
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

    public async Task<HttpClientRequestResult<IList<FisherRocEthernetMeter>?>> GetFisherRocEthernetMeters(
        string channelName,
        string deviceName,
        string meterGroupName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);
        ArgumentNullException.ThrowIfNull(meterGroupName);

        var response = await Get<IList<KepwareContracts.Connectivity.FisherRocEthernet.FisherRocEthernetMeter>>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}/{EndpointPathTemplateConstants.MeterGroups}/{meterGroupName}/{EndpointPathTemplateConstants.FisherRocEthernetMeters}",
            cancellationToken);

        return response.Adapt<HttpClientRequestResult<IList<FisherRocEthernetMeter>?>>();
    }

    public async Task<HttpClientRequestResult<FisherRocEthernetMeter?>> GetFisherRocEthernetMeter(
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

        var response = await Get<KepwareContracts.Connectivity.FisherRocEthernet.FisherRocEthernetMeter>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}/{EndpointPathTemplateConstants.MeterGroups}/{meterGroupName}/{EndpointPathTemplateConstants.FisherRocEthernetMeters}/{meterName}",
            cancellationToken);

        return response.Adapt<HttpClientRequestResult<FisherRocEthernetMeter?>>();
    }

    public Task<HttpClientRequestResult<bool>> CreateFisherRocEthernetMeter(
        FisherRocEthernetMeterRequest request,
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
            request.Adapt<KepwareContracts.Connectivity.FisherRocEthernet.FisherRocEthernetMeterRequest>(),
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}/{EndpointPathTemplateConstants.MeterGroups}/{meterGroupName}/{EndpointPathTemplateConstants.FisherRocEthernetMeters}",
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> UpdateFisherRocEthernetMeter(
        FisherRocEthernetMeterRequest request,
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
            request.Adapt<KepwareContracts.Connectivity.FisherRocEthernet.FisherRocEthernetMeterRequest>(),
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}/{EndpointPathTemplateConstants.MeterGroups}/{meterGroupName}/{EndpointPathTemplateConstants.FisherRocEthernetMeters}/{meterName}",
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> DeleteFisherRocEthernetMeter(
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
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}/{EndpointPathTemplateConstants.MeterGroups}/{meterGroupName}/{EndpointPathTemplateConstants.FisherRocEthernetMeters}/{meterName}",
            cancellationToken);
    }
}