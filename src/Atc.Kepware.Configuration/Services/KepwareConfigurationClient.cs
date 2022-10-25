// ReSharper disable ParameterTypeCanBeEnumerable.Local
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// The main KepwareConfigurationClient - Handles call execution.
/// </summary>
[SuppressMessage("Usage", "CA2234:Pass system uri objects instead of strings", Justification = "OK")]
[SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "OK")]
[SuppressMessage("Security", "MA0039:Do not write your own certificate validation method", Justification = "OK")]
[SuppressMessage("Critical Vulnerability", "S4830:Server certificates should be verified during SSL/TLS connections", Justification = "OK")]
public sealed partial class KepwareConfigurationClient : IKepwareConfigurationClient, IDisposable
{
    private readonly JsonSerializerOptions jsonSerializerOptions;
    private HttpClientHandler? httpClientHandler;
    private HttpClient? httpClient;

    /// <summary>
    /// Initializes a new instance of the <see cref="KepwareConfigurationClient"/> class and setting only the ILogger.
    /// Make sure to invoke SetConnectionInformation when using this constructor.
    /// </summary>
    /// <param name="logger">The ILogger</param>
    /// <exception cref="ArgumentNullException">Throws ArgumentNullException if ILogger is null.</exception>
    public KepwareConfigurationClient(
        ILogger logger)
    {
        this.logger = logger ?? throw new ArgumentNullException(nameof(logger));

        jsonSerializerOptions = InitializeJsonSerializerOptions();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="KepwareConfigurationClient"/> class with all required properties.
    /// </summary>
    /// <param name="logger">The ILogger</param>
    /// <param name="baseUri">BaseUri of the Kepware server.</param>
    /// <param name="userName">Optional username to the Kepware server.</param>
    /// <param name="password">Optional password to the Kepware server.</param>
    /// <param name="disableCertificateValidationCheck">Indicates if remote certificate validation check should be enabled or not.</param>
    /// <exception cref="ArgumentNullException">Throws ArgumentNullException if ILogger is null.</exception>
    public KepwareConfigurationClient(
        ILogger logger,
        Uri baseUri,
        string? userName,
        string? password,
        bool disableCertificateValidationCheck = true)
        : this(logger)
    {
        SetConnectionInformation(baseUri, userName, password, disableCertificateValidationCheck);
    }

    public bool IsConnectionInformationConfigured()
        => httpClient is not null;

    public void SetConnectionInformation(
        Uri baseUri,
        string? userName,
        string? password,
        bool disableCertificateValidationCheck = true)
    {
        httpClientHandler = new HttpClientHandler();

        if (disableCertificateValidationCheck)
        {
            httpClientHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
        }

        httpClient = new HttpClient(httpClientHandler)
        {
            BaseAddress = baseUri,
        };

        if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
        {
            httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue(
                    "Basic",
                    $"{userName}:{password}".Base64Encode());
        }
    }

    private static JsonSerializerOptions InitializeJsonSerializerOptions()
        => JsonSerializerOptionsFactory.Create(new JsonSerializerFactorySettings
        {
            UseConverterEnumAsString = false,
        });

    [SuppressMessage("Design", "MA0051:Method is too long", Justification = "OK.")]
    private async Task<HttpClientRequestResult<TResponse?>> Get<TResponse>(
        string pathTemplate,
        CancellationToken cancellationToken,
        bool shouldLogNotFound = true)
    {
        if (!IsConnectionInformationConfigured())
        {
            LogConnectionInformationNotSet();
            return new HttpClientRequestResult<TResponse?>(
                new HttpRequestException("Connection information is not set on the client."));
        }

        try
        {
            var response = await httpClient!.GetAsync(pathTemplate, cancellationToken);

            if (response.IsSuccessStatusCode)
            {
                var responseJson = await response.Content.ReadAsStringAsync(cancellationToken);
                LogGetSucceeded(pathTemplate);
                var result = JsonSerializer.Deserialize<TResponse>(responseJson, jsonSerializerOptions);
                return new HttpClientRequestResult<TResponse?>(response.StatusCode, result);
            }

            var errorResponseString = await response.Content.ReadAsStringAsync(cancellationToken);
            if (response.Content.Headers.ContentType?.MediaType == MediaTypeNames.Application.Json)
            {
                var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(errorResponseString, jsonSerializerOptions);
                if (errorResponse is not null)
                {
                    var codeMessage = errorResponse.GetCodeAndMessage();
                    if (response.StatusCode == HttpStatusCode.NotFound)
                    {
                        if (shouldLogNotFound)
                        {
                            LogGetNotFound(pathTemplate);
                        }
                    }
                    else
                    {
                        LogGetFailure(pathTemplate, codeMessage);
                    }

                    return new HttpClientRequestResult<TResponse?>(response.StatusCode, default, codeMessage);
                }
            }

            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                if (shouldLogNotFound)
                {
                    LogGetNotFound(pathTemplate);
                }

                return new HttpClientRequestResult<TResponse?>(response.StatusCode, default);
            }

            LogGetFailure(pathTemplate, errorResponseString);
            return new HttpClientRequestResult<TResponse?>(response.StatusCode, default, errorResponseString);
        }
        catch (Exception ex)
        {
            LogGetFailure(pathTemplate, ex.Message);
            return new HttpClientRequestResult<TResponse?>(ex);
        }
    }

    private async Task<HttpClientRequestResult<bool>> Post<TRequest>(
        TRequest request,
        string pathTemplate,
        CancellationToken cancellationToken)
    {
        try
        {
            if (!IsConnectionInformationConfigured())
            {
                LogConnectionInformationNotSet();
                return new HttpClientRequestResult<bool>(
                    new HttpRequestException("Connection information is not set on the client."));
            }

            var requestContent = new StringContent(
                JsonSerializer.Serialize(request, jsonSerializerOptions),
                Encoding.UTF8,
                MediaTypeNames.Application.Json);

            var response = await httpClient!.PostAsync(pathTemplate, requestContent, cancellationToken);
            requestContent.Dispose();

            if (response.IsSuccessStatusCode)
            {
                LogPostSucceeded(pathTemplate);
                return new HttpClientRequestResult<bool>(response.StatusCode, data: true);
            }

            var errorResponseString = await response.Content.ReadAsStringAsync(cancellationToken);
            if (response.Content.Headers.ContentType?.MediaType == MediaTypeNames.Application.Json)
            {
                var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(errorResponseString, jsonSerializerOptions);
                if (errorResponse is not null)
                {
                    var codeMessage = errorResponse.GetCodeAndMessage();
                    LogPostFailure(pathTemplate, codeMessage);
                    return new HttpClientRequestResult<bool>(response.StatusCode, data: false, codeMessage);
                }
            }

            LogPostFailure(pathTemplate, errorResponseString);
            return new HttpClientRequestResult<bool>(response.StatusCode, data: false, errorResponseString);
        }
        catch (Exception ex)
        {
            LogPostFailure(pathTemplate, ex.Message);
            return new HttpClientRequestResult<bool>(ex);
        }
    }

    private async Task<HttpClientRequestResult<bool>> Put<TRequest>(
        TRequest request,
        string pathTemplate,
        CancellationToken cancellationToken)
    {
        try
        {
            if (!IsConnectionInformationConfigured())
            {
                LogConnectionInformationNotSet();
                return new HttpClientRequestResult<bool>(
                    new HttpRequestException("Connection information is not set on the client."));
            }

            var requestContent = new StringContent(
                JsonSerializer.Serialize(request, jsonSerializerOptions),
                Encoding.UTF8,
                MediaTypeNames.Application.Json);

            var response = await httpClient!.PutAsync(pathTemplate, requestContent, cancellationToken);
            requestContent.Dispose();

            if (response.IsSuccessStatusCode)
            {
                LogPutSucceeded(pathTemplate);
                return new HttpClientRequestResult<bool>(response.StatusCode, data: true);
            }

            var errorResponseString = await response.Content.ReadAsStringAsync(cancellationToken);
            if (response.Content.Headers.ContentType?.MediaType == MediaTypeNames.Application.Json)
            {
                var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(errorResponseString, jsonSerializerOptions);
                if (errorResponse is not null)
                {
                    var codeMessage = errorResponse.GetCodeAndMessage();
                    LogPutFailure(pathTemplate, codeMessage);
                    return new HttpClientRequestResult<bool>(response.StatusCode, data: false, codeMessage);
                }
            }

            LogPutFailure(pathTemplate, errorResponseString);
            return new HttpClientRequestResult<bool>(response.StatusCode, data: false, errorResponseString);
        }
        catch (Exception ex)
        {
            LogPutFailure(pathTemplate, ex.Message);
            return new HttpClientRequestResult<bool>(ex);
        }
    }

    private async Task<HttpClientRequestResult<bool>> Delete(
        string pathTemplate,
        CancellationToken cancellationToken)
    {
        try
        {
            if (!IsConnectionInformationConfigured())
            {
                LogConnectionInformationNotSet();
                return new HttpClientRequestResult<bool>(
                    new HttpRequestException("Connection information is not set on the client."));
            }

            var response = await httpClient!.DeleteAsync(pathTemplate, cancellationToken);
            if (response.IsSuccessStatusCode)
            {
                LogDeleteSucceeded(pathTemplate);
                return new HttpClientRequestResult<bool>(response.StatusCode, data: true);
            }

            var errorResponseString = await response.Content.ReadAsStringAsync(cancellationToken);
            if (response.Content.Headers.ContentType?.MediaType == MediaTypeNames.Application.Json)
            {
                var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(errorResponseString, jsonSerializerOptions);
                if (errorResponse is not null)
                {
                    var codeMessage = errorResponse.GetCodeAndMessage();
                    LogDeleteFailure(pathTemplate, codeMessage);
                    return new HttpClientRequestResult<bool>(response.StatusCode, data: false, codeMessage);
                }
            }

            LogPostFailure(pathTemplate, errorResponseString);
            return new HttpClientRequestResult<bool>(response.StatusCode, data: false, errorResponseString);
        }
        catch (Exception ex)
        {
            LogDeleteFailure(pathTemplate, ex.Message);
            return new HttpClientRequestResult<bool>(ex);
        }
    }

    public void Dispose()
    {
        httpClientHandler?.Dispose();
        httpClient?.Dispose();
    }
}