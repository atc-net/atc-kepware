// ReSharper disable ParameterTypeCanBeEnumerable.Local
// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient - Handles connectivity calls.
/// </summary>
[SuppressMessage("Usage", "CA2234:Pass system uri objects instead of strings", Justification = "OK")]
[SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "OK")]
public sealed partial class KepwareConfigurationClient
{
    private static readonly KeyStringAttribute ChannelNameKeyStringAttribute = new()
    {
        Required = true,
        InvalidCharacters = ['.', '"'],
        InvalidPrefixStrings = [" ", "_"],
        RegularExpression = string.Empty,
    };

    public async Task<HttpClientRequestResult<bool>> IsChannelDefined(
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);

        if (!IsValidConnectivityName(
                channelName,
                deviceName: null,
                tagGroupNameOrTagName: null,
                tagGroupStructure: null,
                out var errorMessage))
        {
            return await Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(errorMessage!));
        }

        var response = await Get<KepwareContracts.Connectivity.ChannelBase>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}",
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

    public async Task<HttpClientRequestResult<bool>> IsDeviceDefined(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);

        if (!IsValidConnectivityName(
                channelName,
                deviceName,
                tagGroupNameOrTagName: null,
                tagGroupStructure: null,
                out var errorMessage))
        {
            return await Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(errorMessage!));
        }

        var response = await Get<KepwareContracts.Connectivity.DeviceBase>(
            GetBasePathTemplate(channelName, deviceName),
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

    public async Task<HttpClientRequestResult<bool>> IsTagDefined(
        string channelName,
        string deviceName,
        string tagName,
        string[] tagGroupStructure,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);
        ArgumentNullException.ThrowIfNull(tagName);
        ArgumentNullException.ThrowIfNull(tagGroupStructure);

        if (!IsValidConnectivityName(
                channelName,
                deviceName,
                tagName,
                tagGroupStructure,
                out var errorMessage))
        {
            return await Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(errorMessage!));
        }

        var basePathTemplate = GetBasePathTemplate(channelName, deviceName);
        var tagPathTemplate = $"{GetTagsPathFromTagGroupStructure(basePathTemplate, tagGroupStructure)}/{tagName}";

        var response = await Get<KepwareContracts.Connectivity.Tag>(
            tagPathTemplate,
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

    public async Task<HttpClientRequestResult<bool>> IsTagGroupDefined(
        string channelName,
        string deviceName,
        string tagGroupName,
        string[] tagGroupStructure,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);
        ArgumentNullException.ThrowIfNull(tagGroupName);
        ArgumentNullException.ThrowIfNull(tagGroupStructure);

        if (!IsValidConnectivityName(
                channelName,
                deviceName,
                tagGroupName,
                tagGroupStructure,
                out var errorMessage))
        {
            return await Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(errorMessage!));
        }

        var basePathTemplate = GetBasePathTemplate(channelName, deviceName);
        var tagGroupPathTemplate = $"{GetTagGroupPathFromTagGroupStructure(basePathTemplate, tagGroupStructure)}/{EndpointPathTemplateConstants.TagGroups}/{tagGroupName}";

        var response = await Get<KepwareContracts.Connectivity.TagGroup>(
            tagGroupPathTemplate,
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

    public async Task<HttpClientRequestResult<IList<ChannelBase>?>> GetChannels(
        CancellationToken cancellationToken)
    {
        var response = await Get<IList<KepwareContracts.Connectivity.ChannelBase>>(
            EndpointPathTemplateConstants.Channels,
            cancellationToken);

        return response.Adapt<HttpClientRequestResult<IList<ChannelBase>?>>();
    }

    public async Task<HttpClientRequestResult<IList<DeviceBase>?>> GetDevicesByChannelName(
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);

        if (!IsValidConnectivityName(
                channelName,
                deviceName: null,
                tagGroupNameOrTagName: null,
                tagGroupStructure: null,
                out var errorMessage))
        {
            return await Task.FromResult(HttpClientRequestResultFactory<IList<DeviceBase>?>.CreateBadRequest(errorMessage!));
        }

        var response = await Get<IList<KepwareContracts.Connectivity.DeviceBase>>(
            $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}",
            cancellationToken);

        return response.Adapt<HttpClientRequestResult<IList<DeviceBase>?>>();
    }

    public async Task<HttpClientRequestResult<TagRoot>> GetTags(
        string channelName,
        string deviceName,
        int maxDepth,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);

        if (!IsValidConnectivityName(
                channelName,
                deviceName,
                tagGroupNameOrTagName: null,
                tagGroupStructure: null,
                out var errorMessage))
        {
            return (await Task.FromResult(HttpClientRequestResultFactory<TagRoot>.CreateBadRequest(errorMessage!)))!;
        }

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

            if (tagGroupResult is { CommunicationSucceeded: true, HasData: true } &&
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

    public async Task<HttpClientRequestResult<IList<string>>> SearchTags(
        string? channelName,
        string? deviceName,
        string query,
        CancellationToken cancellationToken)
    {
        if (string.IsNullOrEmpty(query))
        {
            return new HttpClientRequestResult<IList<string>>(HttpStatusCode.BadRequest);
        }

        const int maxDepth = 1000;
        if (string.IsNullOrEmpty(channelName) ||
            "*".Equals(channelName, StringComparison.Ordinal))
        {
            return await SearchTags(query, maxDepth, cancellationToken);
        }

        if (string.IsNullOrEmpty(deviceName) ||
            "*".Equals(deviceName, StringComparison.Ordinal))
        {
            if ("*".Equals(channelName, StringComparison.Ordinal))
            {
                channelName = string.Empty;
            }

            return await SearchTagsByChannelName(channelName, query, maxDepth, cancellationToken);
        }

        return await SearchTagsByChannelNameAndDeviceName(channelName, deviceName, query, maxDepth, cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateTag(
        TagRequest request,
        string channelName,
        string deviceName,
        string[] tagGroupStructure,
        bool ensureTagGroupStructure,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);
        ArgumentNullException.ThrowIfNull(tagGroupStructure);

        if (!IsValidConnectivityName(
                channelName,
                deviceName,
                tagGroupNameOrTagName: null,
                tagGroupStructure,
                out var errorMessage))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(errorMessage!));
        }

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateTag(
            request,
            channelName,
            deviceName,
            tagGroupStructure,
            ensureTagGroupStructure,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> CreateTagGroup(
        TagGroupRequest request,
        string channelName,
        string deviceName,
        string[] tagGroupStructure,
        bool ensureTagGroupStructure,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);
        ArgumentNullException.ThrowIfNull(tagGroupStructure);

        if (!IsValidConnectivityName(
                channelName,
                deviceName,
                tagGroupNameOrTagName: null,
                tagGroupStructure,
                out var errorMessage))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(errorMessage!));
        }

        if (!DataAnnotationHelper.TryValidateOutToString(request, out var validationErrors))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(validationErrors));
        }

        return InvokeCreateTagGroup(
            request,
            channelName,
            deviceName,
            tagGroupStructure,
            ensureTagGroupStructure,
            cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> DeleteChannel(
        string channelName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);

        return !IsValidConnectivityName(
            channelName,
            deviceName: null,
            tagGroupNameOrTagName: null,
            tagGroupStructure: null,
            out var errorMessage)
            ? Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(errorMessage!))
            : Delete($"{EndpointPathTemplateConstants.Channels}/{channelName}", cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> DeleteDevice(
        string channelName,
        string deviceName,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);

        return !IsValidConnectivityName(
            channelName,
            deviceName,
            tagGroupNameOrTagName: null,
            tagGroupStructure: null,
            out var errorMessage)
            ? Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(errorMessage!))
            : Delete(GetBasePathTemplate(channelName, deviceName), cancellationToken);
    }

    public Task<HttpClientRequestResult<bool>> DeleteTag(
        string channelName,
        string deviceName,
        string tagName,
        string[] tagGroupStructure,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);
        ArgumentNullException.ThrowIfNull(tagName);
        ArgumentNullException.ThrowIfNull(tagGroupStructure);

        if (!IsValidConnectivityName(
                channelName,
                deviceName,
                tagName,
                tagGroupStructure,
                out var errorMessage))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(errorMessage!));
        }

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
        ArgumentNullException.ThrowIfNull(channelName);
        ArgumentNullException.ThrowIfNull(deviceName);
        ArgumentNullException.ThrowIfNull(tagGroupName);
        ArgumentNullException.ThrowIfNull(tagGroupStructure);

        if (!IsValidConnectivityName(
                channelName,
                deviceName,
                tagGroupName,
                tagGroupStructure,
                out var errorMessage))
        {
            return Task.FromResult(HttpClientRequestResultFactory<bool>.CreateBadRequest(errorMessage!));
        }

        return InvokeDeleteTagGroup(
            channelName,
            deviceName,
            tagGroupName,
            tagGroupStructure,
            cancellationToken);
    }

    private Task<HttpClientRequestResult<IList<KepwareContracts.Connectivity.Tag>?>> GetTagsResultForPathTemplate(
        string pathTemplate,
        CancellationToken cancellationToken)
        => Get<IList<KepwareContracts.Connectivity.Tag>>(
            $"{pathTemplate}/{EndpointPathTemplateConstants.Tags}",
            cancellationToken);

    private Task<HttpClientRequestResult<IList<KepwareContracts.Connectivity.TagGroup>?>> GetTagGroupResultForPathTemplate(
        string pathTemplate,
        CancellationToken cancellationToken)
        => Get<IList<KepwareContracts.Connectivity.TagGroup>>(
            $"{pathTemplate}/{EndpointPathTemplateConstants.TagGroups}",
            cancellationToken);

    private async Task<HttpClientRequestResult<IList<string>>> SearchTags(
        string query,
        int maxDepth,
        CancellationToken cancellationToken)
    {
        var channelResult = await GetChannels(cancellationToken);
        if (!channelResult.CommunicationSucceeded || !channelResult.HasData)
        {
            return channelResult.HasException
                ? new HttpClientRequestResult<IList<string>>(channelResult.Exception!)
                : new HttpClientRequestResult<IList<string>>(channelResult.StatusCode, []);
        }

        var searchResults = new List<string>();
        foreach (var channelName in channelResult.Data!
                     .Select(x => x.Name)
                     .OrderBy(x => x, StringComparer.OrdinalIgnoreCase))
        {
            var devicesResult = await GetDevicesByChannelName(channelName, cancellationToken);
            foreach (var deviceName in devicesResult.Data!
                         .Select(x => x.Name)
                         .OrderBy(x => x, StringComparer.OrdinalIgnoreCase))
            {
                var tagsResultForDevice = await GetTags(channelName, deviceName, maxDepth, cancellationToken);
                if (tagsResultForDevice is { CommunicationSucceeded: true, HasData: true })
                {
                    SearchInTagRoot(searchResults, channelName, deviceName, query, tagsResultForDevice.Data!);
                }
            }
        }

        return new HttpClientRequestResult<IList<string>>(searchResults);
    }

    private async Task<HttpClientRequestResult<IList<string>>> SearchTagsByChannelName(
        string channelName,
        string query,
        int maxDepth,
        CancellationToken cancellationToken)
    {
        var devicesResult = await GetDevicesByChannelName(channelName, cancellationToken);
        if (!devicesResult.CommunicationSucceeded || !devicesResult.HasData)
        {
            return devicesResult.HasException
                ? new HttpClientRequestResult<IList<string>>(devicesResult.Exception!)
                : new HttpClientRequestResult<IList<string>>(devicesResult.StatusCode, []);
        }

        var searchResults = new List<string>();
        foreach (var deviceName in devicesResult.Data!
                     .Select(x => x.Name)
                     .OrderBy(x => x, StringComparer.OrdinalIgnoreCase))
        {
            var tagsResultForDevice = await GetTags(channelName, deviceName, maxDepth, cancellationToken);
            if (tagsResultForDevice is { CommunicationSucceeded: true, HasData: true })
            {
                SearchInTagRoot(searchResults, channelName, deviceName, query, tagsResultForDevice.Data!);
            }
        }

        return new HttpClientRequestResult<IList<string>>(searchResults);
    }

    private async Task<HttpClientRequestResult<IList<string>>> SearchTagsByChannelNameAndDeviceName(
        string channelName,
        string deviceName,
        string query,
        int maxDepth,
        CancellationToken cancellationToken)
    {
        var tagsResult = await GetTags(channelName, deviceName, maxDepth, cancellationToken);
        if (!tagsResult.CommunicationSucceeded || !tagsResult.HasData)
        {
            return tagsResult.HasException
                ? new HttpClientRequestResult<IList<string>>(tagsResult.Exception!)
                : new HttpClientRequestResult<IList<string>>(tagsResult.StatusCode, []);
        }

        var searchResults = new List<string>();
        SearchInTagRoot(searchResults, channelName, deviceName, query, tagsResult.Data!);
        return new HttpClientRequestResult<IList<string>>(searchResults);
    }

    private async Task<HttpClientRequestResult<bool>> InvokeCreateTag(
        TagRequest request,
        string channelName,
        string deviceName,
        string[] tagGroupStructure,
        bool ensureTagGroupStructure,
        CancellationToken cancellationToken)
    {
        if (ensureTagGroupStructure)
        {
            await EnsureTagGroupStructure(channelName, deviceName, tagGroupStructure, cancellationToken);
        }

        var basePathTemplate = GetBasePathTemplate(channelName, deviceName);
        var tagsPathTemplate = GetTagsPathFromTagGroupStructure(basePathTemplate, tagGroupStructure);

        return await Post(
            request.Adapt<KepwareContracts.Connectivity.TagRequest>(),
            tagsPathTemplate,
            cancellationToken);
    }

    private async Task<HttpClientRequestResult<bool>> InvokeCreateTagGroup(
        TagGroupRequest request,
        string channelName,
        string deviceName,
        string[] tagGroupStructure,
        bool ensureTagGroupStructure,
        CancellationToken cancellationToken)
    {
        if (ensureTagGroupStructure)
        {
            await EnsureTagGroupStructure(channelName, deviceName, tagGroupStructure, cancellationToken);
        }

        var basePathTemplate = GetBasePathTemplate(channelName, deviceName);
        var tagGroupPathTemplate = $"{GetTagGroupPathFromTagGroupStructure(basePathTemplate, tagGroupStructure)}/{EndpointPathTemplateConstants.TagGroups}";

        return await Post(
            request.Adapt<KepwareContracts.Connectivity.TagGroupRequest>(),
            tagGroupPathTemplate,
            cancellationToken);
    }

    private async Task EnsureTagGroupStructure(
        string channelName,
        string deviceName,
        string[] tagGroupStructure,
        CancellationToken cancellationToken)
    {
        if (!tagGroupStructure.Any())
        {
            return;
        }

        var testTagGroupStructure = new List<string>();
        foreach (var tagGroup in tagGroupStructure)
        {
            var isTagGroupDefinedResult = await IsTagGroupDefined(channelName, deviceName, tagGroup, testTagGroupStructure.ToArray(), cancellationToken);
            if (isTagGroupDefinedResult is { CommunicationSucceeded: true, Data: true })
            {
                testTagGroupStructure.Add(tagGroup);
                continue;
            }

            var request = new TagGroupRequest { Name = tagGroup };
            var requestResult = await CreateTagGroup(request, channelName, deviceName, testTagGroupStructure.ToArray(), ensureTagGroupStructure: false, cancellationToken);
            if (!requestResult.CommunicationSucceeded || requestResult.HasException)
            {
                break;
            }

            testTagGroupStructure.Add(tagGroup);
        }
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

    private static void SearchInTagRoot(
        ICollection<string> searchResults,
        string channelName,
        string deviceName,
        string query,
        TagRoot tagsResult)
    {
        foreach (var tag in tagsResult.Tags)
        {
            if (query.Contains('*', StringComparison.Ordinal))
            {
                SearchInTag(searchResults, channelName, deviceName, query, tag);
            }
            else if (tag.Name.Contains(query, StringComparison.OrdinalIgnoreCase))
            {
                searchResults.Add($"{channelName}/{deviceName}/{tag.Name}");
            }
        }

        foreach (var tagGroup in tagsResult.TagGroups)
        {
            SearchInTagGroup(searchResults, channelName, deviceName, query, tagGroup.Name, tagGroup);
        }
    }

    private static void SearchInTagGroup(
        ICollection<string> searchResults,
        string channelName,
        string deviceName,
        string query,
        string tagGroupPath,
        TagGroup tagsResult)
    {
        foreach (var tag in tagsResult.Tags)
        {
            if (query.Contains('*', StringComparison.Ordinal))
            {
                SearchInTag(searchResults, channelName, deviceName, query, tag);
            }
            else if (tag.Name.Contains(query, StringComparison.OrdinalIgnoreCase))
            {
                searchResults.Add($"{channelName}/{deviceName}/{tagGroupPath}/{tag.Name}");
            }
        }

        foreach (var tagGroup in tagsResult.TagGroups)
        {
            SearchInTagGroup(searchResults, channelName, deviceName, query, $"{tagGroupPath}/{tagGroup.Name}", tagGroup);
        }
    }

    private static void SearchInTag(
        ICollection<string> searchResults,
        string channelName,
        string deviceName,
        string query,
        Tag tag)
    {
        if (query.StartsWith('*') &&
            query.EndsWith('*'))
        {
            var queryNoWildcard = query.Replace("*", string.Empty, StringComparison.Ordinal);
            if (tag.Name.Contains(queryNoWildcard, StringComparison.OrdinalIgnoreCase))
            {
                searchResults.Add($"{channelName}/{deviceName}/{tag.Name}");
            }
        }
        else if (query.StartsWith('*'))
        {
            var queryNoWildcard = query.Replace("*", string.Empty, StringComparison.Ordinal);
            if (tag.Name.StartsWith(queryNoWildcard, StringComparison.OrdinalIgnoreCase))
            {
                searchResults.Add($"{channelName}/{deviceName}/{tag.Name}");
            }
        }
        else
        {
            var queryNoWildcard = query.Replace("*", string.Empty, StringComparison.Ordinal);
            if (tag.Name.EndsWith(queryNoWildcard, StringComparison.OrdinalIgnoreCase))
            {
                searchResults.Add($"{channelName}/{deviceName}/{tag.Name}");
            }
        }
    }

    private static bool IsValidConnectivityName(
        string channelName,
        string? deviceName,
        string? tagGroupNameOrTagName,
        string[]? tagGroupStructure,
        out string? errorMessage)
    {
        if (!KeyStringAttribute.TryIsValid(channelName, ChannelNameKeyStringAttribute, out var errorMessageChannel))
        {
            errorMessage = errorMessageChannel;
            return false;
        }

        if (deviceName is not null &&
            !KeyStringAttribute.TryIsValid(deviceName, out var errorMessageDevice))
        {
            errorMessage = errorMessageDevice;
            return false;
        }

        if (tagGroupNameOrTagName is not null &&
            !KeyStringAttribute.TryIsValid(tagGroupNameOrTagName, out var errorMessageTag))
        {
            errorMessage = errorMessageTag;
            return false;
        }

        if (tagGroupStructure is not null)
        {
            foreach (var tagGroupItem in tagGroupStructure)
            {
                if (KeyStringAttribute.TryIsValid(tagGroupItem, out var errorMessageTagGroupItem))
                {
                    continue;
                }

                errorMessage = errorMessageTagGroupItem;
                return false;
            }
        }

        errorMessage = null;
        return true;
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

        if (tagGroupResult is { CommunicationSucceeded: true, HasData: true } &&
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
        => $"{EndpointPathTemplateConstants.Channels}/{channelName}/{EndpointPathTemplateConstants.Devices}/{deviceName}";

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
}