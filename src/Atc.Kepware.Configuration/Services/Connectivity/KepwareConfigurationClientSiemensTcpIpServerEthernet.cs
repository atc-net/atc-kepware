// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles Siemens TCP/IP Server Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public async Task<HttpClientRequestResult<SiemensTcpIpServerEthernetChannel?>> GetSiemensTcpIpServerEthernetChannel(
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);

        var response = await Get<KepwareContracts.Connectivity.SiemensTcpIpServerEthernet.SiemensTcpIpServerEthernetChannel>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.DeviceDriver.Equals(DriverType.SiemensTcpIpServerEthernet.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<SiemensTcpIpServerEthernetChannel?>(HttpStatusCode.NotFound, data: null, $"Retrieved channel '{channelName}' is not a '{DriverType.SiemensTcpIpServerEthernet.GetDescription()}' channel.");
        }

        return response.Adapt<HttpClientRequestResult<SiemensTcpIpServerEthernetChannel?>>();
    }

    public async Task<HttpClientRequestResult<SiemensTcpIpServerEthernetDevice?>> GetSiemensTcpIpServerEthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);

        var response = await Get<KepwareContracts.Connectivity.SiemensTcpIpServerEthernet.SiemensTcpIpServerEthernetDevice>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.Driver.Equals(DriverType.SiemensTcpIpServerEthernet.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<SiemensTcpIpServerEthernetDevice?>(HttpStatusCode.NotFound, data: null, $"Retrieved device '{deviceName}' is not a '{DriverType.SiemensTcpIpServerEthernet.GetDescription()}' device.");
        }

        return response.Adapt<HttpClientRequestResult<SiemensTcpIpServerEthernetDevice?>>();
    }

    public Task<HttpClientRequestResult<bool>> CreateSiemensTcpIpServerEthernetChannel(
        SiemensTcpIpServerEthernetChannelRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateSiemensTcpIpServerEthernetChannel(
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateSiemensTcpIpServerEthernetDevice(
        SiemensTcpIpServerEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        ArgumentNullException.ThrowIfNull(channelName);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateSiemensTcpIpServerEthernetDevice(
            request,
            channelName,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeCreateSiemensTcpIpServerEthernetChannel(
        SiemensTcpIpServerEthernetChannelRequest request,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.SiemensTcpIpServerEthernet.SiemensTcpIpServerEthernetChannelRequest>(),
            EndpointPathTemplateConstants.Channels,
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeCreateSiemensTcpIpServerEthernetDevice(
        SiemensTcpIpServerEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.SiemensTcpIpServerEthernet.SiemensTcpIpServerEthernetDeviceRequest>(),
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);
}