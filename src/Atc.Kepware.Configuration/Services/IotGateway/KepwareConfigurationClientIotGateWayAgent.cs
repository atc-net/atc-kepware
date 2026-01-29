// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles Iot Gateway calls for Agents and Iot Items.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design.")]
public sealed partial class KepwareConfigurationClient
{
    public Task<HttpClientRequestResult<bool>> IsIotAgentDefined(
        string iotAgentName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);

        return !IsValidIotGatewayName(
            iotAgentName,
            iotItemName: null,
            out var errorMessage)
            ? Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(errorMessage!))
            : InvokeIsIotAgentDefined(iotAgentName, cancellationToken);
    }

    public Task<HttpClientRequestResult<IotAgentBase?>> GetIotAgentBase(
        string iotAgentName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);

        return !IsValidIotGatewayName(
            iotAgentName,
            iotItemName: null,
            out var errorMessage)
            ? Task.FromResult(HttpClientRequestResultFactory<IotAgentBase>.CreateBadRequest(errorMessage!))
            : InvokeGetIotAgentBase(iotAgentName, cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateIotAgentRestClient(
        IotAgentRestClientCreateRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateIotAgentRestClient(
            request,
            cancellationToken);
    }

    public async Task<HttpClientRequestResult<IList<IotAgentRestClient>?>> GetIotAgentRestClients(
        CancellationToken cancellationToken)
    {
        var response = await Get<IList<KepwareContracts.IotGateway.IotAgentRestClient>>(
            EndpointPathTemplateConstants.IotGatewayRestClients,
            cancellationToken);

        return response.Adapt<HttpClientRequestResult<IList<IotAgentRestClient>?>>();
    }

    public Task<HttpClientRequestResult<IotAgentRestClient?>> GetIotAgentRestClient(
        string iotAgentName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);

        return InvokeGetIotAgentRestClient(iotAgentName, cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> UpdateIotAgentRestClient(
        string iotAgentName,
        IotAgentRestClientUpdateRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeUpdateIotAgentRestClient(
            iotAgentName,
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> DeleteIotAgentMqttClient(
        string iotAgentName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);

        return InvokeDeleteIotAgentMqttClient(
            iotAgentName,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> DeleteIotAgentRestClient(
        string iotAgentName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);

        return InvokeDeleteIotAgentRestClient(
            iotAgentName,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> DeleteIotAgentRestServer(
        string iotAgentName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);

        return InvokeDeleteIotAgentRestServer(
            iotAgentName,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> EnableIotAgent(
        string iotAgentName,
        long projectId,
        CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(iotAgentName);

        return InvokeEnableIotAgent(
            iotAgentName,
            projectId,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> DisableIotAgent(
        string iotAgentName,
        long projectId,
        CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(iotAgentName);

        return InvokeDisableIotAgent(
            iotAgentName,
            projectId,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateIotAgentRestClientIotItem(
        string iotAgentName,
        IotItemCreateRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);
        ArgumentNullException.ThrowIfNull(request);

        return InvokeCreateIotAgentRestClientIotItems(
            iotAgentName,
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<IList<IotItem>?>> GetIotAgentIotItems(
        string iotAgentName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);

        return InvokeGetIotAgentIotItems(iotAgentName, cancellationToken);
    }

    public Task<HttpClientRequestResult<IotItem?>> GetIotAgentIotItem(
        string iotAgentName,
        string iotItemName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);
        ArgumentNullException.ThrowIfNull(iotItemName);

        return InvokeGetIotAgentIotItem(
            iotAgentName,
            EnsureProperIotItemNameFormat(iotItemName),
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> EnableIotAgentIotItem(
        string iotAgentName,
        long projectId,
        string iotItemName,
        CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(iotAgentName);
        ArgumentException.ThrowIfNullOrEmpty(iotItemName);

        return InvokeEnableIotAgentIotItem(
            iotAgentName,
            projectId,
            EnsureProperIotItemNameFormat(iotItemName),
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> DisableIotAgentIotItem(
        string iotAgentName,
        long projectId,
        string iotItemName,
        CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(iotAgentName);
        ArgumentException.ThrowIfNullOrEmpty(iotItemName);

        return InvokeDisableIotAgentIotItem(
            iotAgentName,
            projectId,
            EnsureProperIotItemNameFormat(iotItemName),
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> UpdateIotAgentRestClientIotItem(
        string iotAgentName,
        string iotItemName,
        IotItemUpdateRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);
        ArgumentNullException.ThrowIfNull(iotItemName);
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeUpdateIotAgentRestClientIotItem(
            iotAgentName,
            EnsureProperIotItemNameFormat(iotItemName),
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> DeleteIotAgentIotItem(
        string iotAgentName,
        string iotItemName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);
        ArgumentNullException.ThrowIfNull(iotItemName);

        return InvokeDeleteIotAgentIotItem(
            iotAgentName,
            EnsureProperIotItemNameFormat(iotItemName),
            cancellationToken);
    }

    private async Task<HttpClientRequestResult<bool>> InvokeIsIotAgentDefined(
        string iotAgentName,
        CancellationToken cancellationToken)
    {
        // It does not matter which path we set here (rest_clients//rest_servers//mqtt_clients) - the call still succeeds
        var response = await Get<KepwareContracts.IotGateway.IotAgentBase>(
            $"{EndpointPathTemplateConstants.IotGatewayRestClients}/{iotAgentName}",
            cancellationToken,
            shouldLogNotFound: false);

        if (!response.CommunicationSucceeded)
        {
            return new HttpClientRequestResult<bool>(new HttpRequestException("Communication error!"));
        }

        if (response.StatusCode is HttpStatusCode.OK or HttpStatusCode.NotFound)
        {
            return new HttpClientRequestResult<bool>(response.StatusCode, response.HasData);
        }

        return response.HasMessage
            ? new HttpClientRequestResult<bool>(response.StatusCode, response.HasData, response.Message!)
            : new HttpClientRequestResult<bool>(response.StatusCode, response.HasData);
    }

    private async Task<HttpClientRequestResult<IotAgentBase?>> InvokeGetIotAgentBase(
        string iotAgentName,
        CancellationToken cancellationToken)
    {
        // It does not matter which path we set here (rest_clients//rest_servers//mqtt_clients) - the call still succeeds
        var response = await Get<KepwareContracts.IotGateway.IotAgentBase>(
            $"{EndpointPathTemplateConstants.IotGatewayRestClients}/{iotAgentName}",
            cancellationToken,
            shouldLogNotFound: false);

        if (!response.CommunicationSucceeded)
        {
            return new HttpClientRequestResult<IotAgentBase?>(new HttpRequestException("Communication error!"));
        }

        return response.HasData
            ? response.Adapt<HttpClientRequestResult<IotAgentBase?>>()
            : new HttpClientRequestResult<IotAgentBase?>(response.StatusCode, data: null);
    }

    private Task<HttpClientRequestResult<bool>> InvokeCreateIotAgentRestClient(
        IotAgentRestClientCreateRequest request,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.IotGateway.IotAgentRestClientCreateRequest>(),
            EndpointPathTemplateConstants.IotGatewayRestClients,
            cancellationToken);

    private async Task<HttpClientRequestResult<IotAgentRestClient?>> InvokeGetIotAgentRestClient(
        string iotAgentName,
        CancellationToken cancellationToken)
    {
        var response = await Get<KepwareContracts.IotGateway.IotAgentRestClient>(
            $"{EndpointPathTemplateConstants.IotGatewayRestClients}/{iotAgentName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.AgentType.Equals(IotAgentType.RestClient))
        {
            return new HttpClientRequestResult<IotAgentRestClient?>(HttpStatusCode.NotFound, data: null, $"Retrieved iot agent '{iotAgentName}' is not a '{IotAgentType.RestClient.GetDescription()}'.");
        }

        return response.Adapt<HttpClientRequestResult<IotAgentRestClient?>>();
    }

    private Task<HttpClientRequestResult<bool>> InvokeUpdateIotAgentRestClient(
        string iotAgentName,
        IotAgentRestClientUpdateRequest request,
        CancellationToken cancellationToken)
        => Put(
            request.Adapt<KepwareContracts.IotGateway.IotAgentRestClientUpdateRequest>(),
            $"{EndpointPathTemplateConstants.IotGatewayRestClients}/{iotAgentName}",
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeDeleteIotAgentMqttClient(
        string iotAgentName,
        CancellationToken cancellationToken)
        => Delete(
            $"{EndpointPathTemplateConstants.IotGatewayMqttClients}/{iotAgentName}",
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeDeleteIotAgentRestClient(
        string iotAgentName,
        CancellationToken cancellationToken)
        => Delete(
            $"{EndpointPathTemplateConstants.IotGatewayRestClients}/{iotAgentName}",
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeDeleteIotAgentRestServer(
        string iotAgentName,
        CancellationToken cancellationToken)
        => Delete(
            $"{EndpointPathTemplateConstants.IotGatewayRestServers}/{iotAgentName}",
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeEnableIotAgent(
        string iotAgentName,
        long projectId,
        CancellationToken cancellationToken)
        => Put(
            new KepwareContracts.IotGateway.IotAgentEnableDisableRequest
            {
                ProjectId = projectId,
                Enabled = true,
            },
            $"{EndpointPathTemplateConstants.IotGatewayRestClients}/{iotAgentName}",
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeDisableIotAgent(
        string iotAgentName,
        long projectId,
        CancellationToken cancellationToken)
        => Put(
            new KepwareContracts.IotGateway.IotAgentEnableDisableRequest
            {
                ProjectId = projectId,
                Enabled = false,
            },
            $"{EndpointPathTemplateConstants.IotGatewayRestClients}/{iotAgentName}",
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeCreateIotAgentRestClientIotItems(
        string iotAgentName,
        IotItemCreateRequest request,
        CancellationToken cancellationToken) =>
        Post(
            new List<KepwareContracts.IotGateway.IotItemCreateRequest>
            {
                request.Adapt<KepwareContracts.IotGateway.IotItemCreateRequest>(),
            },
            $"{EndpointPathTemplateConstants.IotGatewayRestClients}/{iotAgentName}/{EndpointPathTemplateConstants.IotItems}",
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeEnableIotAgentIotItem(
        string iotAgentName,
        long projectId,
        string iotItemName,
        CancellationToken cancellationToken)
        => Put(
            new KepwareContracts.IotGateway.IotItemEnableDisableRequest
            {
                ProjectId = projectId,
                Enabled = true,
            },
            $"{EndpointPathTemplateConstants.IotGatewayRestClients}/{iotAgentName}/{EndpointPathTemplateConstants.IotItems}/{iotItemName}", // It does not matter which path we set here (rest_clients//rest_servers//mqtt_clients) - the call still succeeds
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeDisableIotAgentIotItem(
        string iotAgentName,
        long projectId,
        string iotItemName,
        CancellationToken cancellationToken)
        => Put(
            new KepwareContracts.IotGateway.IotItemEnableDisableRequest
            {
                ProjectId = projectId,
                Enabled = false,
            },
            $"{EndpointPathTemplateConstants.IotGatewayRestClients}/{iotAgentName}/{EndpointPathTemplateConstants.IotItems}/{iotItemName}", // It does not matter which path we set here (rest_clients//rest_servers//mqtt_clients) - the call still succeeds
            cancellationToken);

    private async Task<HttpClientRequestResult<IList<IotItem>?>> InvokeGetIotAgentIotItems(
        string iotAgentName,
        CancellationToken cancellationToken)
    {
        // It does not matter which path we set here (rest_clients//rest_servers//mqtt_clients) - the call still succeeds
        var response = await Get<IList<KepwareContracts.IotGateway.IotItem>>(
            $"{EndpointPathTemplateConstants.IotGatewayRestClients}/{iotAgentName}/{EndpointPathTemplateConstants.IotItems}",
            cancellationToken);

        return response.Adapt<HttpClientRequestResult<IList<IotItem>?>>();
    }

    private async Task<HttpClientRequestResult<IotItem?>> InvokeGetIotAgentIotItem(
        string iotAgentName,
        string iotItemName,
        CancellationToken cancellationToken)
    {
        // It does not matter which path we set here (rest_clients//rest_servers//mqtt_clients) - the call still succeeds
        var response = await Get<KepwareContracts.IotGateway.IotItem>(
            $"{EndpointPathTemplateConstants.IotGatewayRestClients}/{iotAgentName}/{EndpointPathTemplateConstants.IotItems}/{iotItemName}",
            cancellationToken);

        return response.Adapt<HttpClientRequestResult<IotItem?>>();
    }

    private Task<HttpClientRequestResult<bool>> InvokeUpdateIotAgentRestClientIotItem(
        string iotAgentName,
        string iotItemName,
        IotItemUpdateRequest request,
        CancellationToken cancellationToken)
        => Put(
            request.Adapt<KepwareContracts.IotGateway.IotItemUpdateRequest>(),
            $"{EndpointPathTemplateConstants.IotGatewayRestClients}/{iotAgentName}/{EndpointPathTemplateConstants.IotItems}/{iotItemName}", // It does not matter which path we set here (rest_clients//rest_servers//mqtt_clients) - the call still succeeds
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeDeleteIotAgentIotItem(
        string iotAgentName,
        string iotItemName,
        CancellationToken cancellationToken)
        => Delete(
            $"{EndpointPathTemplateConstants.IotGatewayRestClients}/{iotAgentName}/{EndpointPathTemplateConstants.IotItems}/{iotItemName}", // It does not matter which path we set here (rest_clients//rest_servers//mqtt_clients) - the call still succeeds
            cancellationToken);

    private static bool IsValidIotGatewayName(
        string clientName,
        string? iotItemName,
        out string? errorMessage)
    {
        if (!KeyStringAttribute.TryIsValid(clientName, NameKeyStringAttribute, out var errorMessageClient))
        {
            errorMessage = errorMessageClient;
            return false;
        }

        if (iotItemName is not null &&
            !KeyStringAttribute.TryIsValid(iotItemName, NameKeyStringAttribute, out var errorMessageIotItem))
        {
            errorMessage = errorMessageIotItem;
            return false;
        }

        errorMessage = null;
        return true;
    }

    private static string EnsureProperIotItemNameFormat(string iotItemName)
        => iotItemName.TrimExtended().Replace('.', '_');

    public Task<HttpClientRequestResult<bool>> CreateIotAgentMqttClient(
        IotAgentMqttClientCreateRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateIotAgentMqttClient(
            request,
            cancellationToken);
    }

    public async Task<HttpClientRequestResult<IList<IotAgentMqttClient>?>> GetIotAgentMqttClients(
        CancellationToken cancellationToken)
    {
        var response = await Get<IList<KepwareContracts.IotGateway.IotAgentMqttClient>>(
            EndpointPathTemplateConstants.IotGatewayMqttClients,
            cancellationToken);

        return response.Adapt<HttpClientRequestResult<IList<IotAgentMqttClient>?>>();
    }

    public Task<HttpClientRequestResult<IotAgentMqttClient?>> GetIotAgentMqttClient(
        string iotAgentName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);

        return InvokeGetIotAgentMqttClient(iotAgentName, cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> UpdateIotAgentMqttClient(
        string iotAgentName,
        IotAgentMqttClientUpdateRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeUpdateIotAgentMqttClient(
            iotAgentName,
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateIotAgentRestServer(
        IotAgentRestServerCreateRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateIotAgentRestServer(
            request,
            cancellationToken);
    }

    public async Task<HttpClientRequestResult<IList<IotAgentRestServer>?>> GetIotAgentRestServers(
        CancellationToken cancellationToken)
    {
        var response = await Get<IList<KepwareContracts.IotGateway.IotAgentRestServer>>(
            EndpointPathTemplateConstants.IotGatewayRestServers,
            cancellationToken);

        return response.Adapt<HttpClientRequestResult<IList<IotAgentRestServer>?>>();
    }

    public Task<HttpClientRequestResult<IotAgentRestServer?>> GetIotAgentRestServer(
        string iotAgentName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);

        return InvokeGetIotAgentRestServer(iotAgentName, cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> UpdateIotAgentRestServer(
        string iotAgentName,
        IotAgentRestServerUpdateRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeUpdateIotAgentRestServer(
            iotAgentName,
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateIotAgentMqttClientIotItem(
        string iotAgentName,
        IotItemCreateRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);
        ArgumentNullException.ThrowIfNull(request);

        return InvokeCreateIotAgentMqttClientIotItem(
            iotAgentName,
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> UpdateIotAgentMqttClientIotItem(
        string iotAgentName,
        string iotItemName,
        IotItemUpdateRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);
        ArgumentNullException.ThrowIfNull(iotItemName);
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeUpdateIotAgentMqttClientIotItem(
            iotAgentName,
            EnsureProperIotItemNameFormat(iotItemName),
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateIotAgentRestServerIotItem(
        string iotAgentName,
        IotItemCreateRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);
        ArgumentNullException.ThrowIfNull(request);

        return InvokeCreateIotAgentRestServerIotItem(
            iotAgentName,
            request,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> UpdateIotAgentRestServerIotItem(
        string iotAgentName,
        string iotItemName,
        IotItemUpdateRequest request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(iotAgentName);
        ArgumentNullException.ThrowIfNull(iotItemName);
        ArgumentNullException.ThrowIfNull(request);

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeUpdateIotAgentRestServerIotItem(
            iotAgentName,
            EnsureProperIotItemNameFormat(iotItemName),
            request,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeCreateIotAgentMqttClient(
        IotAgentMqttClientCreateRequest request,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.IotGateway.IotAgentMqttClientCreateRequest>(),
            EndpointPathTemplateConstants.IotGatewayMqttClients,
            cancellationToken);

    private async Task<HttpClientRequestResult<IotAgentMqttClient?>> InvokeGetIotAgentMqttClient(
        string iotAgentName,
        CancellationToken cancellationToken)
    {
        var response = await Get<KepwareContracts.IotGateway.IotAgentMqttClient>(
            $"{EndpointPathTemplateConstants.IotGatewayMqttClients}/{iotAgentName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.AgentType.Equals(IotAgentType.MqttClient))
        {
            return new HttpClientRequestResult<IotAgentMqttClient?>(HttpStatusCode.NotFound, data: null, $"Retrieved iot agent '{iotAgentName}' is not a '{IotAgentType.MqttClient.GetDescription()}'.");
        }

        return response.Adapt<HttpClientRequestResult<IotAgentMqttClient?>>();
    }

    private Task<HttpClientRequestResult<bool>> InvokeUpdateIotAgentMqttClient(
        string iotAgentName,
        IotAgentMqttClientUpdateRequest request,
        CancellationToken cancellationToken)
        => Put(
            request.Adapt<KepwareContracts.IotGateway.IotAgentMqttClientUpdateRequest>(),
            $"{EndpointPathTemplateConstants.IotGatewayMqttClients}/{iotAgentName}",
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeCreateIotAgentRestServer(
        IotAgentRestServerCreateRequest request,
        CancellationToken cancellationToken)
        => Post(
            request.Adapt<KepwareContracts.IotGateway.IotAgentRestServerCreateRequest>(),
            EndpointPathTemplateConstants.IotGatewayRestServers,
            cancellationToken);

    private async Task<HttpClientRequestResult<IotAgentRestServer?>> InvokeGetIotAgentRestServer(
        string iotAgentName,
        CancellationToken cancellationToken)
    {
        var response = await Get<KepwareContracts.IotGateway.IotAgentRestServer>(
            $"{EndpointPathTemplateConstants.IotGatewayRestServers}/{iotAgentName}",
            cancellationToken);

        if (response is { CommunicationSucceeded: true, HasData: true } &&
            !response.Data!.AgentType.Equals(IotAgentType.RestServer))
        {
            return new HttpClientRequestResult<IotAgentRestServer?>(HttpStatusCode.NotFound, data: null, $"Retrieved iot agent '{iotAgentName}' is not a '{IotAgentType.RestServer.GetDescription()}'.");
        }

        return response.Adapt<HttpClientRequestResult<IotAgentRestServer?>>();
    }

    private Task<HttpClientRequestResult<bool>> InvokeUpdateIotAgentRestServer(
        string iotAgentName,
        IotAgentRestServerUpdateRequest request,
        CancellationToken cancellationToken)
        => Put(
            request.Adapt<KepwareContracts.IotGateway.IotAgentRestServerUpdateRequest>(),
            $"{EndpointPathTemplateConstants.IotGatewayRestServers}/{iotAgentName}",
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeCreateIotAgentMqttClientIotItem(
        string iotAgentName,
        IotItemCreateRequest request,
        CancellationToken cancellationToken)
        => Post(
            new List<KepwareContracts.IotGateway.IotItemCreateRequest>
            {
                request.Adapt<KepwareContracts.IotGateway.IotItemCreateRequest>(),
            },
            $"{EndpointPathTemplateConstants.IotGatewayMqttClients}/{iotAgentName}/{EndpointPathTemplateConstants.IotItems}",
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeUpdateIotAgentMqttClientIotItem(
        string iotAgentName,
        string iotItemName,
        IotItemUpdateRequest request,
        CancellationToken cancellationToken)
        => Put(
            request.Adapt<KepwareContracts.IotGateway.IotItemUpdateRequest>(),
            $"{EndpointPathTemplateConstants.IotGatewayMqttClients}/{iotAgentName}/{EndpointPathTemplateConstants.IotItems}/{iotItemName}",
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeCreateIotAgentRestServerIotItem(
        string iotAgentName,
        IotItemCreateRequest request,
        CancellationToken cancellationToken)
        => Post(
            new List<KepwareContracts.IotGateway.IotItemCreateRequest>
            {
                request.Adapt<KepwareContracts.IotGateway.IotItemCreateRequest>(),
            },
            $"{EndpointPathTemplateConstants.IotGatewayRestServers}/{iotAgentName}/{EndpointPathTemplateConstants.IotItems}",
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeUpdateIotAgentRestServerIotItem(
        string iotAgentName,
        string iotItemName,
        IotItemUpdateRequest request,
        CancellationToken cancellationToken)
        => Put(
            request.Adapt<KepwareContracts.IotGateway.IotItemUpdateRequest>(),
            $"{EndpointPathTemplateConstants.IotGatewayRestServers}/{iotAgentName}/{EndpointPathTemplateConstants.IotItems}/{iotItemName}",
            cancellationToken);
}