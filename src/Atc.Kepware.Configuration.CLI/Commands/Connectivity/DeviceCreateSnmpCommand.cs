namespace Atc.Kepware.Configuration.CLI.Commands.Connectivity;

public sealed class DeviceCreateSnmpCommand : AsyncCommand<DeviceCreateSnmpCommandSettings>
{
    private readonly ILogger<DeviceCreateSnmpCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public DeviceCreateSnmpCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        logger = loggerFactory.CreateLogger<DeviceCreateSnmpCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        DeviceCreateSnmpCommandSettings settings,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings, cancellationToken);
    }

    private async Task<int> ExecuteInternalAsync(
        DeviceCreateSnmpCommandSettings settings,
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

            var request = BuildSnmpDeviceRequest(settings);
            var result = await kepwareConfigurationClient.CreateSnmpDevice(
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

    private static SnmpDeviceRequest BuildSnmpDeviceRequest(
        DeviceCreateSnmpCommandSettings settings)
        => new()
        {
            Name = settings.DeviceName,
            Description = settings.Description is not null && settings.Description.IsSet
                ? settings.Description.Value
                : string.Empty,

            // SNMP Specific Settings
            SnmpVersion = settings.SnmpVersion is not null && settings.SnmpVersion.IsSet
                ? settings.SnmpVersion.Value
                : SnmpVersionType.V2c,
            Port = settings.Port,
            Protocol = settings.Protocol is not null && settings.Protocol.IsSet
                ? settings.Protocol.Value
                : SnmpProtocolType.Udp,
            Community = settings.Community is not null && settings.Community.IsSet
                ? settings.Community.Value
                : SnmpCommunityType.Public,
            CustomCommunity = settings.CustomCommunity is not null && settings.CustomCommunity.IsSet
                ? settings.CustomCommunity.Value
                : "public",
            ItemsPerRequest = settings.ItemsPerRequest,
            Username = settings.Username is not null && settings.Username.IsSet
                ? settings.Username.Value
                : string.Empty,
            ContextName = settings.ContextName is not null && settings.ContextName.IsSet
                ? settings.ContextName.Value
                : string.Empty,
            SecurityLevel = settings.SecurityLevel is not null && settings.SecurityLevel.IsSet
                ? settings.SecurityLevel.Value
                : SnmpSecurityLevelType.NoAuthNoPriv,
            AuthenticationStyle = settings.AuthenticationStyle is not null && settings.AuthenticationStyle.IsSet
                ? settings.AuthenticationStyle.Value
                : SnmpAuthenticationProtocolType.HmacMd5,
            AuthenticationPassphrase = settings.AuthenticationPassphrase is not null && settings.AuthenticationPassphrase.IsSet
                ? settings.AuthenticationPassphrase.Value
                : string.Empty,
            EncryptionStyle = settings.EncryptionStyle is not null && settings.EncryptionStyle.IsSet
                ? settings.EncryptionStyle.Value
                : SnmpPrivacyProtocolType.Des,
            PrivacyPassphrase = settings.PrivacyPassphrase is not null && settings.PrivacyPassphrase.IsSet
                ? settings.PrivacyPassphrase.Value
                : string.Empty,
            Template = settings.Template is not null && settings.Template.IsSet
                ? settings.Template.Value
                : SnmpTemplateType.OtherDevice,
        };
}