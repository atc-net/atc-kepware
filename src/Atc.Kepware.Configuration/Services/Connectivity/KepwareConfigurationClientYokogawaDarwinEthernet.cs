// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles Yokogawa Darwin Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public async Task<HttpClientRequestResult<YokogawaDarwinEthernetChannel?>> GetYokogawaDarwinEthernetChannel(
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);

        var response = await Get<KepwareContracts.Connectivity.YokogawaDarwinEthernet.YokogawaDarwinEthernetChannel>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.DeviceDriver.Equals(DriverType.YokogawaDarwinEthernet.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<YokogawaDarwinEthernetChannel?>(HttpStatusCode.NotFound, data: null, $"Retrieved channel '{channelName}' is not a '{DriverType.YokogawaDarwinEthernet.GetDescription()}' channel.");
        }

        return response.Adapt<HttpClientRequestResult<YokogawaDarwinEthernetChannel?>>();
    }

    public async Task<HttpClientRequestResult<YokogawaDarwinEthernetDevice?>> GetYokogawaDarwinEthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);

        var response = await Get<KepwareContracts.Connectivity.YokogawaDarwinEthernet.YokogawaDarwinEthernetDevice>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.Driver.Equals(DriverType.YokogawaDarwinEthernet.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<YokogawaDarwinEthernetDevice?>(HttpStatusCode.NotFound, data: null, $"Retrieved device '{deviceName}' is not a '{DriverType.YokogawaDarwinEthernet.GetDescription()}' device.");
        }

        return response.Adapt<HttpClientRequestResult<YokogawaDarwinEthernetDevice?>>();
    }

    public Task<HttpClientRequestResult<bool>> CreateYokogawaDarwinEthernetChannel(
        YokogawaDarwinEthernetChannelRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateYokogawaDarwinEthernetChannel(
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateYokogawaDarwinEthernetDevice(
        YokogawaDarwinEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        ArgumentNullException.ThrowIfNull(channelName);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateYokogawaDarwinEthernetDevice(
            request,
            channelName,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeCreateYokogawaDarwinEthernetChannel(
        YokogawaDarwinEthernetChannelRequest request,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.YokogawaDarwinEthernet.YokogawaDarwinEthernetChannelRequest>(),
            EndpointPathTemplateConstants.Channels,
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeCreateYokogawaDarwinEthernetDevice(
        YokogawaDarwinEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.YokogawaDarwinEthernet.YokogawaDarwinEthernetDeviceRequest>(),
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);
}