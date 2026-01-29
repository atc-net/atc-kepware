namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity.Devices.Create;

public sealed class DeviceCreateWonderwareIntouchClientCommand : AsyncCommand<DeviceCreateWonderwareIntouchClientCommandSettings>
{
    private readonly ILogger<DeviceCreateWonderwareIntouchClientCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DeviceCreateWonderwareIntouchClientCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        logger = loggerFactory.CreateLogger<DeviceCreateWonderwareIntouchClientCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DeviceCreateWonderwareIntouchClientCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        DeviceCreateWonderwareIntouchClientCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ConsoleHelper.WriteHeader();

        try
        {
            kepwareConfigurationClient.SetConnectionInformation(
                new Uri(settings.ServerUrl),
                settings.UserName!.Value,
                settings.Password!.Value);

            var isDeviceDefinedResult = await kepwareConfigurationClient.IsDeviceDefined(
                settings.ChannelName,
                settings.DeviceName,
                cancellationToken);

            if (!isDeviceDefinedResult.CommunicationSucceeded)
            {
                return ConsoleExitStatusCodes.Failure;
            }

            if (isDeviceDefinedResult.Data)
            {
                logger.LogWarning("Device already exists!");
                return ConsoleExitStatusCodes.Success;
            }

            var request = BuildWonderwareIntouchClientDeviceRequest(settings);
            var result = await kepwareConfigurationClient.CreateWonderwareIntouchClientDevice(
                request,
                settings.ChannelName,
                cancellationToken);

            if (!result.CommunicationSucceeded ||
                result.StatusCode is not (HttpStatusCode.OK or HttpStatusCode.Created))
            {
                return ConsoleExitStatusCodes.Failure;
            }
        }
        catch (Exception ex)
        {
            logger.LogError($"{EmojisConstants.Error} {ex.GetMessage()}");
            return ConsoleExitStatusCodes.Failure;
        }

        logger.LogInformation($"{EmojisConstants.Success} Done");
        return ConsoleExitStatusCodes.Success;
    }

    private static WonderwareIntouchClientDeviceRequest BuildWonderwareIntouchClientDeviceRequest(
        DeviceCreateWonderwareIntouchClientCommandSettings settings)
    {
        var request = new WonderwareIntouchClientDeviceRequest
        {
            Name = settings.DeviceName,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,
        };

        if (settings.Model is { IsSet: true })
        {
            request.Model = settings.Model.Value;
        }

        if (settings.ImportMethod is { IsSet: true })
        {
            request.ImportMethod = settings.ImportMethod.Value;
        }

        if (settings.InTouchProjectFolder is { IsSet: true })
        {
            request.InTouchProjectFolder = settings.InTouchProjectFolder.Value;
        }

        if (settings.InTouchCsvFile is { IsSet: true })
        {
            request.InTouchCsvFile = settings.InTouchCsvFile.Value;
        }

        if (settings.IncludeTagDescriptions is { IsSet: true })
        {
            request.IncludeTagDescriptions = settings.IncludeTagDescriptions.Value;
        }

        if (settings.ImportSystemTags is { IsSet: true })
        {
            request.ImportSystemTags = settings.ImportSystemTags.Value;
        }

        if (settings.TagNaming is { IsSet: true })
        {
            request.TagNaming = settings.TagNaming.Value;
        }

        if (settings.Mode is { IsSet: true })
        {
            request.Mode = settings.Mode.Value;
        }

        if (settings.MaximumActiveTimeMs is { IsSet: true })
        {
            request.MaximumActiveTimeMs = settings.MaximumActiveTimeMs.Value;
        }

        if (settings.DeleteInactiveTags is { IsSet: true })
        {
            request.DeleteInactiveTags = settings.DeleteInactiveTags.Value;
        }

        return request;
    }
}