namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.Codesys;

/// <summary>
/// Represents a CODESYS device.
/// </summary>
public sealed class CodesysDevice : DeviceBase, ICodesysDevice
{
    /// <inheritdoc />
    public CodesysDeviceModelType Model { get; set; }

    /// <inheritdoc />
    public CodesysDeviceAddressType? AddressType { get; set; }

    /// <inheritdoc />
    public string IpAddress { get; set; } = string.Empty;

    /// <inheritdoc />
    public string? LogicalAddress { get; set; }

    /// <inheritdoc />
    public int Port { get; set; }

    /// <inheritdoc />
    public CodesysDeviceProtocolType? Protocol { get; set; }

    /// <inheritdoc />
    public int? RequestTimeoutMs { get; set; }

    /// <inheritdoc />
    public bool? Layer7MotorolaByteOrder { get; set; }

    /// <inheritdoc />
    public bool? DeviceMotorolaByteOrder { get; set; }

    /// <inheritdoc />
    public bool? PlcLogin { get; set; }

    /// <inheritdoc />
    public long TargetId { get; set; }

    /// <inheritdoc />
    public CodesysDeviceElauMax4VersionType? ElauMax4Version { get; set; }

    /// <inheritdoc />
    public CodesysDeviceSymbolSourceType? SymbolSource { get; set; }

    /// <inheritdoc />
    public string? SymbolFile { get; set; }

    /// <inheritdoc />
    public string? SymbolCacheLocation { get; set; }

    /// <inheritdoc />
    public bool UseGateway { get; set; }

    /// <inheritdoc />
    public string? GatewayAddress { get; set; }

    /// <inheritdoc />
    public int? GatewayPort { get; set; }

    /// <inheritdoc />
    public CodesysDeviceTagGenerationMethodType? TagGenerationMethod { get; set; }

    /// <inheritdoc />
    public string? TagGenerationFile { get; set; }

    /// <inheritdoc />
    public int TagsPerRequest { get; set; }

    /// <inheritdoc />
    public bool? AllowExtendedAscii { get; set; }

    /// <inheritdoc />
    public string? PlcUsername { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(IpAddress)}: {IpAddress}, {nameof(Port)}: {Port}";
}
