// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles Yaskawa MP Series Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public async Task<HttpClientRequestResult<YaskawaMpSeriesEthernetChannel?>> GetYaskawaMpSeriesEthernetChannel(
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);

        var response = await Get<KepwareContracts.Connectivity.YaskawaMpSeriesEthernet.YaskawaMpSeriesEthernetChannel>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.DeviceDriver.Equals(DriverType.YaskawaMpSeriesEthernet.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<YaskawaMpSeriesEthernetChannel?>(HttpStatusCode.NotFound, data: null, $"Retrieved channel '{channelName}' is not a '{DriverType.YaskawaMpSeriesEthernet.GetDescription()}' channel.");
        }

        return response.Adapt<HttpClientRequestResult<YaskawaMpSeriesEthernetChannel?>>();
    }

    public async Task<HttpClientRequestResult<YaskawaMpSeriesEthernetDevice?>> GetYaskawaMpSeriesEthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);

        var response = await Get<KepwareContracts.Connectivity.YaskawaMpSeriesEthernet.YaskawaMpSeriesEthernetDevice>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.Driver.Equals(DriverType.YaskawaMpSeriesEthernet.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<YaskawaMpSeriesEthernetDevice?>(HttpStatusCode.NotFound, data: null, $"Retrieved device '{deviceName}' is not a '{DriverType.YaskawaMpSeriesEthernet.GetDescription()}' device.");
        }

        return response.Adapt<HttpClientRequestResult<YaskawaMpSeriesEthernetDevice?>>();
    }

    public Task<HttpClientRequestResult<bool>> CreateYaskawaMpSeriesEthernetChannel(
        YaskawaMpSeriesEthernetChannelRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateYaskawaMpSeriesEthernetChannel(
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateYaskawaMpSeriesEthernetDevice(
        YaskawaMpSeriesEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        ArgumentNullException.ThrowIfNull(channelName);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateYaskawaMpSeriesEthernetDevice(
            request,
            channelName,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeCreateYaskawaMpSeriesEthernetChannel(
        YaskawaMpSeriesEthernetChannelRequest request,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.YaskawaMpSeriesEthernet.YaskawaMpSeriesEthernetChannelRequest>(),
            EndpointPathTemplateConstants.Channels,
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeCreateYaskawaMpSeriesEthernetDevice(
        YaskawaMpSeriesEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.YaskawaMpSeriesEthernet.YaskawaMpSeriesEthernetDeviceRequest>(),
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);
}