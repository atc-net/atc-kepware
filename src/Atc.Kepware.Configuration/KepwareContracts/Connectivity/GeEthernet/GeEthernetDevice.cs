namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.GeEthernet;

/// <summary>
/// GE Ethernet device - Kepware format.
/// </summary>
internal sealed class GeEthernetDevice : DeviceBase, IGeEthernetDevice
{
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public GeEthernetModel Model { get; set; } = GeEthernetModel.PacSystems;

    [JsonPropertyName("ge_ethernet.DEVICE_PORT_NUMBER")]
    public int PortNumber { get; set; }

    [JsonPropertyName("ge_ethernet.DEVICE_MAX_BYTES_PER_REQUEST")]
    public GeEthernetMaxBytesPerRequest MaxBytesPerRequest { get; set; }

    [JsonPropertyName("ge_ethernet.DEVICE_VARIABLE_IMPORT_FILE")]
    public string VariableImportFile { get; set; } = string.Empty;

    [JsonPropertyName("ge_ethernet.DEVICE_DISPLAY_DESCRIPTIONS")]
    public bool DisplayDescriptions { get; set; }

    [JsonPropertyName("ge_ethernet.DEVICE_USE_ALIAS_DATA_TYPE_IF_POSSIBLE")]
    public bool UseAliasDataTypeIfPossible { get; set; }

    [JsonPropertyName("ge_ethernet.DEVICE_PROGRAM_NAME")]
    public string ProgramName { get; set; } = string.Empty;

    [JsonPropertyName("ge_ethernet.DEVICE_CPU_SLOT_LOCATION")]
    public int CpuSlotLocation { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}";
}
