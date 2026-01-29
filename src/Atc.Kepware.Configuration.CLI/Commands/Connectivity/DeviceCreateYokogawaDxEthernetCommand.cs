namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class DeviceCreateYokogawaDxEthernetCommand : AsyncCommand<DeviceCreateYokogawaDxEthernetCommandSettings>
{
    private readonly ILogger<DeviceCreateYokogawaDxEthernetCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DeviceCreateYokogawaDxEthernetCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        logger = loggerFactory.CreateLogger<DeviceCreateYokogawaDxEthernetCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DeviceCreateYokogawaDxEthernetCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        DeviceCreateYokogawaDxEthernetCommandSettings settings,
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

            var request = BuildYokogawaDxEthernetDeviceRequest(settings);
            var result = await kepwareConfigurationClient.CreateYokogawaDxEthernetDevice(
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

    private static YokogawaDxEthernetDeviceRequest BuildYokogawaDxEthernetDeviceRequest(
        DeviceCreateYokogawaDxEthernetCommandSettings settings)
        => new()
        {
            Name = settings.DeviceName,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,

            // Yokogawa DX Ethernet Specific Settings
            Model = settings.Model,
            DataHandling = settings.DataHandling,
            PollingInterval = settings.PollingInterval,
            StartMath = settings.StartMath,
            DateAndTime = settings.DateAndTime,
            DateFormat = settings.DateFormat,
            SetClock = settings.SetClock,
            TagDatabaseSource = settings.TagDatabaseSource,
            As1SecurityOption = settings.As1SecurityOption,
            Username = settings.Username,
            Password = settings.DevicePassword,
            UserId = settings.UserId,
            UserFunction = settings.UserFunction,
        };
}