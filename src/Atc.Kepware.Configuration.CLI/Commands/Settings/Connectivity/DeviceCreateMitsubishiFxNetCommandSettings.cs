namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateMitsubishiFxNetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--model")]
    [Description("Device model (Fx, Fx2C, Fx0N, Fx2N, FxOpen, Fx3U)")]
    [DefaultValue(MitsubishiFxNetModel.Fx)]
    public MitsubishiFxNetModel Model { get; init; } = MitsubishiFxNetModel.Fx;

    [CommandOption("--device-id")]
    [Description("Device station/node ID (0-15)")]
    [DefaultValue(0)]
    public int DeviceId { get; init; }

    [CommandOption("--ip-address <IP-ADDRESS>")]
    [Description("IP address of the device")]
    public string IpAddress { get; init; } = string.Empty;

    [CommandOption("--port")]
    [Description("Port number for device communication (0-65535)")]
    [DefaultValue(2101)]
    public int Port { get; init; } = 2101;

    [CommandOption("--protocol [PROTOCOL]")]
    [Description("IP protocol type (Udp, TcpIp)")]
    public FlagValue<MitsubishiFxNetProtocolType>? Protocol { get; init; } = new();

    [CommandOption("--connect-timeout")]
    [Description("Connection timeout in seconds (1-30)")]
    [DefaultValue(3)]
    public int ConnectTimeout { get; init; } = 3;

    [CommandOption("--request-timeout")]
    [Description("Request timeout in milliseconds (50-9999999)")]
    [DefaultValue(1000)]
    public int RequestTimeout { get; init; } = 1000;

    [CommandOption("--retry-attempts")]
    [Description("Number of retry attempts before timeout (1-10)")]
    [DefaultValue(3)]
    public int RetryAttempts { get; init; } = 3;

    [CommandOption("--demote-on-failure")]
    [Description("Demote device on communication failures")]
    [DefaultValue(false)]
    public bool DemoteOnFailure { get; init; }

    [CommandOption("--timeouts-to-demote")]
    [Description("Successive timeouts before demotion (1-30)")]
    [DefaultValue(3)]
    public int TimeoutsToDemote { get; init; } = 3;

    [CommandOption("--demotion-period")]
    [Description("Demotion period in milliseconds (100-3600000)")]
    [DefaultValue(10000)]
    public int DemotionPeriod { get; init; } = 10000;

    [CommandOption("--discard-requests-when-demoted")]
    [Description("Discard write requests when demoted")]
    [DefaultValue(false)]
    public bool DiscardRequestsWhenDemoted { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (DeviceId < 0 || DeviceId > 15)
        {
            return ValidationResult.Error("--device-id must be between 0 and 15.");
        }

        if (Port < 0 || Port > 65535)
        {
            return ValidationResult.Error("--port must be between 0 and 65535.");
        }

        if (ConnectTimeout < 1 || ConnectTimeout > 30)
        {
            return ValidationResult.Error("--connect-timeout must be between 1 and 30.");
        }

        if (RequestTimeout < 50 || RequestTimeout > 9999999)
        {
            return ValidationResult.Error("--request-timeout must be between 50 and 9999999.");
        }

        if (RetryAttempts < 1 || RetryAttempts > 10)
        {
            return ValidationResult.Error("--retry-attempts must be between 1 and 10.");
        }

        if (TimeoutsToDemote < 1 || TimeoutsToDemote > 30)
        {
            return ValidationResult.Error("--timeouts-to-demote must be between 1 and 30.");
        }

        if (DemotionPeriod < 100 || DemotionPeriod > 3600000)
        {
            return ValidationResult.Error("--demotion-period must be between 100 and 3600000.");
        }

        return ValidationResult.Success();
    }
}