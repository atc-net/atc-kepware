namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.MitsubishiEthernet;

/// <summary>
/// Defines the Mitsubishi Ethernet device request properties.
/// </summary>
public interface IMitsubishiEthernetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the device IP address with PC number.
    /// </summary>
    /// <remarks>
    /// Format: IP.Address:PCNumber (e.g., "192.168.1.1:0").
    /// </remarks>
    string DeviceId { get; set; }

    /// <summary>
    /// Gets or sets the device model type.
    /// </summary>
    MitsubishiEthernetDeviceModelType Model { get; set; }

    /// <summary>
    /// Gets or sets whether the first word is low for 32-bit values.
    /// </summary>
    bool FirstWordLow { get; set; }

    /// <summary>
    /// Gets or sets the IP protocol type.
    /// </summary>
    MitsubishiEthernetIpProtocolType IpProtocol { get; set; }

    /// <summary>
    /// Gets or sets the port number.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-65535. Default: 5000.
    /// </remarks>
    int PortNumber { get; set; }

    /// <summary>
    /// Gets or sets the source port number.
    /// </summary>
    /// <remarks>
    /// Only applicable for FX3U model with UDP protocol. Valid range: 0-65535.
    /// </remarks>
    int SourcePortNumber { get; set; }

    /// <summary>
    /// Gets or sets the target CPU.
    /// </summary>
    /// <remarks>
    /// Only applicable for Q, QnA, L, iQ-F, and iQ-R series.
    /// </remarks>
    MitsubishiEthernetCpuType Cpu { get; set; }

    /// <summary>
    /// Gets or sets the block size in word units for reading from bit memory.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-127. Default: 127.
    /// </remarks>
    int ReadBitMemory { get; set; }

    /// <summary>
    /// Gets or sets the block size in words for reading from word memory.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-253. Default: 253.
    /// </remarks>
    int ReadWordMemory { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of bits per write request.
    /// </summary>
    /// <remarks>
    /// Only applicable for Q, QnA, L, iQ-F, and iQ-R series. Valid range: 1-80. Default: 80.
    /// </remarks>
    int WriteBitSize { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of words per write request.
    /// </summary>
    /// <remarks>
    /// Only applicable for Q, QnA, L, iQ-F, and iQ-R series. Valid range: 1-40. Default: 40.
    /// </remarks>
    int WriteWordSize { get; set; }

    /// <summary>
    /// Gets or sets whether to pad remaining bytes after string with NULL characters.
    /// </summary>
    bool WriteFullStringLength { get; set; }

    /// <summary>
    /// Gets or sets the time synchronization method.
    /// </summary>
    /// <remarks>
    /// Only applicable for Q, QnA, L, iQ-F, and iQ-R series.
    /// </remarks>
    MitsubishiEthernetTimeSyncMethodType TimeSyncMethod { get; set; }

    /// <summary>
    /// Gets or sets the absolute sync time in minutes since midnight.
    /// </summary>
    /// <remarks>
    /// Only used when TimeSyncMethod is Absolute. Represents the hour and minute of each day to synchronize time.
    /// </remarks>
    int AbsoluteSyncTime { get; set; }

    /// <summary>
    /// Gets or sets the sync interval in minutes.
    /// </summary>
    /// <remarks>
    /// Only used when TimeSyncMethod is Interval. Valid range: 5-1440.
    /// </remarks>
    int SyncIntervalMinutes { get; set; }
}