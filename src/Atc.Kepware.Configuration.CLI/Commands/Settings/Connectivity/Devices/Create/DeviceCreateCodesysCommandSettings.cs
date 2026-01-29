namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Devices.Create;

public class DeviceCreateCodesysCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--ip-address <IP-ADDRESS>")]
    [Description("IP address or hostname of the target device")]
    public string IpAddress { get; init; } = string.Empty;

    [CommandOption("--model [MODEL]")]
    [Description("Device model (CodesysV23Ethernet, CodesysV3Ethernet)")]
    public FlagValue<CodesysDeviceModelType>? Model { get; init; } = new();

    [CommandOption("--port")]
    [Description("TCP/IP port number on the target device (0-65535)")]
    [DefaultValue(1200)]
    public int Port { get; init; }

    [CommandOption("--target-id")]
    [Description("Target ID if this device is a sub-PLC")]
    [DefaultValue(0L)]
    public long TargetId { get; init; }

    [CommandOption("--tags-per-request")]
    [Description("Maximum number of tags to include in a single request (1-10000)")]
    [DefaultValue(500)]
    public int TagsPerRequest { get; init; }

    [CommandOption("--use-gateway")]
    [Description("Use gateway when connecting to the device")]
    [DefaultValue(false)]
    public bool UseGateway { get; init; }

    [CommandOption("--gateway-address [GATEWAY-ADDRESS]")]
    [Description("IP address or hostname for the gateway")]
    public FlagValue<string>? GatewayAddress { get; init; } = new();

    [CommandOption("--gateway-port")]
    [Description("Port for the gateway (0-65535)")]
    [DefaultValue(1210)]
    public int GatewayPort { get; init; }

    [CommandOption("--gateway-password [GATEWAY-PASSWORD]")]
    [Description("Password for the gateway")]
    public FlagValue<string>? GatewayPassword { get; init; } = new();

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (string.IsNullOrEmpty(IpAddress))
        {
            return ValidationResult.Error("--ip-address is required.");
        }

        if (Port < 0 || Port > 65535)
        {
            return ValidationResult.Error("--port must be between 0 and 65535.");
        }

        if (TagsPerRequest < 1 || TagsPerRequest > 10000)
        {
            return ValidationResult.Error("--tags-per-request must be between 1 and 10000.");
        }

        if (GatewayPort < 0 || GatewayPort > 65535)
        {
            return ValidationResult.Error("--gateway-port must be between 0 and 65535.");
        }

        return ValidationResult.Success();
    }
}