namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Devices.Create;

public class DeviceCreateTriconexEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--device-id <DEVICE-ID>")]
    [Description("Device node ID (1-63)")]
    [DefaultValue(1)]
    public int DeviceId { get; init; }

    [CommandOption("--primary-network-cm-ip <PRIMARY-NETWORK-CM-IP>")]
    [Description("IP address of the communications module on the primary network")]
    public string PrimaryNetworkCmIp { get; init; } = "0.0.0.0";

    [CommandOption("--secondary-network-cm-ip [SECONDARY-NETWORK-CM-IP]")]
    [Description("IP address of the communications module on the secondary network")]
    public FlagValue<string>? SecondaryNetworkCmIp { get; init; } = new();

    [CommandOption("--bin-data-update-period")]
    [Description("Bin data update period in milliseconds (50-10000)")]
    [DefaultValue(1000)]
    public int BinDataUpdatePeriod { get; init; }

    [CommandOption("--subscription-interval")]
    [Description("Subscription renewal interval in seconds (10-120)")]
    [DefaultValue(10)]
    public int SubscriptionInterval { get; init; }

    [CommandOption("--use-timestamp-from-device")]
    [Description("Use timestamp from device (Trident devices only)")]
    [DefaultValue(false)]
    public bool UseTimestampFromDevice { get; init; }

    [CommandOption("--variable-import-file [VARIABLE-IMPORT-FILE]")]
    [Description("Path to the TriStation export file for automatic tag generation")]
    public FlagValue<string>? VariableImportFile { get; init; } = new();

    [CommandOption("--import-node-name [IMPORT-NODE-NAME]")]
    [Description("Node name for tags that will be imported")]
    public FlagValue<string>? ImportNodeName { get; init; } = new();

    [CommandOption("--generate-device-system-tags")]
    [Description("Generate device system tags (Tricon model only)")]
    [DefaultValue(false)]
    public bool GenerateDeviceSystemTags { get; init; }

    [CommandOption("--generate-driver-system-tags")]
    [Description("Generate driver system tags for monitoring driver operation and network health")]
    [DefaultValue(false)]
    public bool GenerateDriverSystemTags { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (DeviceId < 1 || DeviceId > 63)
        {
            return ValidationResult.Error("--device-id must be between 1 and 63.");
        }

        if (string.IsNullOrEmpty(PrimaryNetworkCmIp))
        {
            return ValidationResult.Error("--primary-network-cm-ip is required.");
        }

        if (BinDataUpdatePeriod < 50 || BinDataUpdatePeriod > 10000)
        {
            return ValidationResult.Error("--bin-data-update-period must be between 50 and 10000.");
        }

        if (SubscriptionInterval < 10 || SubscriptionInterval > 120)
        {
            return ValidationResult.Error("--subscription-interval must be between 10 and 120.");
        }

        return ValidationResult.Success();
    }
}