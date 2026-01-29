namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AllenBradleyControlLogixServerEthernet;

/// <summary>
/// Device request properties for the Allen-Bradley ControlLogix Server Ethernet driver.
/// </summary>
public sealed class AllenBradleyControlLogixServerEthernetDeviceRequest : DeviceRequestBase, IAllenBradleyControlLogixServerEthernetDeviceRequest
{
    public AllenBradleyControlLogixServerEthernetDeviceRequest()
        : base(DriverType.AllenBradleyControlLogixServerEthernet)
    {
    }

    /// <inheritdoc />
    public ControlLogixServerModuleType ModuleType { get; set; }

    /// <inheritdoc />
    public int CpuSlot { get; set; }

    /// <inheritdoc />
    public ControlLogixServerTagHierarchyType TagHierarchy { get; set; }

    /// <inheritdoc />
    public bool OpcQualityBadUntilWrite { get; set; }

    /// <inheritdoc />
    public bool PackStrings { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(ModuleType)}: {ModuleType}, {nameof(CpuSlot)}: {CpuSlot}, {nameof(TagHierarchy)}: {TagHierarchy}, {nameof(OpcQualityBadUntilWrite)}: {OpcQualityBadUntilWrite}, {nameof(PackStrings)}: {PackStrings}";
}