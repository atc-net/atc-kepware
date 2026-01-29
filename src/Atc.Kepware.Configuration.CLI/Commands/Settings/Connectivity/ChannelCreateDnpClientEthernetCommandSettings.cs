namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class ChannelCreateDnpClientEthernetCommandSettings : ChannelCreateCommandBaseSettings
{
    [CommandOption("--network-adapter [NETWORK-ADAPTER]")]
    [Description("Network adapter to bind for Ethernet communication")]
    public FlagValue<string>? NetworkAdapter { get; init; } = new();

    [CommandOption("--protocol [PROTOCOL]")]
    [Description("Protocol for communication (Tcp, Udp)")]
    public FlagValue<DnpClientEthernetProtocolType>? Protocol { get; init; } = new();

    [CommandOption("--source-port")]
    [Description("Source port for receiving UDP traffic (0-65535)")]
    [DefaultValue(0)]
    public int SourcePort { get; init; }

    [CommandOption("--destination-host [DESTINATION-HOST]")]
    [Description("Destination IP address or hostname")]
    public FlagValue<string>? DestinationHost { get; init; } = new();

    [CommandOption("--destination-port")]
    [Description("Destination port (1-65535)")]
    [DefaultValue(20000)]
    public int DestinationPort { get; init; }

    [CommandOption("--connect-timeout")]
    [Description("Connection timeout in seconds (1-30)")]
    [DefaultValue(3)]
    public int ConnectTimeout { get; init; }

    [CommandOption("--response-timeout")]
    [Description("Response timeout in milliseconds (100-3600000)")]
    [DefaultValue(10000)]
    public int ResponseTimeout { get; init; }

    [CommandOption("--max-link-layer-retries")]
    [Description("Maximum link layer retries (0-255)")]
    [DefaultValue(3)]
    public int MaxLinkLayerRetries { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (SourcePort < 0 || SourcePort > 65535)
        {
            return ValidationResult.Error("--source-port must be between 0 and 65535.");
        }

        if (DestinationPort < 1 || DestinationPort > 65535)
        {
            return ValidationResult.Error("--destination-port must be between 1 and 65535.");
        }

        if (ConnectTimeout < 1 || ConnectTimeout > 30)
        {
            return ValidationResult.Error("--connect-timeout must be between 1 and 30.");
        }

        if (ResponseTimeout < 100 || ResponseTimeout > 3600000)
        {
            return ValidationResult.Error("--response-timeout must be between 100 and 3600000.");
        }

        if (MaxLinkLayerRetries < 0 || MaxLinkLayerRetries > 255)
        {
            return ValidationResult.Error("--max-link-layer-retries must be between 0 and 255.");
        }

        return ValidationResult.Success();
    }
}
