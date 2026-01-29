namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity.Devices.Create;

public sealed class DeviceCreateCutlerHammerElcEthernetCommand : AsyncCommand<DeviceCreateCutlerHammerElcEthernetCommandSettings>
{
    private readonly ILogger<DeviceCreateCutlerHammerElcEthernetCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DeviceCreateCutlerHammerElcEthernetCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        logger = loggerFactory.CreateLogger<DeviceCreateCutlerHammerElcEthernetCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DeviceCreateCutlerHammerElcEthernetCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        DeviceCreateCutlerHammerElcEthernetCommandSettings settings,
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

            var request = BuildCutlerHammerElcEthernetDeviceRequest(settings);
            var result = await kepwareConfigurationClient.CreateCutlerHammerElcEthernetDevice(
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

    private static CutlerHammerElcEthernetDeviceRequest BuildCutlerHammerElcEthernetDeviceRequest(
        DeviceCreateCutlerHammerElcEthernetCommandSettings settings)
        => new()
        {
            Name = settings.DeviceName,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,

            // Cutler-Hammer ELC Ethernet Specific Settings
            Model = settings.Model,
            IdFormat = settings.IdFormat,
            DeviceId = settings.DeviceId,
            PortNumber = settings.PortNumber,
            OutputCoils = settings.OutputCoils,
            InputCoils = settings.InputCoils,
            HoldingRegisters = settings.HoldingRegisters,
            FirstWordLow = settings.FirstWordLow,
        };
}