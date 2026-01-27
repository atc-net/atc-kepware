namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.SiemensTcpIpServerEthernet;

/// <summary>
/// Defines the Siemens TCP/IP Server Ethernet device request properties.
/// </summary>
public interface ISiemensTcpIpServerEthernetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the rack number where the simulated CPU resides.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-7. Default: 0.
    /// </remarks>
    int RackNumber { get; set; }

    /// <summary>
    /// Gets or sets the slot number where the simulated CPU resides.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-31. Default: 0.
    /// </remarks>
    int CpuSlot { get; set; }

    /// <summary>
    /// Gets or sets the maximum PDU size in bytes.
    /// </summary>
    SiemensTcpIpServerMaxPduSize MaxPduSize { get; set; }
}
