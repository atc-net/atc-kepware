using Atc.Kepware.Configuration.Contracts;

namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// The main KepwareConfigurationClient - Handles call execution.
/// </summary>
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

    [SuppressMessage("Usage", "CA2234:Pass system uri objects instead of strings", Justification = "OK")]
    [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "OK")]
    private async Task<(bool Succeeded, string? ErrorMessage)> Post<TRequest>(
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
                return (true, string.Empty);
            }

            var responseJson = await response.Content.ReadAsStringAsync(cancellationToken);
            var errorResponse = JsonSerializer.Deserialize<KepwareErrorResponse>(responseJson, jsonSerializerOptions);
            if (errorResponse is not null)
            {
                var codeMessage = errorResponse.GetCodeAndMessage();
                LogPostFailure(pathTemplate, codeMessage);
                return (false, codeMessage);
            }

            LogPostFailure(pathTemplate, responseJson);
            return (false, responseJson);
        }
        catch (Exception ex)
        {
            LogPostFailure(pathTemplate, ex.Message);
            return (false, ex.Message);
        }
    }

    public void Dispose()
    {
        httpClientHandler.Dispose();
        httpClient.Dispose();
    }
}