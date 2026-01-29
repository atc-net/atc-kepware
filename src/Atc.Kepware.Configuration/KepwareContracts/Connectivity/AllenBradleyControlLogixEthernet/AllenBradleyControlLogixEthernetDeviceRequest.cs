namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AllenBradleyControlLogixEthernet;

/// <summary>
/// Device request properties for the Allen-Bradley ControlLogix Ethernet driver.
/// </summary>
internal sealed class AllenBradleyControlLogixEthernetDeviceRequest : DeviceRequestBase, IAllenBradleyControlLogixEthernetDeviceRequest
{
    public AllenBradleyControlLogixEthernetDeviceRequest()
        : base(DriverType.AllenBradleyControlLogixEthernet)
    {
    }

    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public ControlLogixDeviceModelType Model { get; set; } = ControlLogixDeviceModelType.ControlLogix5500;

    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = string.Empty;

    [JsonPropertyName("controllogix_ethernet.DEVICE_PORT_NUMBER")]
    public int Port { get; set; } = 44818;

    [JsonPropertyName("controllogix_ethernet.DEVICE_CONNECTION_SIZE_BYTES")]
    public int ConnectionSizeBytes { get; set; } = 500;

    [JsonPropertyName("controllogix_ethernet.DEVICE_INACTIVITY_WATCHDOG_SECONDS")]
    public ControlLogixInactivityWatchdogType InactivityWatchdog { get; set; } = ControlLogixInactivityWatchdogType.Seconds32;

    [JsonPropertyName("controllogix_ethernet.DEVICE_ARRAY_BLOCK_SIZE_ELEMENTS")]
    public ControlLogixArrayBlockSizeType ArrayBlockSize { get; set; } = ControlLogixArrayBlockSizeType.Elements120;

    [JsonPropertyName("controllogix_ethernet.DEVICE_PROTOCOL_MODE")]
    public ControlLogixProtocolModeType ProtocolMode { get; set; } = ControlLogixProtocolModeType.LogicalNonBlocking;

    [JsonPropertyName("controllogix_ethernet.DEVICE_ONLINE_EDITS")]
    public bool SynchronizeAfterOnlineEdits { get; set; } = true;

    [JsonPropertyName("controllogix_ethernet.DEVICE_OFFLINE_EDITS")]
    public bool SynchronizeAfterOfflineEdits { get; set; } = true;

    [JsonPropertyName("controllogix_ethernet.DEVICE_AUTOMATICALLY_READ_STRING_LENGTH")]
    public bool TerminateStringDataAtLen { get; set; } = true;

    [JsonPropertyName("controllogix_ethernet.DEVICE_DEFAULT_DATA_TYPE")]
    public ControlLogixDefaultDataType DefaultDataType { get; set; } = ControlLogixDefaultDataType.Default;

    [JsonPropertyName("controllogix_ethernet.DEVICE_ENABLE_PERFORMANCE_STATISTICS")]
    public bool PerformanceStatistics { get; set; }

    [JsonPropertyName("controllogix_ethernet.DEVICE_DATABASE_IMPORT_METHOD")]
    public ControlLogixDatabaseImportMethodType DatabaseImportMethod { get; set; } = ControlLogixDatabaseImportMethodType.CreateFromDevice;

    [JsonPropertyName("controllogix_ethernet.DEVICE_TAG_IMPORT_FILE")]
    public string? TagImportFile { get; set; }

    [JsonPropertyName("controllogix_ethernet.DEVICE_DISPLAY_DESCRIPTIONS")]
    public bool TagDescriptions { get; set; } = true;

    [JsonPropertyName("controllogix_ethernet.DEVICE_LIMIT_TAG_NAMES")]
    public bool LimitNameLength { get; set; }

    [JsonPropertyName("controllogix_ethernet.DEVICE_TAG_HIERARCHY")]
    public ControlLogixTagHierarchyType TagHierarchy { get; set; } = ControlLogixTagHierarchyType.Expanded;

    [JsonPropertyName("controllogix_ethernet.DEVICE_IMPOSE_ARRAY_ELEMENT_COUNT_LIMIT")]
    public bool ImposeArrayLimit { get; set; }

    [JsonPropertyName("controllogix_ethernet.DEVICE_ARRAY_ELEMENT_COUNT_LIMIT")]
    public int ArrayCountUpperLimit { get; set; } = 2000;

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}