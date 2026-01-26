// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles Modbus TCP/IP Ethernet calls.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public async Task<HttpClientRequestResult<ModbusTcpIpEthernetChannel?>> GetModbusTcpIpEthernetChannel(
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);

        var response = await Get<KepwareContracts.Connectivity.ModbusTcpIpEthernet.ModbusTcpIpEthernetChannel>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.DeviceDriver.Equals(DriverType.ModbusTcpIpEthernet.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<ModbusTcpIpEthernetChannel?>(HttpStatusCode.NotFound, data: null, $"Retrieved channel '{channelName}' is not a '{DriverType.ModbusTcpIpEthernet.GetDescription()}' channel.");
        }

        return response.Adapt<HttpClientRequestResult<ModbusTcpIpEthernetChannel?>>();
    }

    public async Task<HttpClientRequestResult<ModbusTcpIpEthernetDevice?>> GetModbusTcpIpEthernetDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);

        var response = await Get<KepwareContracts.Connectivity.ModbusTcpIpEthernet.ModbusTcpIpEthernetDevice>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.Driver.Equals(DriverType.ModbusTcpIpEthernet.GetDescription(), StringComparison.Ordinal))
        {
            return new HttpClientRequestResult<ModbusTcpIpEthernetDevice?>(HttpStatusCode.NotFound, data: null, $"Retrieved device '{deviceName}' is not a '{DriverType.ModbusTcpIpEthernet.GetDescription()}' device.");
        }

        return response.Adapt<HttpClientRequestResult<ModbusTcpIpEthernetDevice?>>();
    }

    public Task<HttpClientRequestResult<bool>> CreateModbusTcpIpEthernetChannel(
        ModbusTcpIpEthernetChannelRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateModbusTcpIpEthernetChannel(
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateModbusTcpIpEthernetDevice(
        ModbusTcpIpEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        ArgumentNullException.ThrowIfNull(channelName);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateModbusTcpIpEthernetDevice(
            request,
            channelName,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeCreateModbusTcpIpEthernetChannel(
        ModbusTcpIpEthernetChannelRequest request,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.ModbusTcpIpEthernet.ModbusTcpIpEthernetChannelRequest>(),
            EndpointPathTemplateConstants.Channels,
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeCreateModbusTcpIpEthernetDevice(
        ModbusTcpIpEthernetDeviceRequest request,
        string channelName,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.Connectivity.ModbusTcpIpEthernet.ModbusTcpIpEthernetDeviceRequest>(),
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);
}
