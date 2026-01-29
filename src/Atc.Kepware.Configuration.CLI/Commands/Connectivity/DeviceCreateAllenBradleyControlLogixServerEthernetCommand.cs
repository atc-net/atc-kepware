namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class DeviceCreateAllenBradleyControlLogixServerEthernetCommand : AsyncCommand<DeviceCreateAllenBradleyControlLogixServerEthernetCommandSettings>
{
    private readonly ILogger<DeviceCreateAllenBradleyControlLogixServerEthernetCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DeviceCreateAllenBradleyControlLogixServerEthernetCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        logger = loggerFactory.CreateLogger<DeviceCreateAllenBradleyControlLogixServerEthernetCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DeviceCreateAllenBradleyControlLogixServerEthernetCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        DeviceCreateAllenBradleyControlLogixServerEthernetCommandSettings settings,
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

            var request = BuildAllenBradleyControlLogixServerEthernetDeviceRequest(settings);
            var result = await kepwareConfigurationClient.CreateAllenBradleyControlLogixServerEthernetDevice(
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

    private static AllenBradleyControlLogixServerEthernetDeviceRequest BuildAllenBradleyControlLogixServerEthernetDeviceRequest(
        DeviceCreateAllenBradleyControlLogixServerEthernetCommandSettings settings)
        => new()
        {
            Name = settings.DeviceName,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,

            // Allen-Bradley ControlLogix Server Ethernet Specific Settings
            ModuleType = settings.ModuleType,
            CpuSlot = settings.CpuSlot,
            TagHierarchy = settings.TagHierarchy,
            OpcQualityBadUntilWrite = settings.OpcQualityBadUntilWrite,
            PackStrings = settings.PackStrings,
        };
}