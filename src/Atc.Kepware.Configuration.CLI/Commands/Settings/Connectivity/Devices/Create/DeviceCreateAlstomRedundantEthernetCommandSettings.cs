namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Devices.Create;

public sealed class DeviceCreateAlstomRedundantEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--primary-normal-ip <PRIMARY_NORMAL_IP>")]
    [Description("Specify the normal IP address for the primary device.")]
    public string PrimaryNormalIp { get; init; } = "255.255.255.255";

    [CommandOption("--primary-normal-port")]
    [Description("Specify the normal port for the primary device.")]
    [DefaultValue(502)]
    public int PrimaryNormalPort { get; init; }

    [CommandOption("--primary-standby-ip")]
    [Description("Specify the standby IP address for the primary device.")]
    [DefaultValue("255.255.255.255")]
    public string PrimaryStandbyIp { get; init; } = "255.255.255.255";

    [CommandOption("--primary-standby-port")]
    [Description("Specify the standby port for the primary device.")]
    [DefaultValue(502)]
    public int PrimaryStandbyPort { get; init; }

    [CommandOption("--secondary-normal-ip")]
    [Description("Specify the normal IP address for the secondary device.")]
    [DefaultValue("255.255.255.255")]
    public string SecondaryNormalIp { get; init; } = "255.255.255.255";

    [CommandOption("--secondary-normal-port")]
    [Description("Specify the normal port for the secondary device.")]
    [DefaultValue(1502)]
    public int SecondaryNormalPort { get; init; }

    [CommandOption("--secondary-standby-ip")]
    [Description("Specify the standby IP address for the secondary device.")]
    [DefaultValue("255.255.255.255")]
    public string SecondaryStandbyIp { get; init; } = "255.255.255.255";

    [CommandOption("--secondary-standby-port")]
    [Description("Specify the standby port for the secondary device.")]
    [DefaultValue(1502)]
    public int SecondaryStandbyPort { get; init; }
}