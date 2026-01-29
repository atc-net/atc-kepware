namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateAromatEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--device-id <DEVICE-ID>")]
    [Description("Device IP address (e.g., 192.168.1.1)")]
    public string DeviceId { get; init; } = "255.255.255.255";

    [CommandOption("--model [MODEL]")]
    [Description("Device model (FP)")]
    public FlagValue<AromatEthernetDeviceModelType>? Model { get; init; } = new();

    [CommandOption("--protocol [PROTOCOL]")]
    [Description("Protocol used by the device (Udp, TcpIp)")]
    public FlagValue<AromatEthernetProtocolType>? Protocol { get; init; } = new();

    [CommandOption("--open-method [OPEN-METHOD]")]
    [Description("Open method for TCP/IP (FullPassive, Unpassive)")]
    public FlagValue<AromatEthernetOpenMethodType>? OpenMethod { get; init; } = new();

    [CommandOption("--source-port")]
    [Description("Port the driver uses to send/receive (0-65535)")]
    [DefaultValue(1025)]
    public int SourcePort { get; init; } = 1025;

    [CommandOption("--destination-port")]
    [Description("Port on the ET-LAN for messages (0-65535)")]
    [DefaultValue(1025)]
    public int DestinationPort { get; init; } = 1025;

    [CommandOption("--source-station")]
    [Description("Source station number (1-64)")]
    [DefaultValue(1)]
    public int SourceStation { get; init; } = 1;

    [CommandOption("--destination-station")]
    [Description("Target device's station number (1-64)")]
    [DefaultValue(1)]
    public int DestinationStation { get; init; } = 1;

    [CommandOption("--request-size [REQUEST-SIZE]")]
    [Description("Request size in bytes (Bytes32, Bytes64, Bytes128, Bytes256, Bytes512)")]
    public FlagValue<AromatEthernetRequestSizeType>? RequestSize { get; init; } = new();

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

        if (SourcePort < 0 || SourcePort > 65535)
        {
            return ValidationResult.Error("--source-port must be between 0 and 65535.");
        }

        if (DestinationPort < 0 || DestinationPort > 65535)
        {
            return ValidationResult.Error("--destination-port must be between 0 and 65535.");
        }

        if (SourceStation < 1 || SourceStation > 64)
        {
            return ValidationResult.Error("--source-station must be between 1 and 64.");
        }

        if (DestinationStation < 1 || DestinationStation > 64)
        {
            return ValidationResult.Error("--destination-station must be between 1 and 64.");
        }

        return ValidationResult.Success();
    }
}