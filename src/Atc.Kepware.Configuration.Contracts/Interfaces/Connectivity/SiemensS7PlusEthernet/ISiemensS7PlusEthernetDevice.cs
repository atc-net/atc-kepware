namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.SiemensS7PlusEthernet;

/// <summary>
/// Defines the Siemens S7 Plus Ethernet device properties.
/// </summary>
public interface ISiemensS7PlusEthernetDevice : IDeviceBase
{
    /// <summary>
    /// Gets or sets the TCP/IP port number.
    /// </summary>
    /// <remarks>
    /// Default is 102. Valid range: 1-65535.
    /// </remarks>
    int Port { get; set; }

    /// <summary>
    /// Gets or sets the password for the access level configured in the PLC.
    /// </summary>
    string? PlcPassword { get; set; }

    /// <summary>
    /// Gets or sets whether to include Instance Data Blocks and Function Blocks in symbol load.
    /// </summary>
    bool IncludeIdbsFbs { get; set; }
}
