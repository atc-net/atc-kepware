// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles Siemens TCP/IP Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public async Task<HttpClientRequestResult<SiemensTcpIpEthernetChannel?>> GetSiemensTcpIpEthernetChannel(
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);

        var response = await Get<KepwareContracts.Connectivity.SiemensTcpIpEthernet.SiemensTcpIpEthernetChannel>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.DeviceDriver.Equals(DriverType.SiemensTcpIpEthernet.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<SiemensTcpIpEthernetChannel?>(HttpStatusCode.NotFound, data: null, $"Retrieved channel '{channelName}' is not a '{DriverType.SiemensTcpIpEthernet.GetDescription()}' channel.");
        }

        return response.Adapt<HttpClientRequestResult<SiemensTcpIpEthernetChannel?>>();
    }

    public async Task<HttpClientRequestResult<SiemensTcpIpEthernetDevice?>> GetSiemensTcpIpEthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);

        var response = await Get<KepwareContracts.Connectivity.SiemensTcpIpEthernet.SiemensTcpIpEthernetDevice>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.Driver.Equals(DriverType.SiemensTcpIpEthernet.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<SiemensTcpIpEthernetDevice?>(HttpStatusCode.NotFound, data: null, $"Retrieved device '{deviceName}' is not a '{DriverType.SiemensTcpIpEthernet.GetDescription()}' device.");
        }

        return response.Adapt<HttpClientRequestResult<SiemensTcpIpEthernetDevice?>>();
    }

    public Task<HttpClientRequestResult<bool>> CreateSiemensTcpIpEthernetChannel(
        SiemensTcpIpEthernetChannelRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateSiemensTcpIpEthernetChannel(
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateSiemensTcpIpEthernetDevice(
        SiemensTcpIpEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        ArgumentNullException.ThrowIfNull(channelName);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateSiemensTcpIpEthernetDevice(
            request,
            channelName,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeCreateSiemensTcpIpEthernetChannel(
        SiemensTcpIpEthernetChannelRequest request,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.SiemensTcpIpEthernet.SiemensTcpIpEthernetChannelRequest>(),
            EndpointPathTemplateConstants.Channels,
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeCreateSiemensTcpIpEthernetDevice(
        SiemensTcpIpEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.SiemensTcpIpEthernet.SiemensTcpIpEthernetDeviceRequest>(),
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);
}