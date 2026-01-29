// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles AutomationDirect EBC calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public async Task<HttpClientRequestResult<AutomationDirectEbcChannel?>> GetAutomationDirectEbcChannel(
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);

        var response = await Get<KepwareContracts.Connectivity.AutomationDirectEbc.AutomationDirectEbcChannel>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.DeviceDriver.Equals(DriverType.AutomationDirectEbc.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<AutomationDirectEbcChannel?>(HttpStatusCode.NotFound, data: null, $"Retrieved channel '{channelName}' is not a '{DriverType.AutomationDirectEbc.GetDescription()}' channel.");
        }

        return response.Adapt<HttpClientRequestResult<AutomationDirectEbcChannel?>>();
    }

    public async Task<HttpClientRequestResult<AutomationDirectEbcDevice?>> GetAutomationDirectEbcDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);

        var response = await Get<KepwareContracts.Connectivity.AutomationDirectEbc.AutomationDirectEbcDevice>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.Driver.Equals(DriverType.AutomationDirectEbc.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<AutomationDirectEbcDevice?>(HttpStatusCode.NotFound, data: null, $"Retrieved device '{deviceName}' is not a '{DriverType.AutomationDirectEbc.GetDescription()}' device.");
        }

        return response.Adapt<HttpClientRequestResult<AutomationDirectEbcDevice?>>();
    }

    public Task<HttpClientRequestResult<bool>> CreateAutomationDirectEbcChannel(
        AutomationDirectEbcChannelRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateAutomationDirectEbcChannel(
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateAutomationDirectEbcDevice(
        AutomationDirectEbcDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        ArgumentNullException.ThrowIfNull(channelName);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateAutomationDirectEbcDevice(
            request,
            channelName,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeCreateAutomationDirectEbcChannel(
        AutomationDirectEbcChannelRequest request,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.AutomationDirectEbc.AutomationDirectEbcChannelRequest>(),
            EndpointPathTemplateConstants.Channels,
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeCreateAutomationDirectEbcDevice(
        AutomationDirectEbcDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.AutomationDirectEbc.AutomationDirectEbcDeviceRequest>(),
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);
}