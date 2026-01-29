namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.Codesys;

/// <summary>
/// Represents a CODESYS device.
/// </summary>
public interface ICodesysDevice : IDeviceBase
{
    /// <summary>
    /// The device model type.
    /// </summary>
    CodesysDeviceModelType Model { get; set; }

    /// <summary>
    /// The address type for CODESYS V3 devices.
    /// </summary>
    CodesysDeviceAddressType? AddressType { get; set; }

    /// <summary>
    /// The IP address or hostname of the target device.
    /// </summary>
    string IpAddress { get; set; }

    /// <summary>
    /// The logical address or PLC name for the device.
    /// </summary>
    string? LogicalAddress { get; set; }

    /// <summary>
    /// The TCP/IP port number on the target device.
    /// </summary>
    int Port { get; set; }

    /// <summary>
    /// The protocol for CODESYS V2.3 devices.
    /// </summary>
    CodesysDeviceProtocolType? Protocol { get; set; }

    /// <summary>
    /// The request timeout in milliseconds for CODESYS V2.3 devices.
    /// </summary>
    int? RequestTimeoutMs { get; set; }

    /// <summary>
    /// Enable if Layer 7 uses the Motorola byte order.
    /// </summary>
    bool? Layer7MotorolaByteOrder { get; set; }

    /// <summary>
    /// Enable if the target device uses the Motorola byte order.
    /// </summary>
    bool? DeviceMotorolaByteOrder { get; set; }

    /// <summary>
    /// Specify if the driver should stay logged into the PLC after connecting.
    /// </summary>
    bool? PlcLogin { get; set; }

    /// <summary>
    /// The target ID if this device is a sub-PLC.
    /// </summary>
    long TargetId { get; set; }

    /// <summary>
    /// The hardware version for ELAU-Max4 PLCs.
    /// </summary>
    CodesysDeviceElauMax4VersionType? ElauMax4Version { get; set; }

    /// <summary>
    /// Where the driver should look for device symbols.
    /// </summary>
    CodesysDeviceSymbolSourceType? SymbolSource { get; set; }

    /// <summary>
    /// The full filename including path to use if the symbol file cannot be saved on the device.
    /// </summary>
    string? SymbolFile { get; set; }

    /// <summary>
    /// The local directory location where PLC symbols will be cached.
    /// </summary>
    string? SymbolCacheLocation { get; set; }

    /// <summary>
    /// Specify if a gateway should be used when connecting to the device.
    /// </summary>
    bool UseGateway { get; set; }

    /// <summary>
    /// The IP address or hostname for the gateway.
    /// </summary>
    string? GatewayAddress { get; set; }

    /// <summary>
    /// The port for the gateway.
    /// </summary>
    int? GatewayPort { get; set; }

    /// <summary>
    /// The password for the gateway.
    /// </summary>
    string? GatewayPassword { get; set; }

    /// <summary>
    /// Whether Automatic Tag Generation is done offline or online.
    /// </summary>
    CodesysDeviceTagGenerationMethodType? TagGenerationMethod { get; set; }

    /// <summary>
    /// The file to use for offline Automatic Tag Generation and Tag Browsing.
    /// </summary>
    string? TagGenerationFile { get; set; }

    /// <summary>
    /// The maximum number of tags to include in a single request.
    /// </summary>
    int TagsPerRequest { get; set; }

    /// <summary>
    /// When enabled allows extended ASCII characters (0x80-0xFF).
    /// </summary>
    bool? AllowExtendedAscii { get; set; }

    /// <summary>
    /// The username to use to login to the device (V3 only).
    /// </summary>
    string? PlcUsername { get; set; }

    /// <summary>
    /// The password to use to login to the device (V3 only).
    /// </summary>
    string? PlcPassword { get; set; }
}