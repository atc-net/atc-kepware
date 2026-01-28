// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles Beckhoff TwinCAT calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public async Task<HttpClientRequestResult<BeckhoffTwinCatChannel?>> GetBeckhoffTwinCatChannel(
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);

        var response = await Get<KepwareContracts.Connectivity.BeckhoffTwinCat.BeckhoffTwinCatChannel>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.DeviceDriver.Equals(DriverType.BeckhoffTwinCat.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<BeckhoffTwinCatChannel?>(HttpStatusCode.NotFound, data: null, $"Retrieved channel '{channelName}' is not a '{DriverType.BeckhoffTwinCat.GetDescription()}' channel.");
        }

        return response.Adapt<HttpClientRequestResult<BeckhoffTwinCatChannel?>>();
    }

    public async Task<HttpClientRequestResult<BeckhoffTwinCatDevice?>> GetBeckhoffTwinCatDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);

        var response = await Get<KepwareContracts.Connectivity.BeckhoffTwinCat.BeckhoffTwinCatDevice>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.Driver.Equals(DriverType.BeckhoffTwinCat.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<BeckhoffTwinCatDevice?>(HttpStatusCode.NotFound, data: null, $"Retrieved device '{deviceName}' is not a '{DriverType.BeckhoffTwinCat.GetDescription()}' device.");
        }

        return response.Adapt<HttpClientRequestResult<BeckhoffTwinCatDevice?>>();
    }

    public Task<HttpClientRequestResult<bool>> CreateBeckhoffTwinCatChannel(
        BeckhoffTwinCatChannelRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateBeckhoffTwinCatChannel(
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateBeckhoffTwinCatDevice(
        BeckhoffTwinCatDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        ArgumentNullException.ThrowIfNull(channelName);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateBeckhoffTwinCatDevice(
            request,
            channelName,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeCreateBeckhoffTwinCatChannel(
        BeckhoffTwinCatChannelRequest request,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.BeckhoffTwinCat.BeckhoffTwinCatChannelRequest>(),
            EndpointPathTemplateConstants.Channels,
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeCreateBeckhoffTwinCatDevice(
        BeckhoffTwinCatDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.BeckhoffTwinCat.BeckhoffTwinCatDeviceRequest>(),
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);
}
