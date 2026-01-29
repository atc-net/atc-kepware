namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.Codesys;

/// <summary>
/// Device request properties for the CODESYS driver.
/// </summary>
internal class CodesysDeviceRequest : DeviceRequestBase, ICodesysDeviceRequest
{
    public CodesysDeviceRequest()
        : base(DriverType.Codesys)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public CodesysDeviceModelType Model { get; set; } = CodesysDeviceModelType.CodesysV23Ethernet;

    /// <inheritdoc />
    [JsonPropertyName("CODESYS.DEVICE_ADDRESS_TYPE")]
    public CodesysDeviceAddressType? AddressType { get; set; }

    /// <inheritdoc />
    [Required]
    [MaxLength(254)]
    [JsonPropertyName("CODESYS.DEVICE_IP_ADDRESS")]
    public string IpAddress { get; set; } = string.Empty;

    /// <inheritdoc />
    [MaxLength(255)]
    [JsonPropertyName("CODESYS.DEVICE_LOGICAL_ADDRESS")]
    public string? LogicalAddress { get; set; }

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("CODESYS.DEVICE_PORT_NUMBER")]
    public int Port { get; set; } = 1200;

    /// <inheritdoc />
    [JsonPropertyName("CODESYS.DEVICE_PROTOCOL")]
    public CodesysDeviceProtocolType? Protocol { get; set; } = CodesysDeviceProtocolType.TcpIpLevel2Route;

    /// <inheritdoc />
    [Range(4000, 9999999)]
    [JsonPropertyName("CODESYS.DEVICE_REQUEST_TIMEOUT_MILLISECONDS")]
    public int? RequestTimeoutMs { get; set; } = 10000;

    /// <inheritdoc />
    [JsonPropertyName("CODESYS.DEVICE_LAYER7_MOTOROLA_BYTEORDER")]
    public bool? Layer7MotorolaByteOrder { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("CODESYS.DEVICE_DEVICE_MOTOROLA_BYTEORDER")]
    public bool? DeviceMotorolaByteOrder { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("CODESYS.DEVICE_PLC_LOGIN")]
    public bool? PlcLogin { get; set; } = true;

    /// <inheritdoc />
    [Range(0, 4294967295)]
    [JsonPropertyName("CODESYS.DEVICE_TARGET_ID")]
    public long TargetId { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("CODESYS.DEVICE_ELAU_MAX4_VERSION")]
    public CodesysDeviceElauMax4VersionType? ElauMax4Version { get; set; } = CodesysDeviceElauMax4VersionType.Disable;

    /// <inheritdoc />
    [JsonPropertyName("CODESYS.DEVICE_SYMBOL_SOURCE")]
    public CodesysDeviceSymbolSourceType? SymbolSource { get; set; } = CodesysDeviceSymbolSourceType.Device;

    /// <inheritdoc />
    [MaxLength(254)]
    [JsonPropertyName("CODESYS.DEVICE_SYMBOL_FILE")]
    public string? SymbolFile { get; set; }

    /// <inheritdoc />
    [MaxLength(254)]
    [JsonPropertyName("CODESYS.DEVICE_SYMBOL_FILE_LOCATION")]
    public string? SymbolCacheLocation { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("CODESYS.DEVICE_USE_GATEWAY")]
    public bool UseGateway { get; set; }

    /// <inheritdoc />
    [MaxLength(253)]
    [JsonPropertyName("CODESYS.DEVICE_GATEWAY_ADDRESS")]
    public string? GatewayAddress { get; set; }

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("CODESYS.DEVICE_GATEWAY_PORT")]
    public int? GatewayPort { get; set; } = 1210;

    /// <inheritdoc />
    [MaxLength(251)]
    [JsonPropertyName("CODESYS.DEVICE_GATEWAY_PASSWORD")]
    public string? GatewayPassword { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("CODESYS.DEVICE_ATG_METHOD")]
    public CodesysDeviceTagGenerationMethodType? TagGenerationMethod { get; set; } = CodesysDeviceTagGenerationMethodType.Online;

    /// <inheritdoc />
    [MaxLength(254)]
    [JsonPropertyName("CODESYS.DEVICE_OFFLINE_ATG_FILE")]
    public string? TagGenerationFile { get; set; }

    /// <inheritdoc />
    [Range(1, 10000)]
    [JsonPropertyName("CODESYS.DEVICE_TAGS_PER_REQUEST")]
    public int TagsPerRequest { get; set; } = 500;

    /// <inheritdoc />
    [JsonPropertyName("CODESYS.DEVICE_ALLOW_EXT_ASCII")]
    public bool? AllowExtendedAscii { get; set; }

    /// <inheritdoc />
    [MaxLength(254)]
    [JsonPropertyName("CODESYS.DEVICE_PLC_USERNAME")]
    public string? PlcUsername { get; set; }

    /// <inheritdoc />
    [MaxLength(251)]
    [JsonPropertyName("CODESYS.DEVICE_PLC_PASSWORD")]
    public string? PlcPassword { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(IpAddress)}: {IpAddress}, {nameof(Port)}: {Port}";
}