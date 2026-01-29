// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles IEC 61850 MMS Client calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public async Task<HttpClientRequestResult<Iec61850MmsClientChannel?>> GetIec61850MmsClientChannel(
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);

        var response = await Get<KepwareContracts.Connectivity.Iec61850MmsClient.Iec61850MmsClientChannel>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.DeviceDriver.Equals(DriverType.Iec61850MmsClient.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<Iec61850MmsClientChannel?>(HttpStatusCode.NotFound, data: null, $"Retrieved channel '{channelName}' is not a '{DriverType.Iec61850MmsClient.GetDescription()}' channel.");
        }

        return response.Adapt<HttpClientRequestResult<Iec61850MmsClientChannel?>>();
    }

    public async Task<HttpClientRequestResult<Iec61850MmsClientDevice?>> GetIec61850MmsClientDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);

        var response = await Get<KepwareContracts.Connectivity.Iec61850MmsClient.Iec61850MmsClientDevice>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.Driver.Equals(DriverType.Iec61850MmsClient.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<Iec61850MmsClientDevice?>(HttpStatusCode.NotFound, data: null, $"Retrieved device '{deviceName}' is not a '{DriverType.Iec61850MmsClient.GetDescription()}' device.");
        }

        return response.Adapt<HttpClientRequestResult<Iec61850MmsClientDevice?>>();
    }

    public Task<HttpClientRequestResult<bool>> CreateIec61850MmsClientChannel(
        Iec61850MmsClientChannelRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateIec61850MmsClientChannel(
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateIec61850MmsClientDevice(
        Iec61850MmsClientDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        ArgumentNullException.ThrowIfNull(channelName);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateIec61850MmsClientDevice(
            request,
            channelName,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeCreateIec61850MmsClientChannel(
        Iec61850MmsClientChannelRequest request,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.Iec61850MmsClient.Iec61850MmsClientChannelRequest>(),
            EndpointPathTemplateConstants.Channels,
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeCreateIec61850MmsClientDevice(
        Iec61850MmsClientDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.Iec61850MmsClient.Iec61850MmsClientDeviceRequest>(),
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);
}