namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class DeviceGetYokogawaDxEthernetCommand : AsyncCommand<ChannelAndDeviceCommandBaseSettings>
{
    private readonly ILogger<DeviceGetYokogawaDxEthernetCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DeviceGetYokogawaDxEthernetCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        logger = loggerFactory.CreateLogger<DeviceGetYokogawaDxEthernetCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        ChannelAndDeviceCommandBaseSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        ChannelAndDeviceCommandBaseSettings settings,
        CancellationToken cancellationToken)
    {
        ConsoleHelper.WriteHeader();

        try
        {
            kepwareConfigurationClient.SetConnectionInformation(
                new Uri(settings.ServerUrl),
                settings.UserName!.Value,
                settings.Password!.Value);

            var result = await kepwareConfigurationClient.GetYokogawaDxEthernetDevice(
                settings.ChannelName,
                settings.DeviceName,
                cancellationToken);

            if (result is { CommunicationSucceeded: true, HasData: true })
            {
                var item = result.Data!;
                var properties = item.GetType().GetPublicProperties();
                foreach (var property in properties)
                {
                    var typeName = $"{property.BeautifyName()}";
                    var spaces = string.Empty.PadRight(10 - typeName.Length);
                    logger.LogInformation($"{typeName}{spaces}{property.Name}: {item.GetPropertyValue(property.Name)}");
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(result.Message))
                {
                    logger.LogWarning(result.Message);
                }

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
}