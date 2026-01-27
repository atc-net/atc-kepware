namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class ChannelCreateBacNetIpCommandSettings : ChannelCreateCommandBaseSettings
{
    [CommandOption("--network-adapter [NETWORK-ADAPTER]")]
    [Description("Network adapter to bind for Ethernet communication")]
    public FlagValue<string>? NetworkAdapter { get; init; } = new();

    [CommandOption("--cov-notifications [COV-NOTIFICATIONS]")]
    [Description("COV notification mode (RequireNpdu, AllowEmptyNpdu)")]
    public FlagValue<BacNetIpCovNotificationType>? CovNotifications { get; init; } = new();

    [CommandOption("--udp-port")]
    [Description("Local UDP port for BACnet communication (1-65535)")]
    [DefaultValue(47808)]
    public int UdpPort { get; init; }

    [CommandOption("--local-network-number")]
    [Description("Local BACnet network number (1-65534)")]
    [DefaultValue(1)]
    public int LocalNetworkNumber { get; init; }

    [CommandOption("--local-device-instance")]
    [Description("Local BACnet device instance (0-4194302)")]
    [DefaultValue(0)]
    public int LocalDeviceInstance { get; init; }

    [CommandOption("--register-as-foreign-device")]
    [Description("Register as a foreign device")]
    [DefaultValue(false)]
    public bool RegisterAsForeignDevice { get; init; }

    [CommandOption("--bbmd-ip [BBMD-IP]")]
    [Description("IP address of remote BBMD")]
    public FlagValue<string>? IpAddressOfRemoteBbmd { get; init; } = new();

    [CommandOption("--registration-ttl")]
    [Description("Registration time-to-live in seconds (10-3600)")]
    [DefaultValue(60)]
    public int RegistrationTimeToLive { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (UdpPort < 1 || UdpPort > 65535)
        {
            return ValidationResult.Error("--udp-port must be between 1 and 65535.");
        }

        if (LocalNetworkNumber < 1 || LocalNetworkNumber > 65534)
        {
            return ValidationResult.Error("--local-network-number must be between 1 and 65534.");
        }

        if (LocalDeviceInstance < 0 || LocalDeviceInstance > 4194302)
        {
            return ValidationResult.Error("--local-device-instance must be between 0 and 4194302.");
        }

        if (RegistrationTimeToLive < 10 || RegistrationTimeToLive > 3600)
        {
            return ValidationResult.Error("--registration-ttl must be between 10 and 3600.");
        }

        return ValidationResult.Success();
    }
}
