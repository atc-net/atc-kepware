// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles GE Ethernet Global Data calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public async Task<HttpClientRequestResult<GeEthernetGlobalDataChannel?>> GetGeEthernetGlobalDataChannel(
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);

        var response = await Get<KepwareContracts.Connectivity.GeEthernetGlobalData.GeEthernetGlobalDataChannel>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.DeviceDriver.Equals(DriverType.GeEthernetGlobalData.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<GeEthernetGlobalDataChannel?>(HttpStatusCode.NotFound, data: null, $"Retrieved channel '{channelName}' is not a '{DriverType.GeEthernetGlobalData.GetDescription()}' channel.");
        }

        return response.Adapt<HttpClientRequestResult<GeEthernetGlobalDataChannel?>>();
    }

    public async Task<HttpClientRequestResult<GeEthernetGlobalDataDevice?>> GetGeEthernetGlobalDataDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);

        var response = await Get<KepwareContracts.Connectivity.GeEthernetGlobalData.GeEthernetGlobalDataDevice>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.Driver.Equals(DriverType.GeEthernetGlobalData.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<GeEthernetGlobalDataDevice?>(HttpStatusCode.NotFound, data: null, $"Retrieved device '{deviceName}' is not a '{DriverType.GeEthernetGlobalData.GetDescription()}' device.");
        }

        return response.Adapt<HttpClientRequestResult<GeEthernetGlobalDataDevice?>>();
    }

    public Task<HttpClientRequestResult<bool>> CreateGeEthernetGlobalDataChannel(
        GeEthernetGlobalDataChannelRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateGeEthernetGlobalDataChannel(
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateGeEthernetGlobalDataDevice(
        GeEthernetGlobalDataDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        ArgumentNullException.ThrowIfNull(channelName);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateGeEthernetGlobalDataDevice(
            request,
            channelName,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeCreateGeEthernetGlobalDataChannel(
        GeEthernetGlobalDataChannelRequest request,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.GeEthernetGlobalData.GeEthernetGlobalDataChannelRequest>(),
            EndpointPathTemplateConstants.Channels,
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeCreateGeEthernetGlobalDataDevice(
        GeEthernetGlobalDataDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.GeEthernetGlobalData.GeEthernetGlobalDataDeviceRequest>(),
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);
}