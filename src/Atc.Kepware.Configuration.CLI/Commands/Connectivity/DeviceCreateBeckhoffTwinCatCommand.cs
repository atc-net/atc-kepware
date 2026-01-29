namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class DeviceCreateBeckhoffTwinCatCommand : AsyncCommand<DeviceCreateBeckhoffTwinCatCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<DeviceCreateBeckhoffTwinCatCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DeviceCreateBeckhoffTwinCatCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<DeviceCreateBeckhoffTwinCatCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DeviceCreateBeckhoffTwinCatCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        DeviceCreateBeckhoffTwinCatCommandSettings settings)
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

            var request = BuildBeckhoffTwinCatDeviceRequest(settings);
            var result = await kepwareConfigurationClient.CreateBeckhoffTwinCatDevice(
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

    private static BeckhoffTwinCatDeviceRequest BuildBeckhoffTwinCatDeviceRequest(
        DeviceCreateBeckhoffTwinCatCommandSettings settings)
        => new()
        {
            Name = settings.DeviceName,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,
            DeviceId = settings.DeviceId,
            Model = settings.Model is not null && settings.Model.IsSet
                ? settings.Model.Value
                : BeckhoffTwinCatModel.TwinCatPlc,
            IdFormat = settings.IdFormat is not null && settings.IdFormat.IsSet
                ? settings.IdFormat.Value
                : BeckhoffTwinCatIdFormat.Decimal,
            PortNumber = settings.PortNumber,
            DefaultType = settings.DefaultType is not null && settings.DefaultType.IsSet
                ? settings.DefaultType.Value
                : BeckhoffTwinCatDefaultType.Word,
            ImportSource = settings.ImportSource is not null && settings.ImportSource.IsSet
                ? settings.ImportSource.Value
                : BeckhoffTwinCatImportSource.Device,
            SymbolFile = settings.SymbolFile is not null && settings.SymbolFile.IsSet
                ? settings.SymbolFile.Value
                : null,
        };
}