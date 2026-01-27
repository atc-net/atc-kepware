namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateBacNetIpCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--discovery-method [DISCOVERY-METHOD]")]
    [Description("Device discovery method (Automatic, Manual)")]
    public FlagValue<BacNetIpDiscoveryMethodType>? DiscoveryMethod { get; init; } = new();

    [CommandOption("--manual-ip [MANUAL-IP]")]
    [Description("IP address for manual discovery")]
    public FlagValue<string>? ManualDiscoveryIpAddress { get; init; } = new();

    [CommandOption("--bacnet-mac [BACNET-MAC]")]
    [Description("BACnet MAC address")]
    public FlagValue<string>? BacNetMac { get; init; } = new();

    [CommandOption("--remote-data-link [REMOTE-DATA-LINK]")]
    [Description("Remote data link technology (BacNetIp, MsTp, PointToPoint, Ethernet, ArcNet, LonTalk)")]
    public FlagValue<BacNetIpRemoteDataLinkType>? RemoteDataLinkTechnology { get; init; } = new();

    [CommandOption("--cov-mode [COV-MODE]")]
    [Description("COV subscription mode (Disabled, Enabled)")]
    public FlagValue<BacNetIpCovModeType>? CovMode { get; init; } = new();

    [CommandOption("--cov-resubscription-interval")]
    [Description("COV resubscription interval in seconds (60-86400)")]
    [DefaultValue(3600)]
    public int CovResubscriptionInterval { get; init; }

    [CommandOption("--cancel-cov-subscriptions")]
    [Description("Cancel COV subscriptions on shutdown")]
    [DefaultValue(true)]
    public bool CancelCovSubscriptions { get; init; }

    [CommandOption("--max-apdu-length")]
    [Description("Maximum APDU length")]
    [DefaultValue(1476)]
    public int MaximumApduLength { get; init; }

    [CommandOption("--max-items-per-request")]
    [Description("Maximum items per request")]
    [DefaultValue(16)]
    public int MaximumItemsPerRequest { get; init; }

    [CommandOption("--command-priority")]
    [Description("Command priority for writes (1-16)")]
    [DefaultValue(16)]
    public int CommandPriority { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (CovResubscriptionInterval < 60 || CovResubscriptionInterval > 86400)
        {
            return ValidationResult.Error("--cov-resubscription-interval must be between 60 and 86400.");
        }

        if (CommandPriority < 1 || CommandPriority > 16)
        {
            return ValidationResult.Error("--command-priority must be between 1 and 16.");
        }

        return ValidationResult.Success();
    }
}
