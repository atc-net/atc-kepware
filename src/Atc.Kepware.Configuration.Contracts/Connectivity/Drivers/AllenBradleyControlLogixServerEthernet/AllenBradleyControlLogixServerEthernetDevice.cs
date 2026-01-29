namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AllenBradleyControlLogixServerEthernet;

/// <summary>
/// Device properties for the Allen-Bradley ControlLogix Server Ethernet driver.
/// </summary>
public sealed class AllenBradleyControlLogixServerEthernetDevice : DeviceBase, IAllenBradleyControlLogixServerEthernetDevice
{
    /// <inheritdoc />
    public ControlLogixServerModuleType ModuleType { get; set; }

    /// <inheritdoc />
    public int CpuSlot { get; set; }

    /// <inheritdoc />
    public string? Path { get; set; }

    /// <inheritdoc />
    public ControlLogixServerTagHierarchyType TagHierarchy { get; set; }

    /// <inheritdoc />
    public bool OpcQualityBadUntilWrite { get; set; }

    /// <inheritdoc />
    public bool PackStrings { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(ModuleType)}: {ModuleType}, {nameof(CpuSlot)}: {CpuSlot}, {nameof(Path)}: {Path}, {nameof(TagHierarchy)}: {TagHierarchy}, {nameof(OpcQualityBadUntilWrite)}: {OpcQualityBadUntilWrite}, {nameof(PackStrings)}: {PackStrings}";
}