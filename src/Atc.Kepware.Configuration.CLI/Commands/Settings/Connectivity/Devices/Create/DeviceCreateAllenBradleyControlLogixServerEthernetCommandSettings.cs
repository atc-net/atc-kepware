namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Devices.Create;

public class DeviceCreateAllenBradleyControlLogixServerEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--module-type")]
    [Description("Controller module type (Local or Remote)")]
    [DefaultValue(ControlLogixServerModuleType.Local)]
    public ControlLogixServerModuleType ModuleType { get; init; }

    [CommandOption("--cpu-slot")]
    [Description("CPU slot for remote controller module (0-15)")]
    [DefaultValue(0)]
    public int CpuSlot { get; init; }

    [CommandOption("--tag-hierarchy")]
    [Description("Tag hierarchy grouping (Expanded or Condensed)")]
    [DefaultValue(ControlLogixServerTagHierarchyType.Expanded)]
    public ControlLogixServerTagHierarchyType TagHierarchy { get; init; }

    [CommandOption("--opc-quality-bad-until-write")]
    [Description("Display tags as bad quality until first write")]
    [DefaultValue(false)]
    public bool OpcQualityBadUntilWrite { get; init; }

    [CommandOption("--pack-strings")]
    [Description("Enable if byte array elements may be in packed format")]
    [DefaultValue(false)]
    public bool PackStrings { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (CpuSlot < 0 || CpuSlot > 15)
        {
            return ValidationResult.Error("--cpu-slot must be between 0 and 15.");
        }

        return ValidationResult.Success();
    }
}