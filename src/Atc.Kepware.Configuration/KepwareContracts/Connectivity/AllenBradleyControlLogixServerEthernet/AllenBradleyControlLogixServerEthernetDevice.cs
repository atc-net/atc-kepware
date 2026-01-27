namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AllenBradleyControlLogixServerEthernet;

/// <summary>
/// Device properties for the Allen-Bradley ControlLogix Server Ethernet driver.
/// </summary>
internal sealed class AllenBradleyControlLogixServerEthernetDevice : DeviceBase, IAllenBradleyControlLogixServerEthernetDevice
{
    [JsonPropertyName("controllogix_unsolicited_ethernet.DEVICE_MODULE_TYPE")]
    public ControlLogixServerModuleType ModuleType { get; set; }

    [JsonPropertyName("controllogix_unsolicited_ethernet.DEVICE_CPU_SLOT")]
    public int CpuSlot { get; set; }

    [JsonPropertyName("controllogix_unsolicited_ethernet.DEVICE_PATH")]
    public string? Path { get; set; }

    [JsonPropertyName("controllogix_unsolicited_ethernet.DEVICE_TAG_HIERARCHY")]
    public ControlLogixServerTagHierarchyType TagHierarchy { get; set; }

    [JsonPropertyName("controllogix_unsolicited_ethernet.DEVICE_OPC_QUALITY_BAD_UNTIL_WRITE")]
    public bool OpcQualityBadUntilWrite { get; set; }

    [JsonPropertyName("controllogix_unsolicited_ethernet.DEVICE_PACK_STRINGS")]
    public bool PackStrings { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(ModuleType)}: {ModuleType}, {nameof(CpuSlot)}: {CpuSlot}, {nameof(Path)}: {Path}, {nameof(TagHierarchy)}: {TagHierarchy}, {nameof(OpcQualityBadUntilWrite)}: {OpcQualityBadUntilWrite}, {nameof(PackStrings)}: {PackStrings}";
}
