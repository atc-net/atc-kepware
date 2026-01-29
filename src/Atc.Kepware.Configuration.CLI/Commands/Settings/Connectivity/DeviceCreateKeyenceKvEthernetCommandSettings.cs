namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateKeyenceKvEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--device-id <DEVICE-ID>")]
    [Description("Device ID (IP address of the Keyence KV PLC)")]
    public string DeviceId { get; init; } = string.Empty;

    [CommandOption("--ip-protocol")]
    [Description("IP protocol to use (TcpIp or Udp, default TcpIp)")]
    public FlagValue<KeyenceKvEthernetIpProtocolType>? IpProtocol { get; init; }

    [CommandOption("--port-number")]
    [Description("Port number for device (1-65535, default 8501)")]
    [DefaultValue(8501)]
    public int PortNumber { get; init; }

    [CommandOption("--connect-timeout-seconds")]
    [Description("Connection timeout in seconds (1-30, default 3)")]
    [DefaultValue(3)]
    public int ConnectTimeoutSeconds { get; init; }

    [CommandOption("--request-timeout-ms")]
    [Description("Request timeout in milliseconds (50-9999999, default 1000)")]
    [DefaultValue(1000)]
    public int RequestTimeoutMs { get; init; }

    [CommandOption("--retry-attempts")]
    [Description("Number of retry attempts (1-10, default 3)")]
    [DefaultValue(3)]
    public int RetryAttempts { get; init; }

    [CommandOption("--word-memory-block-size")]
    [Description("Block size for Word memory registers (1-1000, default 1000)")]
    [DefaultValue(1000)]
    public int WordMemoryBlockSize { get; init; }

    [CommandOption("--timer-counter-memory-block-size")]
    [Description("Block size for Timer/Counter memory registers (1-120, default 120)")]
    [DefaultValue(120)]
    public int TimerCounterMemoryBlockSize { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (string.IsNullOrEmpty(DeviceId))
        {
            return ValidationResult.Error("--device-id is required.");
        }

        if (PortNumber < 1 || PortNumber > 65535)
        {
            return ValidationResult.Error("--port-number must be between 1 and 65535.");
        }

        if (ConnectTimeoutSeconds < 1 || ConnectTimeoutSeconds > 30)
        {
            return ValidationResult.Error("--connect-timeout-seconds must be between 1 and 30.");
        }

        if (RequestTimeoutMs < 50 || RequestTimeoutMs > 9999999)
        {
            return ValidationResult.Error("--request-timeout-ms must be between 50 and 9999999.");
        }

        if (RetryAttempts < 1 || RetryAttempts > 10)
        {
            return ValidationResult.Error("--retry-attempts must be between 1 and 10.");
        }

        if (WordMemoryBlockSize < 1 || WordMemoryBlockSize > 1000)
        {
            return ValidationResult.Error("--word-memory-block-size must be between 1 and 1000.");
        }

        if (TimerCounterMemoryBlockSize < 1 || TimerCounterMemoryBlockSize > 120)
        {
            return ValidationResult.Error("--timer-counter-memory-block-size must be between 1 and 120.");
        }

        return ValidationResult.Success();
    }
}