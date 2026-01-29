namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.GeEthernet;

/// <summary>
/// Defines the GE Ethernet device request properties.
/// </summary>
public interface IGeEthernetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the device model.
    /// </summary>
    GeEthernetModel Model { get; set; }

    /// <summary>
    /// Gets or sets the TCP/IP port number to communicate with on the target device.
    /// </summary>
    /// <remarks>
    /// Valid range: 0 to 65535.
    /// Default: 18245.
    /// </remarks>
    int PortNumber { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of bytes to request per read transaction.
    /// </summary>
    /// <remarks>
    /// Default: <see cref="GeEthernetMaxBytesPerRequest.Bytes2048"/>.
    /// </remarks>
    GeEthernetMaxBytesPerRequest MaxBytesPerRequest { get; set; }

    /// <summary>
    /// Gets or sets the location of the variable import file to be used in tag database creation.
    /// </summary>
    /// <remarks>
    /// Maximum length: 256 characters.
    /// Default: "*.snf".
    /// </remarks>
    string VariableImportFile { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether tag descriptions should be imported and displayed if provided.
    /// </summary>
    /// <remarks>
    /// Default: true.
    /// </remarks>
    bool DisplayDescriptions { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to use the data type assigned to alias tags in the import file.
    /// </summary>
    /// <remarks>
    /// If enabled and the alias tag data type is not available or is incompatible, the source tag data type is used.
    /// Default: false.
    /// </remarks>
    bool UseAliasDataTypeIfPossible { get; set; }

    /// <summary>
    /// Gets or sets the program name to access program block registers (P) or subprogram block registers (L).
    /// </summary>
    /// <remarks>
    /// Also referred to as Control Program Task Name, PLC Target Name, and Folder Nickname.
    /// Maximum length: 7 characters.
    /// Default: "PROGRAM".
    /// Only available for certain models (9070 series, GE OPEN, PACSystems).
    /// </remarks>
    string ProgramName { get; set; }

    /// <summary>
    /// Gets or sets the physical location of the CPU on the rack.
    /// </summary>
    /// <remarks>
    /// Valid range: 0 to 15.
    /// Default: 1.
    /// Only available for GE OPEN and PACSystems models.
    /// </remarks>
    int CpuSlotLocation { get; set; }
}
