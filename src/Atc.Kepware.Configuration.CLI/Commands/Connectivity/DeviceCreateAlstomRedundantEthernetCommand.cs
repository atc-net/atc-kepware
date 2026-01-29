namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class DeviceCreateAlstomRedundantEthernetCommand : AsyncCommand<DeviceCreateAlstomRedundantEthernetCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DeviceCreateAlstomRedundantEthernetCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DeviceCreateAlstomRedundantEthernetCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private async Task<int> ExecuteInternalAsync(
        DeviceCreateAlstomRedundantEthernetCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        var logger = loggerFactory.CreateLogger<DeviceCreateAlstomRedundantEthernetCommand>();

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

            var request = BuildRequest(settings);
            var result = await kepwareConfigurationClient.CreateAlstomRedundantEthernetDevice(request, settings.ChannelName, CancellationToken.None);
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

    private static AlstomRedundantEthernetDeviceRequest BuildRequest(
        DeviceCreateAlstomRedundantEthernetCommandSettings settings)
    {
        var request = new AlstomRedundantEthernetDeviceRequest
        {
            Name = settings.DeviceName,
            PrimaryNormalIp = settings.PrimaryNormalIp,
        };

        if (settings.Description is not null &&
            settings.Description.IsSet)
        {
            request.Description = settings.Description.Value!;
        }

        if (settings.PrimaryNormalPort > 0)
        {
            request.PrimaryNormalPort = settings.PrimaryNormalPort;
        }

        if (!string.IsNullOrEmpty(settings.PrimaryStandbyIp))
        {
            request.PrimaryStandbyIp = settings.PrimaryStandbyIp;
        }

        if (settings.PrimaryStandbyPort > 0)
        {
            request.PrimaryStandbyPort = settings.PrimaryStandbyPort;
        }

        if (!string.IsNullOrEmpty(settings.SecondaryNormalIp))
        {
            request.SecondaryNormalIp = settings.SecondaryNormalIp;
        }

        if (settings.SecondaryNormalPort > 0)
        {
            request.SecondaryNormalPort = settings.SecondaryNormalPort;
        }

        if (!string.IsNullOrEmpty(settings.SecondaryStandbyIp))
        {
            request.SecondaryStandbyIp = settings.SecondaryStandbyIp;
        }

        if (settings.SecondaryStandbyPort > 0)
        {
            request.SecondaryStandbyPort = settings.SecondaryStandbyPort;
        }

        return request;
    }
}