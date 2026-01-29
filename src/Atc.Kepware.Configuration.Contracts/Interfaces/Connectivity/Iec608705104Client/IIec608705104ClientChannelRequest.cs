namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.Iec608705104Client;

/// <summary>
/// Defines the IEC 60870-5-104 Client channel request properties.
/// </summary>
public interface IIec608705104ClientChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Gets or sets the network adapter to bind for Ethernet communication.
    /// </summary>
    string? NetworkAdapter { get; set; }

    /// <summary>
    /// Gets or sets the IP address of the destination device.
    /// </summary>
    /// <remarks>
    /// Default: 255.255.255.255.
    /// </remarks>
    string DestinationHost { get; set; }

    /// <summary>
    /// Gets or sets the port number used to connect to the destination device.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-65535. Default: 2404.
    /// </remarks>
    int DestinationPort { get; set; }

    /// <summary>
    /// Gets or sets the time in seconds to wait when attempting to establish a connection.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-255. Default: 3.
    /// </remarks>
    int ConnectTimeout { get; set; }

    /// <summary>
    /// Gets or sets the Cause of Transmission (COT) Size.
    /// </summary>
    /// <remarks>
    /// Default: TwoOctets.
    /// </remarks>
    Iec608705104CotSizeType CotSize { get; set; }

    /// <summary>
    /// Gets or sets the Originator Address used in the second byte of COT.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-254. Default: 0. Only applicable when COT Size is TwoOctets.
    /// </remarks>
    int OriginatorAddress { get; set; }

    /// <summary>
    /// Gets or sets the time in seconds to wait for acknowledgement (ACK) to a transmitted APDU.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-255. Default: 15.
    /// </remarks>
    int T1 { get; set; }

    /// <summary>
    /// Gets or sets the time in seconds to wait before sending a supervisory APDU acknowledgement (ACK).
    /// </summary>
    /// <remarks>
    /// Valid range: 1-255. Default: 10.
    /// </remarks>
    int T2 { get; set; }

    /// <summary>
    /// Gets or sets the idle time in seconds before sending a TEST APDU.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-172800. Default: 20.
    /// </remarks>
    int T3 { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of unacknowledged transmitted APDUs.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-12. Default: 12.
    /// </remarks>
    int K { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of unacknowledged received APDUs.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-65535. Default: 8.
    /// </remarks>
    int W { get; set; }

    /// <summary>
    /// Gets or sets the maximum data receive size in bytes.
    /// </summary>
    /// <remarks>
    /// Valid range: 2-253. Default: 253. Messages containing more than the specified size are discarded.
    /// </remarks>
    int RxBufferSize { get; set; }

    /// <summary>
    /// Gets or sets the time in milliseconds to wait for any response from a device if a command is outstanding.
    /// </summary>
    /// <remarks>
    /// Valid range: 10-2147483647. Default: 30000.
    /// </remarks>
    int IncrementalTimeout { get; set; }

    /// <summary>
    /// Gets or sets the time in milliseconds to wait after receiving a character before attempting to transmit a character.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-65535. Default: 0.
    /// </remarks>
    int FirstCharWait { get; set; }
}