namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class DeviceCreateMitsubishiFxNetCommand : AsyncCommand<DeviceCreateMitsubishiFxNetCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<DeviceCreateMitsubishiFxNetCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DeviceCreateMitsubishiFxNetCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<DeviceCreateMitsubishiFxNetCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DeviceCreateMitsubishiFxNetCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        DeviceCreateMitsubishiFxNetCommandSettings settings)
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

            var request = BuildMitsubishiFxNetDeviceRequest(settings);
            var result = await kepwareConfigurationClient.CreateMitsubishiFxNetDevice(
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

    private static MitsubishiFxNetDeviceRequest BuildMitsubishiFxNetDeviceRequest(
        DeviceCreateMitsubishiFxNetCommandSettings settings)
        => new()
        {
            Name = settings.DeviceName,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,

            // Mitsubishi FX Net Specific Settings
            Model = settings.Model,
            DeviceId = settings.DeviceId,
            IpAddress = settings.IpAddress,
            Port = settings.Port,
            Protocol = settings.Protocol is not null && settings.Protocol.IsSet
                ? settings.Protocol.Value
                : MitsubishiFxNetProtocolType.TcpIp,
            ConnectTimeout = settings.ConnectTimeout,
            RequestTimeout = settings.RequestTimeout,
            RetryAttempts = settings.RetryAttempts,
            DemoteOnFailure = settings.DemoteOnFailure,
            TimeoutsToDemote = settings.TimeoutsToDemote,
            DemotionPeriod = settings.DemotionPeriod,
            DiscardRequestsWhenDemoted = settings.DiscardRequestsWhenDemoted,
        };
}