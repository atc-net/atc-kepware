namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class DeviceCreateBacNetIpCommand : AsyncCommand<DeviceCreateBacNetIpCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<DeviceCreateBacNetIpCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DeviceCreateBacNetIpCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<DeviceCreateBacNetIpCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DeviceCreateBacNetIpCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        DeviceCreateBacNetIpCommandSettings settings)
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
                CancellationToken.None);

            if (!isDeviceDefinedResult.CommunicationSucceeded)
            {
                return ConsoleExitStatusCodes.Failure;
            }

            if (isDeviceDefinedResult.Data)
            {
                logger.LogWarning("Device already exists!");
                return ConsoleExitStatusCodes.Success;
            }

            var request = BuildBacNetIpDeviceRequest(settings);
            var result = await kepwareConfigurationClient.CreateBacNetIpDevice(
                request,
                settings.ChannelName,
                CancellationToken.None);

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

    private static BacNetIpDeviceRequest BuildBacNetIpDeviceRequest(
        DeviceCreateBacNetIpCommandSettings settings)
        => new()
        {
            Name = settings.DeviceName,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,

            // BACnet/IP Specific Settings
            DiscoveryMethod = settings.DiscoveryMethod is not null && settings.DiscoveryMethod.IsSet
                ? settings.DiscoveryMethod.Value
                : BacNetIpDiscoveryMethodType.Automatic,
            ManualDiscoveryIpAddress = settings.ManualDiscoveryIpAddress is not null && settings.ManualDiscoveryIpAddress.IsSet
                ? settings.ManualDiscoveryIpAddress.Value
                : "0.0.0.0",
            BacNetMac = settings.BacNetMac is not null && settings.BacNetMac.IsSet
                ? settings.BacNetMac.Value
                : null,
            RemoteDataLinkTechnology = settings.RemoteDataLinkTechnology is not null && settings.RemoteDataLinkTechnology.IsSet
                ? settings.RemoteDataLinkTechnology.Value
                : BacNetIpRemoteDataLinkType.BacNetIp,
            CovMode = settings.CovMode is not null && settings.CovMode.IsSet
                ? settings.CovMode.Value
                : BacNetIpCovModeType.Disabled,
            CovResubscriptionInterval = settings.CovResubscriptionInterval,
            CancelCovSubscriptions = settings.CancelCovSubscriptions,
            MaximumApduLength = settings.MaximumApduLength,
            MaximumItemsPerRequest = settings.MaximumItemsPerRequest,
            CommandPriority = settings.CommandPriority,
        };
}
