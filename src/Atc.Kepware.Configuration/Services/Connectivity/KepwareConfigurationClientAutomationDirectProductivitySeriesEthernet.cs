// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles AutomationDirect Productivity Series Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public async Task<HttpClientRequestResult<AutomationDirectProductivitySeriesEthernetChannel?>> GetAutomationDirectProductivitySeriesEthernetChannel(
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);

        var response = await Get<KepwareContracts.Connectivity.AutomationDirectProductivitySeriesEthernet.AutomationDirectProductivitySeriesEthernetChannel>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.DeviceDriver.Equals(DriverType.AutomationDirectProductivitySeriesEthernet.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<AutomationDirectProductivitySeriesEthernetChannel?>(HttpStatusCode.NotFound, data: null, $"Retrieved channel '{channelName}' is not a '{DriverType.AutomationDirectProductivitySeriesEthernet.GetDescription()}' channel.");
        }

        return response.Adapt<HttpClientRequestResult<AutomationDirectProductivitySeriesEthernetChannel?>>();
    }

    public async Task<HttpClientRequestResult<AutomationDirectProductivitySeriesEthernetDevice?>> GetAutomationDirectProductivitySeriesEthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);

        var response = await Get<KepwareContracts.Connectivity.AutomationDirectProductivitySeriesEthernet.AutomationDirectProductivitySeriesEthernetDevice>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.Driver.Equals(DriverType.AutomationDirectProductivitySeriesEthernet.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<AutomationDirectProductivitySeriesEthernetDevice?>(HttpStatusCode.NotFound, data: null, $"Retrieved device '{deviceName}' is not a '{DriverType.AutomationDirectProductivitySeriesEthernet.GetDescription()}' device.");
        }

        return response.Adapt<HttpClientRequestResult<AutomationDirectProductivitySeriesEthernetDevice?>>();
    }

    public Task<HttpClientRequestResult<bool>> CreateAutomationDirectProductivitySeriesEthernetChannel(
        AutomationDirectProductivitySeriesEthernetChannelRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateAutomationDirectProductivitySeriesEthernetChannel(
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateAutomationDirectProductivitySeriesEthernetDevice(
        AutomationDirectProductivitySeriesEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        ArgumentNullException.ThrowIfNull(channelName);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateAutomationDirectProductivitySeriesEthernetDevice(
            request,
            channelName,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeCreateAutomationDirectProductivitySeriesEthernetChannel(
        AutomationDirectProductivitySeriesEthernetChannelRequest request,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.AutomationDirectProductivitySeriesEthernet.AutomationDirectProductivitySeriesEthernetChannelRequest>(),
            EndpointPathTemplateConstants.Channels,
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeCreateAutomationDirectProductivitySeriesEthernetDevice(
        AutomationDirectProductivitySeriesEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.AutomationDirectProductivitySeriesEthernet.AutomationDirectProductivitySeriesEthernetDeviceRequest>(),
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);
}