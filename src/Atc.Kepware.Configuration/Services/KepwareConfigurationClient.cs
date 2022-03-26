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
        ILogger logger,
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
        CancellationToken cancellationToken)
    {
        var response = await Get<KepwareContracts.ChannelBase>(
            $"{EndpointPathTemplateConstants.ProjectChannels}/{channelName}",
            cancellationToken,
            shouldLogNotFound: false);

        return response.HasData;
    }

    public async Task<bool> IsDeviceDefined(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken)
    {
        var response = await Get<KepwareContracts.DeviceBase>(
            GetBasePathTemplate(channelName, deviceName),
            cancellationToken,
            shouldLogNotFound: false);

        return response.HasData;
    }

    public async Task<bool> IsTagDefined(
        string channelName,
        string deviceName,
        string tagName,
        string[] tagGroupStructure,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(tagGroupStructure);

        var basePathTemplate = GetBasePathTemplate(channelName, deviceName);
        var tagPathTemplate = $"{GetTagsPathFromTagGroupStructure(basePathTemplate, tagGroupStructure)}/{tagName}";

        var response = await Get<KepwareContracts.Tag>(
            tagPathTemplate,
            cancellationToken,
            shouldLogNotFound: false);

        return response.HasData;
    }

    public async Task<bool> IsTagGroupDefined(
        string channelName,
        string deviceName,
        string tagGroupName,
        string[] tagGroupStructure,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(tagGroupStructure);

        var basePathTemplate = GetBasePathTemplate(channelName, deviceName);
        var tagGroupPathTemplate = $"{GetTagGroupPathFromTagGroupStructure(basePathTemplate, tagGroupStructure)}/{EndpointPathTemplateConstants.TagGroups}/{tagGroupName}";

        var response = await Get<KepwareContracts.TagGroup>(
            tagGroupPathTemplate,
            cancellationToken,
            shouldLogNotFound: false);

        return response.HasData;
    }

    public async Task<HttpClientRequestResult<IList<ChannelBase>?>> GetChannels(
        CancellationToken cancellationToken)
    {
        var response = await Get<IList<KepwareContracts.ChannelBase>>(
            EndpointPathTemplateConstants.ProjectChannels,
            cancellationToken);

        return response.Adapt<HttpClientRequestResult<IList<ChannelBase>?>>();
    }

    public async Task<HttpClientRequestResult<IList<DeviceBase>?>> GetDevices(
        string channelName,
        CancellationToken cancellationToken)
    {
        var response = await Get<IList<KepwareContracts.DeviceBase>>(
            $"{EndpointPathTemplateConstants.ProjectChannels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);

        return response.Adapt<HttpClientRequestResult<IList<DeviceBase>?>>();
    }

    public async Task<HttpClientRequestResult<TagRoot>> GetTags(
        string channelName,
        string deviceName,
        int maxDepth,
        CancellationToken cancellationToken)
    {
        var result = new TagRoot(deviceName);
        var basePathTemplate = GetBasePathTemplate(channelName, deviceName);
        const int currentDepth = 1;

        var tagResult = await GetTagsResultForPathTemplate(basePathTemplate, cancellationToken);
        if (tagResult.CommunicationSucceeded)
        {
            if (tagResult.HasData &&
                tagResult.Data!.Any())
            {
                foreach (var tag in tagResult.Data!.Adapt<List<Tag>>())
                {
                    result.Tags.Add(tag);
                }
            }

            var tagGroupResult = await GetTagGroupResultForPathTemplate(basePathTemplate, cancellationToken);

            if (tagGroupResult.CommunicationSucceeded &&
                tagGroupResult.HasData &&
                tagGroupResult.Data!.Any())
            {
                foreach (var kepwareTagGroup in tagGroupResult.Data!)
                {
                    var tagGroup = kepwareTagGroup.Adapt<TagGroup>();

                    if (maxDepth >= currentDepth && kepwareTagGroup.TagCountInTree > 0)
                    {
                        await IterateTagGroup(
                            tagGroup,
                            $"{basePathTemplate}/{EndpointPathTemplateConstants.TagGroups}",
                            currentDepth + 1,
                            maxDepth,
                            cancellationToken);
                    }

                    result.TagGroups.Add(tagGroup);
                }
            }
        }
        else if (tagResult.StatusCode != HttpStatusCode.OK)
        {
            return new HttpClientRequestResult<TagRoot>(tagResult.StatusCode);
        }

        return new HttpClientRequestResult<TagRoot>(result);
    }

    public Task<HttpClientRequestResult<bool>> CreateTag(
        TagRequest request,
        string channelName,
        string deviceName,
        string[] tagGroupStructure,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        return InvokeCreateTag(
            request,
            channelName,
            deviceName,
            tagGroupStructure,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateTagGroup(
        TagGroupRequest request,
        string channelName,
        string deviceName,
        string[] tagGroupStructure,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        return InvokeCreateTagGroup(
            request,
            channelName,
            deviceName,
            tagGroupStructure,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> DeleteChannel(
        string channelName,
        CancellationToken cancellationToken)
        => Delete(
            $"{EndpointPathTemplateConstants.ProjectChannels}/{channelName}",
            cancellationToken);

    public Task<HttpClientRequestResult<bool>> DeleteDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken)
        => Delete(
            GetBasePathTemplate(channelName, deviceName),
            cancellationToken);

    public Task<HttpClientRequestResult<bool>> DeleteTag(
        string channelName,
        string deviceName,
        string tagName,
        string[] tagGroupStructure,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(tagGroupStructure);
        return InvokeDeleteTag(
            channelName,
            deviceName,
            tagName,
            tagGroupStructure,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> DeleteTagGroup(
        string channelName,
        string deviceName,
        string tagGroupName,
        string[] tagGroupStructure,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(tagGroupStructure);
        return InvokeDeleteTagGroup(
            channelName,
            deviceName,
            tagGroupName,
            tagGroupStructure,
            cancellationToken);
    }

    private async Task IterateTagGroup(
        TagGroup tagGroup,
        string tagGroupPathTemplate,
        int currentDepth,
        int maxDepth,
        CancellationToken cancellationToken)
    {
        if (maxDepth < currentDepth)
        {
            return;
        }

        tagGroupPathTemplate = $"{tagGroupPathTemplate}/{tagGroup.Name}";

        // TODO: Optimize if tagGroup.TagCountInGroup > 0
        var tagResult = await GetTagsResultForPathTemplate(tagGroupPathTemplate, cancellationToken);
        if (!tagResult.CommunicationSucceeded)
        {
            return;
        }

        if (tagResult.HasData &&
            tagResult.Data!.Any())
        {
            foreach (var tag in tagResult.Data!.Adapt<List<Tag>>())
            {
                tagGroup.Tags.Add(tag);
            }
        }

        // TODO: Optimize if tagGroup.TagCountInTree > 0
        var tagGroupResult = await GetTagGroupResultForPathTemplate(tagGroupPathTemplate, cancellationToken);

        if (tagGroupResult.CommunicationSucceeded &&
            tagGroupResult.HasData &&
            tagGroupResult.Data!.Any())
        {
            foreach (var kepwareTagGroup in tagGroupResult.Data!)
            {
                var subTagGroup = kepwareTagGroup.Adapt<TagGroup>();

                if (kepwareTagGroup.TagCountInTree > 0)
                {
                    await IterateTagGroup(
                        subTagGroup,
                        $"{tagGroupPathTemplate}/{EndpointPathTemplateConstants.TagGroups}",
                        currentDepth + 1,
                        maxDepth,
                        cancellationToken);
                }

                tagGroup.TagGroups.Add(subTagGroup);
            }
        }
    }

    private static string GetBasePathTemplate(
        string channelName,
        string deviceName)
        => $"{EndpointPathTemplateConstants.ProjectChannels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}";

    private static string GetTagsPathFromTagGroupStructure(
        string basePathTemplate,
        string[] tagGroupStructure)
    {
        string tagPath;
        switch (tagGroupStructure.Length)
        {
            case 0:
                tagPath = $"{basePathTemplate}/{EndpointPathTemplateConstants.Tags}";
                break;
            case 1:
                tagPath =
                    $"{basePathTemplate}/{EndpointPathTemplateConstants.TagGroups}/{tagGroupStructure[0]}/{EndpointPathTemplateConstants.Tags}";
                break;
            default:
            {
                var intermediateGroupPath = string.Join($"/{EndpointPathTemplateConstants.TagGroups}/", tagGroupStructure);
                tagPath = $"{basePathTemplate}/{EndpointPathTemplateConstants.TagGroups}/{intermediateGroupPath}/{EndpointPathTemplateConstants.Tags}";
                break;
            }
        }

        return tagPath;
    }

    private static string GetTagGroupPathFromTagGroupStructure(
        string basePathTemplate,
        string[] tagGroupStructure)
    {
        string tagPath;
        switch (tagGroupStructure.Length)
        {
            case 0:
                tagPath = basePathTemplate;
                break;
            case 1:
                tagPath =
                    $"{basePathTemplate}/{EndpointPathTemplateConstants.TagGroups}/{tagGroupStructure[0]}";
                break;
            default:
            {
                var intermediateGroupPath = string.Join($"/{EndpointPathTemplateConstants.TagGroups}/", tagGroupStructure);
                tagPath = $"{basePathTemplate}/{EndpointPathTemplateConstants.TagGroups}/{intermediateGroupPath}";
                break;
            }
        }

        return tagPath;
    }

    private Task<HttpClientRequestResult<IList<KepwareContracts.Tag>?>> GetTagsResultForPathTemplate(
        string pathTemplate,
        CancellationToken cancellationToken)
        => Get<IList<KepwareContracts.Tag>>(
            $"{pathTemplate}/{EndpointPathTemplateConstants.Tags}",
            cancellationToken);

    private Task<HttpClientRequestResult<IList<KepwareContracts.TagGroup>?>> GetTagGroupResultForPathTemplate(
        string pathTemplate,
        CancellationToken cancellationToken)
        => Get<IList<KepwareContracts.TagGroup>>(
            $"{pathTemplate}/{EndpointPathTemplateConstants.TagGroups}",
            cancellationToken);

    private Task<HttpClientRequestResult<bool>> InvokeCreateTag(
        TagRequest request,
        string channelName,
        string deviceName,
        string[] tagGroupStructure,
        CancellationToken cancellationToken)
    {
        var basePathTemplate = GetBasePathTemplate(channelName, deviceName);
        var tagsPathTemplate = GetTagsPathFromTagGroupStructure(basePathTemplate, tagGroupStructure);

        return Post(
            request.Adapt<KepwareContracts.TagRequest>(),
            tagsPathTemplate,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeCreateTagGroup(
        TagGroupRequest request,
        string channelName,
        string deviceName,
        string[] tagGroupStructure,
        CancellationToken cancellationToken)
    {
        var basePathTemplate = GetBasePathTemplate(channelName, deviceName);
        var tagGroupPathTemplate = $"{GetTagGroupPathFromTagGroupStructure(basePathTemplate, tagGroupStructure)}/{EndpointPathTemplateConstants.TagGroups}";

        return Post(
            request.Adapt<KepwareContracts.TagGroupRequest>(),
            tagGroupPathTemplate,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeDeleteTag(
        string channelName,
        string deviceName,
        string tagName,
        string[] tagGroupStructure,
        CancellationToken cancellationToken)
    {
        var basePathTemplate = GetBasePathTemplate(channelName, deviceName);
        var tagPathTemplate = $"{GetTagsPathFromTagGroupStructure(basePathTemplate, tagGroupStructure)}/{tagName}";

        return Delete(
            tagPathTemplate,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<bool>> InvokeDeleteTagGroup(
        string channelName,
        string deviceName,
        string tagGroupName,
        string[] tagGroupStructure,
        CancellationToken cancellationToken)
    {
        var basePathTemplate = GetBasePathTemplate(channelName, deviceName);
        var tagGroupPathTemplate = $"{GetTagGroupPathFromTagGroupStructure(basePathTemplate, tagGroupStructure)}/{EndpointPathTemplateConstants.TagGroups}/{tagGroupName}";

        return Delete(
            tagGroupPathTemplate,
            cancellationToken);
    }

    private async Task<HttpClientRequestResult<TResponse?>> Get<TResponse>(
        string pathTemplate,
        CancellationToken cancellationToken,
        bool shouldLogNotFound = true)
    {
        try
        {
            var response = await httpClient.GetAsync(pathTemplate, cancellationToken);

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
            var requestContent = new StringContent(
                JsonSerializer.Serialize(request, jsonSerializerOptions),
                Encoding.UTF8,
                MediaTypeNames.Application.Json);

            var response = await httpClient.PostAsync(pathTemplate, requestContent, cancellationToken);
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

    private async Task<HttpClientRequestResult<bool>> Delete(
        string pathTemplate,
        CancellationToken cancellationToken)
    {
        try
        {
            var response = await httpClient.DeleteAsync(pathTemplate, cancellationToken);
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
        httpClientHandler.Dispose();
        httpClient.Dispose();
    }
}