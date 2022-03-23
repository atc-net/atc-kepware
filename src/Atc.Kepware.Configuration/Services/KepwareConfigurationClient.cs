namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// The main KepwareConfigurationClient - Handles call execution.
/// </summary>
[SuppressMessage("Usage", "CA2234:Pass system uri objects instead of strings", Justification = "OK")]
[SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "OK")]
public sealed partial class KepwareConfigurationClient : IKepwareConfigurationClient, IDisposable
{
    private readonly JsonSerializerOptions jsonSerializerOptions;
    private readonly HttpClientHandler httpClientHandler;
    private readonly HttpClient httpClient;

    [SuppressMessage("Security", "MA0039:Do not write your own certificate validation method", Justification = "OK")]
    [SuppressMessage("Critical Vulnerability", "S4830:Server certificates should be verified during SSL/TLS connections", Justification = "OK")]
    public KepwareConfigurationClient(
        ILogger<KepwareConfigurationClient> logger,
        Uri baseUri,
        string? userName,
        string? password,
        bool disableCertificateValidationCheck = true)
    {
        this.logger = logger ?? throw new ArgumentNullException(nameof(logger));

        jsonSerializerOptions = JsonSerializerOptionsFactory.Create(new JsonSerializerFactorySettings
        {
            UseConverterEnumAsString = false,
        });

        httpClientHandler = new HttpClientHandler();

        if (disableCertificateValidationCheck)
        {
            httpClientHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
        }

        httpClient = new HttpClient(httpClientHandler);
        httpClient.BaseAddress = baseUri;

        if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
        {
            httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue(
                    "Basic",
                    $"{userName}:{password}".Base64Encode());
        }
    }

    public async Task<bool> IsChannelDefined(
        string channelName,
        CancellationToken cancellationToken = default)
    {
        var response = await Get<ChannelBase>(
            $"{EndpointPathTemplateConstants.ProjectChannels}/{channelName}",
            cancellationToken);

        return response.Result is not null;
    }

    public async Task<bool> IsDeviceDefined(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken = default)
    {
        var response = await Get<DeviceBase>(
            $"{EndpointPathTemplateConstants.ProjectChannels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}",
            cancellationToken);

        return response.Result is not null;
    }

    public Task<KepwareResultResponse<IList<ChannelBase>?>> GetChannels(
        CancellationToken cancellationToken = default)
        => Get<IList<ChannelBase>>(
            EndpointPathTemplateConstants.ProjectChannels,
            cancellationToken);

    public Task<KepwareResultResponse<IList<DeviceBase>?>> GetDevices(
        string channelName,
        CancellationToken cancellationToken = default)
        => Get<IList<DeviceBase>>(
            $"{EndpointPathTemplateConstants.ProjectChannels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);

    private async Task<KepwareResultResponse<TResponse?>> Get<TResponse>(
        string pathTemplate,
        CancellationToken cancellationToken)
    {
        try
        {
            var response = await httpClient.GetAsync(pathTemplate, cancellationToken);

            if (response.IsSuccessStatusCode)
            {
                var responseJson = await response.Content.ReadAsStringAsync(cancellationToken);
                LogGetSucceeded(pathTemplate);
                var result = JsonSerializer.Deserialize<TResponse>(responseJson, jsonSerializerOptions);
                return new KepwareResultResponse<TResponse?>(true, response.StatusCode, result, string.Empty);
            }

            var errorResponseJson = await response.Content.ReadAsStringAsync(cancellationToken);
            var errorResponse = JsonSerializer.Deserialize<KepwareErrorResponse>(errorResponseJson, jsonSerializerOptions);
            if (errorResponse is not null)
            {
                var codeMessage = errorResponse.GetCodeAndMessage();
                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    LogGetNotFound(pathTemplate);
                }
                else
                {
                    LogGetFailure(pathTemplate, codeMessage);
                }

                return new KepwareResultResponse<TResponse?>(false, response.StatusCode, default, codeMessage);
            }

            LogGetFailure(pathTemplate, errorResponseJson);
            return new KepwareResultResponse<TResponse?>(false, response.StatusCode, default, errorResponseJson);
        }
        catch (Exception ex)
        {
            LogGetFailure(pathTemplate, ex.Message);
            return new KepwareResultResponse<TResponse?>(false, null, default, ex.Message);
        }
    }

    private async Task<KepwareResultResponse<bool>> Post<TRequest>(
        TRequest request,
        string pathTemplate,
        CancellationToken cancellationToken)
    {
        try
        {
            var requestContent = new StringContent(
                JsonSerializer.Serialize(request, jsonSerializerOptions),
                Encoding.UTF8,
                System.Net.Mime.MediaTypeNames.Application.Json);

            var response = await httpClient.PostAsync(pathTemplate, requestContent, cancellationToken);
            requestContent.Dispose();

            if (response.IsSuccessStatusCode)
            {
                LogPostSucceeded(pathTemplate);
                return new KepwareResultResponse<bool>(true, response.StatusCode, true, string.Empty);
            }

            var responseJson = await response.Content.ReadAsStringAsync(cancellationToken);
            var errorResponse = JsonSerializer.Deserialize<KepwareErrorResponse>(responseJson, jsonSerializerOptions);
            if (errorResponse is not null)
            {
                var codeMessage = errorResponse.GetCodeAndMessage();
                LogPostFailure(pathTemplate, codeMessage);
                return new KepwareResultResponse<bool>(false, response.StatusCode, false, codeMessage);
            }

            LogPostFailure(pathTemplate, responseJson);
            return new KepwareResultResponse<bool>(false, response.StatusCode, false, responseJson);
        }
        catch (Exception ex)
        {
            LogPostFailure(pathTemplate, ex.Message);
            return new KepwareResultResponse<bool>(false, null, false, ex.Message);
        }
    }

    public void Dispose()
    {
        httpClientHandler.Dispose();
        httpClient.Dispose();
    }
}