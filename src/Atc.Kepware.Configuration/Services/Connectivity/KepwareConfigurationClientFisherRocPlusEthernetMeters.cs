// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles Fisher ROC Plus Ethernet meter calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public async Task<HttpClientRequestResult<IList<FisherRocPlusEthernetMeterGroup>?>> GetFisherRocPlusEthernetMeterGroups(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);

        var response = await Get<IList<KepwareContracts.Connectivity.FisherRocPlusEthernet.FisherRocPlusEthernetMeterGroup>>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}/{EndpointPathTemplateConstants.MeterGroups}",
            cancellationToken);

        return response.Adapt<HttpClientRequestResult<IList<FisherRocPlusEthernetMeterGroup>?>>();
    }

    public async Task<HttpClientRequestResult<FisherRocPlusEthernetMeterGroup?>> GetFisherRocPlusEthernetMeterGroup(
        string channelName,
        string deviceName,
        string meterGroupName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);
        ArgumentNullException.ThrowIfNull(meterGroupName);

        var response = await Get<KepwareContracts.Connectivity.FisherRocPlusEthernet.FisherRocPlusEthernetMeterGroup>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}/{EndpointPathTemplateConstants.MeterGroups}/{meterGroupName}",
            cancellationToken);

        return response.Adapt<HttpClientRequestResult<FisherRocPlusEthernetMeterGroup?>>();
    }

    public Task<HttpClientRequestResult<bool>> UpdateFisherRocPlusEthernetMeterGroup(
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

    public async Task<HttpClientRequestResult<IList<FisherRocPlusEthernetMeter>?>> GetFisherRocPlusEthernetMeters(
        string channelName,
        string deviceName,
        string meterGroupName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);
        ArgumentNullException.ThrowIfNull(meterGroupName);

        var response = await Get<IList<KepwareContracts.Connectivity.FisherRocPlusEthernet.FisherRocPlusEthernetMeter>>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}/{EndpointPathTemplateConstants.MeterGroups}/{meterGroupName}/{EndpointPathTemplateConstants.FisherRocPlusEthernetMeters}",
            cancellationToken);

        return response.Adapt<HttpClientRequestResult<IList<FisherRocPlusEthernetMeter>?>>();
    }

    public async Task<HttpClientRequestResult<FisherRocPlusEthernetMeter?>> GetFisherRocPlusEthernetMeter(
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

        var response = await Get<KepwareContracts.Connectivity.FisherRocPlusEthernet.FisherRocPlusEthernetMeter>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}/{EndpointPathTemplateConstants.MeterGroups}/{meterGroupName}/{EndpointPathTemplateConstants.FisherRocPlusEthernetMeters}/{meterName}",
            cancellationToken);

        return response.Adapt<HttpClientRequestResult<FisherRocPlusEthernetMeter?>>();
    }

    public Task<HttpClientRequestResult<bool>> CreateFisherRocPlusEthernetMeter(
        FisherRocPlusEthernetMeterRequest request,
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
            request.Adapt<KepwareContracts.Connectivity.FisherRocPlusEthernet.FisherRocPlusEthernetMeterRequest>(),
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}/{EndpointPathTemplateConstants.MeterGroups}/{meterGroupName}/{EndpointPathTemplateConstants.FisherRocPlusEthernetMeters}",
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> UpdateFisherRocPlusEthernetMeter(
        FisherRocPlusEthernetMeterRequest request,
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
            request.Adapt<KepwareContracts.Connectivity.FisherRocPlusEthernet.FisherRocPlusEthernetMeterRequest>(),
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}/{EndpointPathTemplateConstants.MeterGroups}/{meterGroupName}/{EndpointPathTemplateConstants.FisherRocPlusEthernetMeters}/{meterName}",
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> DeleteFisherRocPlusEthernetMeter(
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
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}/{EndpointPathTemplateConstants.MeterGroups}/{meterGroupName}/{EndpointPathTemplateConstants.FisherRocPlusEthernetMeters}/{meterName}",
            cancellationToken);
    }
}