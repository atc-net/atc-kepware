namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateYokogawaGxEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--model")]
    [Description("Device model")]
    [DefaultValue(YokogawaGxEthernetModel.Gx)]
    public YokogawaGxEthernetModel Model { get; init; } = YokogawaGxEthernetModel.Gx;

    [CommandOption("--as1-security-option")]
    [Description("Enable AS1 security option")]
    [DefaultValue(false)]
    public bool As1SecurityOption { get; init; }

    [CommandOption("--username")]
    [Description("Username (max 256 characters)")]
    [DefaultValue("admin")]
    public string Username { get; init; } = "admin";

    [CommandOption("--device-password")]
    [Description("Password (max 256 characters)")]
    [DefaultValue("0")]
    public string DevicePassword { get; init; } = "0";

    [CommandOption("--user-id")]
    [Description("User ID for AS1 security")]
    [DefaultValue("")]
    public string UserId { get; init; } = string.Empty;
}