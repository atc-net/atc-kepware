namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.ModbusTcpIpEthernet;

/// <summary>
/// Device request properties for the Modbus TCP/IP Ethernet driver.
/// </summary>
internal class ModbusTcpIpEthernetDeviceRequest : DeviceRequestBase, IModbusTcpIpEthernetDeviceRequest
{
    public ModbusTcpIpEthernetDeviceRequest()
        : base(DriverType.ModbusTcpIpEthernet)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public ModbusDeviceModelType Model { get; set; } = ModbusDeviceModelType.Modbus;

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_ID_FORMAT")]
    public ModbusDeviceIdFormatType IdFormat { get; set; } = ModbusDeviceIdFormatType.Decimal;

    /// <inheritdoc />
    [Required]
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = string.Empty;

    /// <inheritdoc />
    [Range(1, 30)]
    [JsonPropertyName("servermain.DEVICE_CONNECTION_TIMEOUT_SECONDS")]
    public int ConnectTimeoutSeconds { get; set; } = 3;

    /// <inheritdoc />
    [Range(10, 9999999)]
    [JsonPropertyName("servermain.DEVICE_REQUEST_TIMEOUT_MILLISECONDS")]
    public int RequestTimeoutMs { get; set; } = 1000;

    /// <inheritdoc />
    [Range(1, 10)]
    [JsonPropertyName("servermain.DEVICE_RETRY_ATTEMPTS")]
    public int RetryAttempts { get; set; } = 3;

    /// <inheritdoc />
    [Range(0, 30000)]
    [JsonPropertyName("servermain.DEVICE_INTER_REQUEST_DELAY_MILLISECONDS")]
    public int InterRequestDelayMs { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_ENABLE_ON_COMMUNICATIONS_FAILURES")]
    public bool DemoteOnFailure { get; set; }

    /// <inheritdoc />
    [Range(1, 30)]
    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DEMOTE_AFTER_SUCCESSIVE_TIMEOUTS")]
    public int TimeoutsToDemote { get; set; } = 3;

    /// <inheritdoc />
    [Range(100, 3600000)]
    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_PERIOD_MS")]
    public int DemotionPeriodMs { get; set; } = 10000;

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DISCARD_WRITES")]
    public bool DiscardRequestsWhenDemoted { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_ON_STARTUP")]
    public ModbusDeviceTagGenerationOnStartupType TagGenerationOnStartup { get; set; } = ModbusDeviceTagGenerationOnStartupType.DoNotGenerateOnStartup;

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_DUPLICATE_HANDLING")]
    public ModbusDeviceTagGenerationDuplicateHandlingType TagGenerationDuplicateHandling { get; set; } = ModbusDeviceTagGenerationDuplicateHandlingType.DeleteOnCreate;

    /// <inheritdoc />
    [MaxLength(256)]
    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_GROUP")]
    public string? TagGenerationGroup { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_TAG_GENERATION_ALLOW_SUB_GROUPS")]
    public bool AllowAutomaticallyGeneratedSubgroups { get; set; } = true;

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("modbus_ethernet.DEVICE_ETHERNET_PORT_NUMBER")]
    public int Port { get; set; } = 502;

    /// <inheritdoc />
    [JsonPropertyName("modbus_ethernet.DEVICE_ETHERNET_IP_PROTOCOL")]
    public ModbusDeviceIpProtocolType IpProtocol { get; set; } = ModbusDeviceIpProtocolType.TcpIp;

    /// <inheritdoc />
    [JsonPropertyName("modbus_ethernet.DEVICE_ETHERNET_CLOSE_TCP_SOCKET_ON_TIMEOUT")]
    public bool CloseSocketOnTimeout { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("modbus_ethernet.DEVICE_ZERO_BASED_ADDRESSING")]
    public bool ZeroBasedAddressing { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("modbus_ethernet.DEVICE_ZERO_BASED_BIT_ADDRESSING")]
    public bool ZeroBasedBitAddressing { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("modbus_ethernet.DEVICE_HOLDING_REGISTER_BIT_MASK_WRITES")]
    public bool HoldingRegisterBitMaskWrites { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("modbus_ethernet.DEVICE_MODBUS_FUNCTION_06")]
    public bool ModbusFunction06 { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("modbus_ethernet.DEVICE_MODBUS_FUNCTION_05")]
    public bool ModbusFunction05 { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("modbus_ethernet.DEVICE_MODBUS_BYTE_ORDER")]
    public bool ModbusByteOrder { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("modbus_ethernet.DEVICE_FIRST_WORD_LOW")]
    public bool FirstWordLow { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("modbus_ethernet.DEVICE_FIRST_DWORD_LOW")]
    public bool FirstDWordLow { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("modbus_ethernet.DEVICE_MODICON_BIT_ORDER")]
    public bool ModiconBitOrder { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("modbus_ethernet.DEVICE_TREAT_LONGS_AS_DOUBLE_PRECISION_UNSIGNED_DECIMAL")]
    public bool TreatLongsAsDoubleDecimal { get; set; }

    /// <inheritdoc />
    [Range(8, 2000)]
    [JsonPropertyName("modbus_ethernet.DEVICE_OUTPUT_COILS")]
    public int OutputCoilsBlockSize { get; set; } = 32;

    /// <inheritdoc />
    [Range(8, 2000)]
    [JsonPropertyName("modbus_ethernet.DEVICE_INPUT_COILS")]
    public int InputCoilsBlockSize { get; set; } = 32;

    /// <inheritdoc />
    [Range(1, 120)]
    [JsonPropertyName("modbus_ethernet.DEVICE_INTERNAL_REGISTERS")]
    public int InternalRegistersBlockSize { get; set; } = 32;

    /// <inheritdoc />
    [Range(1, 120)]
    [JsonPropertyName("modbus_ethernet.DEVICE_HOLDING_REGISTERS")]
    public int HoldingRegistersBlockSize { get; set; } = 32;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(IdFormat)}: {IdFormat}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}, {nameof(IpProtocol)}: {IpProtocol}";
}