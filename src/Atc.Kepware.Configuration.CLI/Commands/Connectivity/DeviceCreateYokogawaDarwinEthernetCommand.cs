namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class DeviceCreateYokogawaDarwinEthernetCommand : AsyncCommand<DeviceCreateYokogawaDarwinEthernetCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<DeviceCreateYokogawaDarwinEthernetCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DeviceCreateYokogawaDarwinEthernetCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<DeviceCreateYokogawaDarwinEthernetCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DeviceCreateYokogawaDarwinEthernetCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        DeviceCreateYokogawaDarwinEthernetCommandSettings settings)
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

            var request = BuildYokogawaDarwinEthernetDeviceRequest(settings);
            var result = await kepwareConfigurationClient.CreateYokogawaDarwinEthernetDevice(
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

    private static YokogawaDarwinEthernetDeviceRequest BuildYokogawaDarwinEthernetDeviceRequest(
        DeviceCreateYokogawaDarwinEthernetCommandSettings settings)
        => new()
        {
            Name = settings.DeviceName,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,

            // Yokogawa Darwin Ethernet Specific Settings
            Model = settings.Model,
            DataHandling = settings.DataHandling,
            PollingInterval = settings.PollingInterval,
            StartMath = settings.StartMath,
            DateAndTime = settings.DateAndTime,
            DateFormat = settings.DateFormat,
            SetClock = settings.SetClock,
            TagDatabaseSource = settings.TagDatabaseSource,
        };
}
