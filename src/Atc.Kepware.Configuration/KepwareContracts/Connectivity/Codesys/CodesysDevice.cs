namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.Codesys;

/// <summary>
/// Device properties for the CODESYS driver.
/// </summary>
internal class CodesysDevice : DeviceBase, ICodesysDevice
{
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public CodesysDeviceModelType Model { get; set; }

    [JsonPropertyName("CODESYS.DEVICE_ADDRESS_TYPE")]
    public CodesysDeviceAddressType? AddressType { get; set; }

    [JsonPropertyName("CODESYS.DEVICE_IP_ADDRESS")]
    public string IpAddress { get; set; } = string.Empty;

    [JsonPropertyName("CODESYS.DEVICE_LOGICAL_ADDRESS")]
    public string? LogicalAddress { get; set; }

    [JsonPropertyName("CODESYS.DEVICE_PORT_NUMBER")]
    public int Port { get; set; }

    [JsonPropertyName("CODESYS.DEVICE_PROTOCOL")]
    public CodesysDeviceProtocolType? Protocol { get; set; }

    [JsonPropertyName("CODESYS.DEVICE_REQUEST_TIMEOUT_MILLISECONDS")]
    public int? RequestTimeoutMs { get; set; }

    [JsonPropertyName("CODESYS.DEVICE_LAYER7_MOTOROLA_BYTEORDER")]
    public bool? Layer7MotorolaByteOrder { get; set; }

    [JsonPropertyName("CODESYS.DEVICE_DEVICE_MOTOROLA_BYTEORDER")]
    public bool? DeviceMotorolaByteOrder { get; set; }

    [JsonPropertyName("CODESYS.DEVICE_PLC_LOGIN")]
    public bool? PlcLogin { get; set; }

    [JsonPropertyName("CODESYS.DEVICE_TARGET_ID")]
    public long TargetId { get; set; }

    [JsonPropertyName("CODESYS.DEVICE_ELAU_MAX4_VERSION")]
    public CodesysDeviceElauMax4VersionType? ElauMax4Version { get; set; }

    [JsonPropertyName("CODESYS.DEVICE_SYMBOL_SOURCE")]
    public CodesysDeviceSymbolSourceType? SymbolSource { get; set; }

    [JsonPropertyName("CODESYS.DEVICE_SYMBOL_FILE")]
    public string? SymbolFile { get; set; }

    [JsonPropertyName("CODESYS.DEVICE_SYMBOL_FILE_LOCATION")]
    public string? SymbolCacheLocation { get; set; }

    [JsonPropertyName("CODESYS.DEVICE_USE_GATEWAY")]
    public bool UseGateway { get; set; }

    [JsonPropertyName("CODESYS.DEVICE_GATEWAY_ADDRESS")]
    public string? GatewayAddress { get; set; }

    [JsonPropertyName("CODESYS.DEVICE_GATEWAY_PORT")]
    public int? GatewayPort { get; set; }

    [JsonPropertyName("CODESYS.DEVICE_GATEWAY_PASSWORD")]
    public string? GatewayPassword { get; set; }

    [JsonPropertyName("CODESYS.DEVICE_ATG_METHOD")]
    public CodesysDeviceTagGenerationMethodType? TagGenerationMethod { get; set; }

    [JsonPropertyName("CODESYS.DEVICE_OFFLINE_ATG_FILE")]
    public string? TagGenerationFile { get; set; }

    [JsonPropertyName("CODESYS.DEVICE_TAGS_PER_REQUEST")]
    public int TagsPerRequest { get; set; }

    [JsonPropertyName("CODESYS.DEVICE_ALLOW_EXT_ASCII")]
    public bool? AllowExtendedAscii { get; set; }

    [JsonPropertyName("CODESYS.DEVICE_PLC_USERNAME")]
    public string? PlcUsername { get; set; }

    [JsonPropertyName("CODESYS.DEVICE_PLC_PASSWORD")]
    public string? PlcPassword { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(IpAddress)}: {IpAddress}, {nameof(Port)}: {Port}";
}
