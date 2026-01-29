namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.GeEthernet;

/// <summary>
/// GE Ethernet device request.
/// </summary>
internal sealed class GeEthernetDeviceRequest : DeviceRequestBase, IGeEthernetDeviceRequest
{
    public GeEthernetDeviceRequest()
        : base(DriverType.GeEthernet)
    {
    }

    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public GeEthernetModel Model { get; set; } = GeEthernetModel.PacSystems;

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("ge_ethernet.DEVICE_PORT_NUMBER")]
    public int PortNumber { get; set; } = 18245;

    /// <inheritdoc />
    [JsonPropertyName("ge_ethernet.DEVICE_MAX_BYTES_PER_REQUEST")]
    public GeEthernetMaxBytesPerRequest MaxBytesPerRequest { get; set; } = GeEthernetMaxBytesPerRequest.Bytes2048;

    /// <inheritdoc />
    [MaxLength(256)]
    [JsonPropertyName("ge_ethernet.DEVICE_VARIABLE_IMPORT_FILE")]
    public string VariableImportFile { get; set; } = "*.snf";

    /// <inheritdoc />
    [JsonPropertyName("ge_ethernet.DEVICE_DISPLAY_DESCRIPTIONS")]
    public bool DisplayDescriptions { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("ge_ethernet.DEVICE_USE_ALIAS_DATA_TYPE_IF_POSSIBLE")]
    public bool UseAliasDataTypeIfPossible { get; set; }

    /// <inheritdoc />
    [MaxLength(7)]
    [JsonPropertyName("ge_ethernet.DEVICE_PROGRAM_NAME")]
    public string ProgramName { get; set; } = "PROGRAM";

    /// <inheritdoc />
    [Range(0, 15)]
    [JsonPropertyName("ge_ethernet.DEVICE_CPU_SLOT_LOCATION")]
    public int CpuSlotLocation { get; set; } = 1;

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}";
}