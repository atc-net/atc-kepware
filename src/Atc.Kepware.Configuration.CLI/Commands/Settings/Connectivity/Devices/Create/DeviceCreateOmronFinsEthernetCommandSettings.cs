namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Devices.Create;

public class DeviceCreateOmronFinsEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--device-id <DEVICE-ID>")]
    [Description("Device IP address")]
    public string DeviceId { get; init; } = "255.255.255.255";

    [CommandOption("--model [MODEL]")]
    [Description("Device model (C200, C500, C1000, C2000, CV500, CV1000, CV2000, Cvm1Cpu01, Cvm1Cpu11, Cvm1Cpu21, CS1, CJ1, CJ2)")]
    public FlagValue<OmronFinsEthernetDeviceModelType>? Model { get; init; } = new();

    [CommandOption("--source-network-address")]
    [Description("Source network address (0-127)")]
    [DefaultValue(0)]
    public int SourceNetworkAddress { get; init; }

    [CommandOption("--source-node")]
    [Description("Source node number (0-254)")]
    [DefaultValue(0)]
    public int SourceNode { get; init; }

    [CommandOption("--destination-network-address")]
    [Description("Destination network address (0-127)")]
    [DefaultValue(0)]
    public int DestinationNetworkAddress { get; init; }

    [CommandOption("--destination-node")]
    [Description("Destination node number (0-254)")]
    [DefaultValue(0)]
    public int DestinationNode { get; init; }

    [CommandOption("--destination-unit")]
    [Description("Destination unit number (0-255)")]
    [DefaultValue(0)]
    public int DestinationUnit { get; init; }

    [CommandOption("--cs-ts-writes-mode [CS-TS-WRITES-MODE]")]
    [Description("CS and TS writes mode (FailWriteLogMessage, SetPlcToMonitorModePerformWrite, SetPlcToMonitorModeWriteResetToRun)")]
    public FlagValue<OmronFinsEthernetCsTsWritesModeType>? CsTsWritesMode { get; init; } = new();

    [CommandOption("--request-size [REQUEST-SIZE]")]
    [Description("Request size in bytes (Bytes32, Bytes64, Bytes128, Bytes256, Bytes512, Bytes1024, Bytes1984)")]
    public FlagValue<OmronFinsEthernetRequestSizeType>? RequestSize { get; init; } = new();

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

        if (SourceNetworkAddress < 0 || SourceNetworkAddress > 127)
        {
            return ValidationResult.Error("--source-network-address must be between 0 and 127.");
        }

        if (SourceNode < 0 || SourceNode > 254)
        {
            return ValidationResult.Error("--source-node must be between 0 and 254.");
        }

        if (DestinationNetworkAddress < 0 || DestinationNetworkAddress > 127)
        {
            return ValidationResult.Error("--destination-network-address must be between 0 and 127.");
        }

        if (DestinationNode < 0 || DestinationNode > 254)
        {
            return ValidationResult.Error("--destination-node must be between 0 and 254.");
        }

        if (DestinationUnit < 0 || DestinationUnit > 255)
        {
            return ValidationResult.Error("--destination-unit must be between 0 and 255.");
        }

        return ValidationResult.Success();
    }
}