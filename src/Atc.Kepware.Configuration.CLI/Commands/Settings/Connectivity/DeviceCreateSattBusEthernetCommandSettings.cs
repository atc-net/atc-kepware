namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateSattBusEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--device-id <DEVICE-ID>")]
    [Description("Device IP address (e.g., 192.168.1.1)")]
    public string DeviceId { get; init; } = "255.255.255.255";

    [CommandOption("--port")]
    [Description("Port number (0-65535)")]
    [DefaultValue(2999)]
    public int PortNumber { get; init; } = 2999;

    [CommandOption("--ip-protocol")]
    [Description("IP protocol (Udp, TcpIp)")]
    [DefaultValue(SattBusEthernetIpProtocolType.Udp)]
    public SattBusEthernetIpProtocolType IpProtocol { get; init; } = SattBusEthernetIpProtocolType.Udp;

    [CommandOption("--overlapped-addressing")]
    [Description("Use overlapped addressing for double-words")]
    [DefaultValue(true)]
    public bool OverlappedAddressing { get; init; } = true;

    [CommandOption("--write-to-port")]
    [Description("Write to port number (0-65535)")]
    [DefaultValue(2999)]
    public int WriteToPort { get; init; } = 2999;

    [CommandOption("--bit-ordering")]
    [Description("Bit ordering for 16 bit memory cell tags (MsBit0To15, MsBit15To0, MsBit7To0Then15To8)")]
    [DefaultValue(SattBusEthernetBitOrderingType.MsBit15To0)]
    public SattBusEthernetBitOrderingType BitOrdering { get; init; } = SattBusEthernetBitOrderingType.MsBit15To0;

    [CommandOption("--register-block-size")]
    [Description("Register block size in bytes (Bytes20, Bytes32, Bytes64, Bytes128, Bytes255, Bytes510)")]
    [DefaultValue(SattBusEthernetRegisterBlockSizeType.Bytes20)]
    public SattBusEthernetRegisterBlockSizeType RegisterBlockSize { get; init; } = SattBusEthernetRegisterBlockSizeType.Bytes20;

    [CommandOption("--io-ram-memory-cell-block-size")]
    [Description("IO RAM/Memory cell block size in bytes (Bytes20, Bytes32, Bytes64, Bytes128, Bytes255)")]
    [DefaultValue(SattBusEthernetIoRamMemoryCellBlockSizeType.Bytes20)]
    public SattBusEthernetIoRamMemoryCellBlockSizeType IoRamMemoryCellBlockSize { get; init; } = SattBusEthernetIoRamMemoryCellBlockSizeType.Bytes20;

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

        if (PortNumber < 0 || PortNumber > 65535)
        {
            return ValidationResult.Error("--port must be between 0 and 65535.");
        }

        if (WriteToPort < 0 || WriteToPort > 65535)
        {
            return ValidationResult.Error("--write-to-port must be between 0 and 65535.");
        }

        return ValidationResult.Success();
    }
}