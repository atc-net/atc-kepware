namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateMitsubishiCncEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--first-word-low")]
    [Description("First word low for 32-bit data types")]
    [DefaultValue(true)]
    public bool FirstWordLow { get; init; } = true;

    [CommandOption("--port-number")]
    [Description("UDP port for the destination CNC (1-65535)")]
    [DefaultValue(5001)]
    public int PortNumber { get; init; } = 5001;

    [CommandOption("--source-network")]
    [Description("Network number on which the PC resides (1-239)")]
    [DefaultValue(1)]
    public int SourceNetwork { get; init; } = 1;

    [CommandOption("--source-station")]
    [Description("Station number assigned to the PC (1-239)")]
    [DefaultValue(1)]
    public int SourceStation { get; init; } = 1;

    [CommandOption("--destination-network")]
    [Description("Network number on which the CNC resides (0-239)")]
    [DefaultValue(1)]
    public int DestinationNetwork { get; init; } = 1;

    [CommandOption("--destination-station")]
    [Description("Station number assigned to CNC (0-239)")]
    [DefaultValue(2)]
    public int DestinationStation { get; init; } = 2;

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (PortNumber < 1 || PortNumber > 65535)
        {
            return ValidationResult.Error("--port-number must be between 1 and 65535.");
        }

        if (SourceNetwork < 1 || SourceNetwork > 239)
        {
            return ValidationResult.Error("--source-network must be between 1 and 239.");
        }

        if (SourceStation < 1 || SourceStation > 239)
        {
            return ValidationResult.Error("--source-station must be between 1 and 239.");
        }

        if (DestinationNetwork < 0 || DestinationNetwork > 239)
        {
            return ValidationResult.Error("--destination-network must be between 0 and 239.");
        }

        if (DestinationStation < 0 || DestinationStation > 239)
        {
            return ValidationResult.Error("--destination-station must be between 0 and 239.");
        }

        return ValidationResult.Success();
    }
}
