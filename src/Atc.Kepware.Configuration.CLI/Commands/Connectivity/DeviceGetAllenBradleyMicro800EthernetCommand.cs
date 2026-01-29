namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class DeviceGetAllenBradleyMicro800EthernetCommand : AsyncCommand<ChannelAndDeviceCommandBaseSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<DeviceGetAllenBradleyMicro800EthernetCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DeviceGetAllenBradleyMicro800EthernetCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<DeviceGetAllenBradleyMicro800EthernetCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        ChannelAndDeviceCommandBaseSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        ChannelAndDeviceCommandBaseSettings settings)
    {
        ConsoleHelper.WriteHeader();

        try
        {
            kepwareConfigurationClient.SetConnectionInformation(
                new Uri(settings.ServerUrl),
                settings.UserName!.Value,
                settings.Password!.Value);

            var result = await kepwareConfigurationClient.GetAllenBradleyMicro800EthernetDevice(
                settings.ChannelName,
                settings.DeviceName,
                CancellationToken.None);

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