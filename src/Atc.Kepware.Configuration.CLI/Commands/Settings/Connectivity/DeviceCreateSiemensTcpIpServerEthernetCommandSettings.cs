namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateSiemensTcpIpServerEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--rack-number")]
    [Description("Rack number where the simulated CPU resides (0-7)")]
    [DefaultValue(0)]
    public int RackNumber { get; init; }

    [CommandOption("--cpu-slot")]
    [Description("Slot number where the simulated CPU resides (0-31)")]
    [DefaultValue(0)]
    public int CpuSlot { get; init; }

    [CommandOption("--max-pdu-size")]
    [Description("Maximum PDU size in bytes")]
    [DefaultValue(SiemensTcpIpServerMaxPduSize.Pdu960)]
    public SiemensTcpIpServerMaxPduSize MaxPduSize { get; init; } = SiemensTcpIpServerMaxPduSize.Pdu960;

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (RackNumber < 0 || RackNumber > 7)
        {
            return ValidationResult.Error("--rack-number must be between 0 and 7.");
        }

        if (CpuSlot < 0 || CpuSlot > 31)
        {
            return ValidationResult.Error("--cpu-slot must be between 0 and 31.");
        }

        return ValidationResult.Success();
    }
}