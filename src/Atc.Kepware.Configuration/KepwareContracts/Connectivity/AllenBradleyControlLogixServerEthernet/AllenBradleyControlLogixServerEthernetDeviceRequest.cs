namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AllenBradleyControlLogixServerEthernet;

/// <summary>
/// Device request properties for the Allen-Bradley ControlLogix Server Ethernet driver.
/// </summary>
internal sealed class AllenBradleyControlLogixServerEthernetDeviceRequest : DeviceRequestBase, IAllenBradleyControlLogixServerEthernetDeviceRequest
{
    public AllenBradleyControlLogixServerEthernetDeviceRequest()
        : base(DriverType.AllenBradleyControlLogixServerEthernet)
    {
    }

    [JsonPropertyName("controllogix_unsolicited_ethernet.DEVICE_MODULE_TYPE")]
    public ControlLogixServerModuleType ModuleType { get; set; } = ControlLogixServerModuleType.Local;

    [JsonPropertyName("controllogix_unsolicited_ethernet.DEVICE_CPU_SLOT")]
    public int CpuSlot { get; set; }

    [JsonPropertyName("controllogix_unsolicited_ethernet.DEVICE_TAG_HIERARCHY")]
    public ControlLogixServerTagHierarchyType TagHierarchy { get; set; } = ControlLogixServerTagHierarchyType.Expanded;

    [JsonPropertyName("controllogix_unsolicited_ethernet.DEVICE_OPC_QUALITY_BAD_UNTIL_WRITE")]
    public bool OpcQualityBadUntilWrite { get; set; }

    [JsonPropertyName("controllogix_unsolicited_ethernet.DEVICE_PACK_STRINGS")]
    public bool PackStrings { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(ModuleType)}: {ModuleType}, {nameof(CpuSlot)}: {CpuSlot}, {nameof(TagHierarchy)}: {TagHierarchy}, {nameof(OpcQualityBadUntilWrite)}: {OpcQualityBadUntilWrite}, {nameof(PackStrings)}: {PackStrings}";
}
