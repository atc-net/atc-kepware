namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles Iot Gateway calls for Agents and Iot Items.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
public partial interface IKepwareConfigurationClient
{
    Task<HttpClientRequestResult<bool>> IsIotAgentDefined(
        string iotAgentName,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<IotAgentBase?>> GetIotAgentBase(
        string iotAgentName,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<bool>> CreateIotAgentRestClient(
        IotAgentRestClientCreateRequest request,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<IList<IotAgentRestClient>?>> GetIotAgentRestClients(
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<IotAgentRestClient?>> GetIotAgentRestClient(
        string iotAgentName,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<bool>> UpdateIotAgentRestClient(
        string iotAgentName,
        IotAgentRestClientUpdateRequest request,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<bool>> DeleteIotAgentRestClient(
        string iotAgentName,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<bool>> EnableIotAgent(
        string iotAgentName,
        long projectId,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<bool>> DisableIotAgent(
        string iotAgentName,
        long projectId,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<bool>> CreateIotAgentRestClientIotItem(
        string iotAgentName,
        IotItemCreateRequest request,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<IList<IotItem>?>> GetIotAgentIotItems(
        string iotAgentName,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<IotItem?>> GetIotAgentIotItem(
        string iotAgentName,
        string iotItemName,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<bool>> EnableIotAgentIotItem(
        string iotAgentName,
        long projectId,
        string iotItemName,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<bool>> DisableIotAgentIotItem(
        string iotAgentName,
        long projectId,
        string iotItemName,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<bool>> UpdateIotAgentRestClientIotItem(
        string iotAgentName,
        string iotItemName,
        IotItemUpdateRequest request,
        CancellationToken cancellationToken);

    Task<HttpClientRequestResult<bool>> DeleteIotAgentIotItem(
        string iotAgentName,
        string iotItemName,
        CancellationToken cancellationToken);
}