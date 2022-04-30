namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles EuroMap 63 calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public async Task<HttpClientRequestResult<EuroMap63Channel?>> GetEuroMap63Channel(
        string channelName,
        CancellationToken cancellationToken)
    {
        var response = await Get<KepwareContracts.EuroMap63.EuroMap63Channel>(
            $"{EndpointPathTemplateConstants.ProjectChannels}/{channelName}",
            cancellationToken);

        if (response.CommunicationSucceeded &&
            response.HasData &&
            !response.Data!.DeviceDriver.Equals(DriverType.EuroMap63.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<EuroMap63Channel?>(HttpStatusCode.NotFound, data: null, $"Retrieved channel '{channelName}' is not a '{DriverType.EuroMap63.GetDescription()}' channel.");
        }

        return response.Adapt<HttpClientRequestResult<EuroMap63Channel?>>();
    }

    public async Task<HttpClientRequestResult<EuroMap63Device?>> GetEuroMap63Device(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken)
    {
        var response = await Get<KepwareContracts.EuroMap63.EuroMap63Device>(
            $"{EndpointPathTemplateConstants.ProjectChannels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}",
            cancellationToken);

        if (response.CommunicationSucceeded &&
            response.HasData &&
            !response.Data!.Driver.Equals(DriverType.EuroMap63.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<EuroMap63Device?>(HttpStatusCode.NotFound, data: null, $"Retrieved device '{deviceName}' is not a '{DriverType.EuroMap63.GetDescription()}' device.");
        }

        return response.Adapt<HttpClientRequestResult<EuroMap63Device?>>();
    }

    public Task<HttpClientRequestResult<bool>> CreateEuroMap63Channel(
        EuroMap63ChannelRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateEuroMap63Channel(
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateEuroMap63Device(
        EuroMap63DeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateEuroMap63Device(
            request,
            channelName,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeCreateEuroMap63Channel(
        EuroMap63ChannelRequest request,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.EuroMap63.EuroMap63ChannelRequest>(),
            EndpointPathTemplateConstants.ProjectChannels,
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeCreateEuroMap63Device(
        EuroMap63DeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.EuroMap63.EuroMap63DeviceRequest>(),
            $"{EndpointPathTemplateConstants.ProjectChannels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);
}