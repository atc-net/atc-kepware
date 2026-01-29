namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.SiemensTcpIpEthernet;

/// <summary>
/// Defines the Siemens TCP/IP Ethernet device properties.
/// </summary>
public interface ISiemensTcpIpEthernetDevice : IDeviceBase
{
    /// <summary>
    /// Gets or sets the device model type.
    /// </summary>
    SiemensTcpIpEthernetDeviceModelType Model { get; set; }

    /// <summary>
    /// Gets or sets the TCP/IP port number.
    /// </summary>
    /// <remarks>
    /// Default is 102. Valid range: 0-65535.
    /// </remarks>
    int Port { get; set; }

    /// <summary>
    /// Gets or sets the MPI ID for NetLink adapters.
    /// </summary>
    /// <remarks>
    /// Only applicable for NetLink: S7-300 and NetLink: S7-400 models.
    /// Valid range: 0-126.
    /// </remarks>
    int MpiId { get; set; }

    /// <summary>
    /// Gets or sets the maximum PDU size in bytes.
    /// </summary>
    /// <remarks>
    /// Not applicable for NetLink models.
    /// </remarks>
    SiemensTcpIpEthernetMaxPduType MaxPduSize { get; set; }

    /// <summary>
    /// Gets or sets the local TSAP address.
    /// </summary>
    /// <remarks>
    /// Only used for S7-200 model. Hexadecimal value, default 0x4D57.
    /// </remarks>
    int LocalTsap { get; set; }

    /// <summary>
    /// Gets or sets the remote TSAP address.
    /// </summary>
    /// <remarks>
    /// Only used for S7-200 model. Hexadecimal value, default 0x4D57.
    /// </remarks>
    int RemoteTsap { get; set; }

    /// <summary>
    /// Gets or sets the connection link type.
    /// </summary>
    /// <remarks>
    /// Used for S7-300, S7-400, S7-1200, and S7-1500 models.
    /// </remarks>
    SiemensTcpIpEthernetLinkType LinkType { get; set; }

    /// <summary>
    /// Gets or sets the CPU rack number.
    /// </summary>
    /// <remarks>
    /// Used for S7-300, S7-400, S7-1200, and S7-1500 models.
    /// Valid range: 0-7.
    /// </remarks>
    int CpuRack { get; set; }

    /// <summary>
    /// Gets or sets the CPU slot number.
    /// </summary>
    /// <remarks>
    /// Used for S7-300, S7-400, S7-1200, and S7-1500 models.
    /// Valid range: 1-31. Default: 2.
    /// </remarks>
    int CpuSlot { get; set; }

    /// <summary>
    /// Gets or sets the byte order for 16-bit and 32-bit values.
    /// </summary>
    SiemensTcpIpEthernetByteOrderType ByteOrder { get; set; }
}