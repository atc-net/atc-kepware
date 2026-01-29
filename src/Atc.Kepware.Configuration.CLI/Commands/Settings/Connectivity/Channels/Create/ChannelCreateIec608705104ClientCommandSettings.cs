namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Channels.Create;

public class ChannelCreateIec608705104ClientCommandSettings : ChannelCreateCommandBaseSettings
{
    [CommandOption("--network-adapter [NETWORK-ADAPTER]")]
    [Description("Network adapter to bind for Ethernet communication")]
    public FlagValue<string>? NetworkAdapter { get; init; } = new();

    [CommandOption("--destination-host")]
    [Description("IP address of the destination device")]
    [DefaultValue("255.255.255.255")]
    public string DestinationHost { get; init; } = "255.255.255.255";

    [CommandOption("--destination-port")]
    [Description("Port number used to connect to the destination device (1-65535)")]
    [DefaultValue(2404)]
    public int DestinationPort { get; init; } = 2404;

    [CommandOption("--connect-timeout")]
    [Description("Connection timeout in seconds (1-255)")]
    [DefaultValue(3)]
    public int ConnectTimeout { get; init; } = 3;

    [CommandOption("--cot-size [COT-SIZE]")]
    [Description("Cause of Transmission (COT) Size")]
    public FlagValue<Iec608705104CotSizeType>? CotSize { get; init; } = new();

    [CommandOption("--originator-address")]
    [Description("Originator Address used in the second byte of COT (0-254)")]
    [DefaultValue(0)]
    public int OriginatorAddress { get; init; }

    [CommandOption("--t1")]
    [Description("Time in seconds to wait for ACK to a transmitted APDU (1-255)")]
    [DefaultValue(15)]
    public int T1 { get; init; } = 15;

    [CommandOption("--t2")]
    [Description("Time in seconds to wait before sending a supervisory ACK (1-255)")]
    [DefaultValue(10)]
    public int T2 { get; init; } = 10;

    [CommandOption("--t3")]
    [Description("Idle time in seconds before sending a TEST APDU (1-172800)")]
    [DefaultValue(20)]
    public int T3 { get; init; } = 20;

    [CommandOption("--k")]
    [Description("Maximum unacknowledged transmitted APDUs (1-12)")]
    [DefaultValue(12)]
    public int K { get; init; } = 12;

    [CommandOption("--w")]
    [Description("Maximum unacknowledged received APDUs (1-65535)")]
    [DefaultValue(8)]
    public int W { get; init; } = 8;

    [CommandOption("--rx-buffer-size")]
    [Description("Maximum data receive size in bytes (2-253)")]
    [DefaultValue(253)]
    public int RxBufferSize { get; init; } = 253;

    [CommandOption("--incremental-timeout")]
    [Description("Time in milliseconds to wait for any response (10-2147483647)")]
    [DefaultValue(30000)]
    public int IncrementalTimeout { get; init; } = 30000;

    [CommandOption("--first-char-wait")]
    [Description("Time in milliseconds to wait after receiving a character (0-65535)")]
    [DefaultValue(0)]
    public int FirstCharWait { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        var connectionValidation = ValidateConnectionSettings();
        if (!connectionValidation.Successful)
        {
            return connectionValidation;
        }

        return ValidateTimingSettings();
    }

    private ValidationResult ValidateConnectionSettings()
    {
        if (DestinationPort < 1 || DestinationPort > 65535)
        {
            return ValidationResult.Error("--destination-port must be between 1 and 65535.");
        }

        if (ConnectTimeout < 1 || ConnectTimeout > 255)
        {
            return ValidationResult.Error("--connect-timeout must be between 1 and 255.");
        }

        if (OriginatorAddress < 0 || OriginatorAddress > 254)
        {
            return ValidationResult.Error("--originator-address must be between 0 and 254.");
        }

        if (K < 1 || K > 12)
        {
            return ValidationResult.Error("--k must be between 1 and 12.");
        }

        if (W < 1 || W > 65535)
        {
            return ValidationResult.Error("--w must be between 1 and 65535.");
        }

        if (RxBufferSize < 2 || RxBufferSize > 253)
        {
            return ValidationResult.Error("--rx-buffer-size must be between 2 and 253.");
        }

        return ValidationResult.Success();
    }

    private ValidationResult ValidateTimingSettings()
    {
        if (T1 < 1 || T1 > 255)
        {
            return ValidationResult.Error("--t1 must be between 1 and 255.");
        }

        if (T2 < 1 || T2 > 255)
        {
            return ValidationResult.Error("--t2 must be between 1 and 255.");
        }

        if (T3 < 1 || T3 > 172800)
        {
            return ValidationResult.Error("--t3 must be between 1 and 172800.");
        }

        if (IncrementalTimeout < 10)
        {
            return ValidationResult.Error("--incremental-timeout must be at least 10.");
        }

        if (FirstCharWait < 0 || FirstCharWait > 65535)
        {
            return ValidationResult.Error("--first-char-wait must be between 0 and 65535.");
        }

        return ValidationResult.Success();
    }
}