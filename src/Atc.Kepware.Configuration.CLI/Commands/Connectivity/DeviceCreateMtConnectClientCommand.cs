namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class DeviceCreateMtConnectClientCommand : AsyncCommand<DeviceCreateMtConnectClientCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<DeviceCreateMtConnectClientCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DeviceCreateMtConnectClientCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<DeviceCreateMtConnectClientCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DeviceCreateMtConnectClientCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        DeviceCreateMtConnectClientCommandSettings settings,
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

            var request = BuildMtConnectClientDeviceRequest(settings);
            var result = await kepwareConfigurationClient.CreateMtConnectClientDevice(
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

    private static MtConnectClientDeviceRequest BuildMtConnectClientDeviceRequest(
        DeviceCreateMtConnectClientCommandSettings settings)
    {
        var request = new MtConnectClientDeviceRequest
        {
            Name = settings.DeviceName,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,
        };

        if (settings.PortNumber is { IsSet: true })
        {
            request.PortNumber = settings.PortNumber.Value;
        }

        if (settings.CloseAgentConnectionAfterEachRequest is { IsSet: true })
        {
            request.CloseAgentConnectionAfterEachRequest = settings.CloseAgentConnectionAfterEachRequest.Value;
        }

        if (settings.SchemaTagValidation is { IsSet: true })
        {
            request.SchemaTagValidation = settings.SchemaTagValidation.Value;
        }

        if (settings.ReadAllItemsInSingleRequest is { IsSet: true })
        {
            request.ReadAllItemsInSingleRequest = settings.ReadAllItemsInSingleRequest.Value;
        }

        if (settings.ItemsPerRequest is { IsSet: true })
        {
            request.ItemsPerRequest = settings.ItemsPerRequest.Value;
        }

        return request;
    }
}