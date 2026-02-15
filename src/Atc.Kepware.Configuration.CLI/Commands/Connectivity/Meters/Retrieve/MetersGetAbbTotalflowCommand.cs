namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity.Meters.Retrieve;

public sealed class MetersGetAbbTotalflowCommand : AsyncCommand<MeterCommandBaseSettings>
{
    private readonly ILogger<MetersGetAbbTotalflowCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public MetersGetAbbTotalflowCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        logger = loggerFactory.CreateLogger<MetersGetAbbTotalflowCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        MeterCommandBaseSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        MeterCommandBaseSettings settings,
        CancellationToken cancellationToken)
    {
        ConsoleHelper.WriteHeader();

        try
        {
            kepwareConfigurationClient.SetConnectionInformation(
                new Uri(settings.ServerUrl),
                settings.UserName!.Value,
                settings.Password!.Value);

            var result = await kepwareConfigurationClient.GetAbbTotalflowMeters(
                settings.ChannelName,
                settings.DeviceName,
                settings.MeterGroupName,
                cancellationToken);

            if (result is { CommunicationSucceeded: true, HasData: true })
            {
                foreach (var item in result.Data!)
                {
                    var properties = item.GetType().GetPublicProperties();
                    foreach (var property in properties)
                    {
                        var typeName = $"{property.BeautifyName()}";
                        var spaces = string.Empty.PadRight(10 - typeName.Length);
                        logger.LogInformation($"{typeName}{spaces}{property.Name}: {item.GetPropertyValue(property.Name)}");
                    }

                    logger.LogInformation(string.Empty);
                }
            }
            else
            {
                if (result is { HasMessage: true })
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