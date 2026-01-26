namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateModbusTcpIpEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--device-id <DEVICE-ID>")]
    [Description("Device ID (Modbus station address)")]
    public string DeviceId { get; init; } = string.Empty;

    [CommandOption("--model [MODEL]")]
    [Description("Device model (Modbus, Mailbox, Instromet, RoxarRfm, FluentaFgm, Applicom, Ceg)")]
    public FlagValue<ModbusDeviceModelType>? Model { get; init; } = new();

    [CommandOption("--id-format [ID-FORMAT]")]
    [Description("Device ID format (Octal, Decimal, Hex)")]
    public FlagValue<ModbusDeviceIdFormatType>? IdFormat { get; init; } = new();

    [CommandOption("--port")]
    [Description("Port number for device")]
    [DefaultValue(502)]
    public int Port { get; init; }

    [CommandOption("--ip-protocol [IP-PROTOCOL]")]
    [Description("IP Protocol for device (TcpIp, Udp)")]
    public FlagValue<ModbusDeviceIpProtocolType>? IpProtocol { get; init; } = new();

    [CommandOption("--connect-timeout-seconds")]
    [Description("Connection timeout in seconds (1-30)")]
    [DefaultValue(3)]
    public int ConnectTimeoutSeconds { get; init; }

    [CommandOption("--request-timeout-ms")]
    [Description("Request timeout in milliseconds (10-9999999)")]
    [DefaultValue(1000)]
    public int RequestTimeoutMs { get; init; }

    [CommandOption("--retry-attempts")]
    [Description("Number of retry attempts (1-10)")]
    [DefaultValue(3)]
    public int RetryAttempts { get; init; }

    [CommandOption("--zero-based-addressing")]
    [Description("Use zero-based addressing")]
    [DefaultValue(true)]
    public bool ZeroBasedAddressing { get; init; }

    [CommandOption("--zero-based-bit-addressing")]
    [Description("Use zero-based bit addressing")]
    [DefaultValue(true)]
    public bool ZeroBasedBitAddressing { get; init; }

    [CommandOption("--modbus-byte-order")]
    [Description("Use Modbus byte order (big-endian)")]
    [DefaultValue(true)]
    public bool ModbusByteOrder { get; init; }

    [CommandOption("--first-word-low")]
    [Description("First word low in 32-bit values")]
    [DefaultValue(true)]
    public bool FirstWordLow { get; init; }

    [CommandOption("--first-dword-low")]
    [Description("First double-word low in 64-bit values")]
    [DefaultValue(true)]
    public bool FirstDWordLow { get; init; }

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

        if (Port < 0 || Port > 65535)
        {
            return ValidationResult.Error("--port must be between 0 and 65535.");
        }

        if (ConnectTimeoutSeconds < 1 || ConnectTimeoutSeconds > 30)
        {
            return ValidationResult.Error("--connect-timeout-seconds must be between 1 and 30.");
        }

        if (RequestTimeoutMs < 10 || RequestTimeoutMs > 9999999)
        {
            return ValidationResult.Error("--request-timeout-ms must be between 10 and 9999999.");
        }

        if (RetryAttempts < 1 || RetryAttempts > 10)
        {
            return ValidationResult.Error("--retry-attempts must be between 1 and 10.");
        }

        return ValidationResult.Success();
    }
}
