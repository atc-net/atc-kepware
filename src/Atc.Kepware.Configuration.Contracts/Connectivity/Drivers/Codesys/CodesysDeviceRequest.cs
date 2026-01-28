namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.Codesys;

/// <summary>
/// Device properties for the CODESYS driver.
/// </summary>
public sealed class CodesysDeviceRequest : DeviceRequestBase, ICodesysDeviceRequest
{
    public CodesysDeviceRequest()
        : base(DriverType.Codesys)
    {
    }

    /// <inheritdoc />
    public CodesysDeviceModelType Model { get; set; } = CodesysDeviceModelType.CodesysV23Ethernet;

    /// <inheritdoc />
    public CodesysDeviceAddressType? AddressType { get; set; }

    /// <inheritdoc />
    [Required]
    [MaxLength(254)]
    public string IpAddress { get; set; } = string.Empty;

    /// <inheritdoc />
    [MaxLength(255)]
    public string? LogicalAddress { get; set; }

    /// <inheritdoc />
    [Range(0, 65535)]
    public int Port { get; set; } = 1200;

    /// <inheritdoc />
    public CodesysDeviceProtocolType? Protocol { get; set; } = CodesysDeviceProtocolType.TcpIpLevel2Route;

    /// <inheritdoc />
    [Range(4000, 9999999)]
    public int? RequestTimeoutMs { get; set; } = 10000;

    /// <inheritdoc />
    public bool? Layer7MotorolaByteOrder { get; set; }

    /// <inheritdoc />
    public bool? DeviceMotorolaByteOrder { get; set; }

    /// <inheritdoc />
    public bool? PlcLogin { get; set; } = true;

    /// <inheritdoc />
    [Range(0, 4294967295)]
    public long TargetId { get; set; }

    /// <inheritdoc />
    public CodesysDeviceElauMax4VersionType? ElauMax4Version { get; set; } = CodesysDeviceElauMax4VersionType.Disable;

    /// <inheritdoc />
    public CodesysDeviceSymbolSourceType? SymbolSource { get; set; } = CodesysDeviceSymbolSourceType.Device;

    /// <inheritdoc />
    [MaxLength(254)]
    public string? SymbolFile { get; set; }

    /// <inheritdoc />
    [MaxLength(254)]
    public string? SymbolCacheLocation { get; set; }

    /// <inheritdoc />
    public bool UseGateway { get; set; }

    /// <inheritdoc />
    [MaxLength(253)]
    public string? GatewayAddress { get; set; }

    /// <inheritdoc />
    [Range(0, 65535)]
    public int? GatewayPort { get; set; } = 1210;

    /// <inheritdoc />
    [MaxLength(251)]
    public string? GatewayPassword { get; set; }

    /// <inheritdoc />
    public CodesysDeviceTagGenerationMethodType? TagGenerationMethod { get; set; } = CodesysDeviceTagGenerationMethodType.Online;

    /// <inheritdoc />
    [MaxLength(254)]
    public string? TagGenerationFile { get; set; }

    /// <inheritdoc />
    [Range(1, 10000)]
    public int TagsPerRequest { get; set; } = 500;

    /// <inheritdoc />
    public bool? AllowExtendedAscii { get; set; }

    /// <inheritdoc />
    [MaxLength(254)]
    public string? PlcUsername { get; set; }

    /// <inheritdoc />
    [MaxLength(251)]
    public string? PlcPassword { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(IpAddress)}: {IpAddress}, {nameof(Port)}: {Port}";
}
