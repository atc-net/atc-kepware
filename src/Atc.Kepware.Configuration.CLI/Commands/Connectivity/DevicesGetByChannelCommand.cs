namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public class DevicesGetByChannelCommand : AsyncCommand<DevicesGetCommandSettings>
{
    private readonly ILogger<DevicesGetByChannelCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DevicesGetByChannelCommand(
        ILogger<DevicesGetByChannelCommand> logger,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.logger = logger;
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DevicesGetCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        DevicesGetCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        try
        {
            kepwareConfigurationClient.SetConnectionInformation(
                new Uri(settings.ServerUrl),
                settings.UserName!.Value,
                settings.Password!.Value);

            var result = await kepwareConfigurationClient.GetDevicesByChannelName(settings.ChannelName, CancellationToken.None);
            if (result.CommunicationSucceeded &&
                result.HasData)
            {
                foreach (var deviceBase in result.Data!)
                {
                    logger.LogInformation($"{deviceBase.Name} - {deviceBase.Driver}");
                }
            }
            else
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
}