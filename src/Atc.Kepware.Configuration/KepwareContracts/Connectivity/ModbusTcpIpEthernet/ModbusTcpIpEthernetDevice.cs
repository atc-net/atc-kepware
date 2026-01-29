namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.ModbusTcpIpEthernet;

/// <summary>
/// Device properties for the Modbus TCP/IP Ethernet driver.
/// </summary>
internal class ModbusTcpIpEthernetDevice : DeviceBase, IModbusTcpIpEthernetDevice
{
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public ModbusDeviceModelType Model { get; set; }

    [JsonPropertyName("servermain.DEVICE_ID_FORMAT")]
    public ModbusDeviceIdFormatType IdFormat { get; set; }

    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = string.Empty;

    [JsonPropertyName("servermain.DEVICE_CONNECTION_TIMEOUT_SECONDS")]
    public int ConnectTimeoutSeconds { get; set; }

    [JsonPropertyName("servermain.DEVICE_REQUEST_TIMEOUT_MILLISECONDS")]
    public int RequestTimeoutMs { get; set; }

    [JsonPropertyName("servermain.DEVICE_RETRY_ATTEMPTS")]
    public int RetryAttempts { get; set; }

    [JsonPropertyName("servermain.DEVICE_INTER_REQUEST_DELAY_MILLISECONDS")]
    public int InterRequestDelayMs { get; set; }

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_ENABLE_ON_COMMUNICATIONS_FAILURES")]
    public bool DemoteOnFailure { get; set; }

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DEMOTE_AFTER_SUCCESSIVE_TIMEOUTS")]
    public int TimeoutsToDemote { get; set; }

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_PERIOD_MS")]
    public int DemotionPeriodMs { get; set; }

    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DISCARD_WRITES")]
    public bool DiscardRequestsWhenDemoted { get; set; }

    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_ON_STARTUP")]
    public ModbusDeviceTagGenerationOnStartupType TagGenerationOnStartup { get; set; }

    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_DUPLICATE_HANDLING")]
    public ModbusDeviceTagGenerationDuplicateHandlingType TagGenerationDuplicateHandling { get; set; }

    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_GROUP")]
    public string? TagGenerationGroup { get; set; }

    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_ALLOW_SUB_GROUPS")]
    public bool AllowAutomaticallyGeneratedSubgroups { get; set; }

    [JsonPropertyName("modbus_ethernet.DEVICE_ETHERNET_PORT_NUMBER")]
    public int Port { get; set; }

    [JsonPropertyName("modbus_ethernet.DEVICE_ETHERNET_IP_PROTOCOL")]
    public ModbusDeviceIpProtocolType IpProtocol { get; set; }

    [JsonPropertyName("modbus_ethernet.DEVICE_ETHERNET_CLOSE_TCP_SOCKET_ON_TIMEOUT")]
    public bool CloseSocketOnTimeout { get; set; }

    [JsonPropertyName("modbus_ethernet.DEVICE_ZERO_BASED_ADDRESSING")]
    public bool ZeroBasedAddressing { get; set; }

    [JsonPropertyName("modbus_ethernet.DEVICE_ZERO_BASED_BIT_ADDRESSING")]
    public bool ZeroBasedBitAddressing { get; set; }

    [JsonPropertyName("modbus_ethernet.DEVICE_HOLDING_REGISTER_BIT_MASK_WRITES")]
    public bool HoldingRegisterBitMaskWrites { get; set; }

    [JsonPropertyName("modbus_ethernet.DEVICE_MODBUS_FUNCTION_06")]
    public bool ModbusFunction06 { get; set; }

    [JsonPropertyName("modbus_ethernet.DEVICE_MODBUS_FUNCTION_05")]
    public bool ModbusFunction05 { get; set; }

    [JsonPropertyName("modbus_ethernet.DEVICE_MODBUS_BYTE_ORDER")]
    public bool ModbusByteOrder { get; set; }

    [JsonPropertyName("modbus_ethernet.DEVICE_FIRST_WORD_LOW")]
    public bool FirstWordLow { get; set; }

    [JsonPropertyName("modbus_ethernet.DEVICE_FIRST_DWORD_LOW")]
    public bool FirstDWordLow { get; set; }

    [JsonPropertyName("modbus_ethernet.DEVICE_MODICON_BIT_ORDER")]
    public bool ModiconBitOrder { get; set; }

    [JsonPropertyName("modbus_ethernet.DEVICE_TREAT_LONGS_AS_DOUBLE_PRECISION_UNSIGNED_DECIMAL")]
    public bool TreatLongsAsDoubleDecimal { get; set; }

    [JsonPropertyName("modbus_ethernet.DEVICE_OUTPUT_COILS")]
    public int OutputCoilsBlockSize { get; set; }

    [JsonPropertyName("modbus_ethernet.DEVICE_INPUT_COILS")]
    public int InputCoilsBlockSize { get; set; }

    [JsonPropertyName("modbus_ethernet.DEVICE_INTERNAL_REGISTERS")]
    public int InternalRegistersBlockSize { get; set; }

    [JsonPropertyName("modbus_ethernet.DEVICE_HOLDING_REGISTERS")]
    public int HoldingRegistersBlockSize { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(IdFormat)}: {IdFormat}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}, {nameof(IpProtocol)}: {IpProtocol}";
}