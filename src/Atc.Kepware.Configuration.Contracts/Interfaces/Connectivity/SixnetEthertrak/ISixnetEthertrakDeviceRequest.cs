namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.SixnetEthertrak;

/// <summary>
/// Defines the SIXNET EtherTRAK device request properties.
/// </summary>
public interface ISixnetEthertrakDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the device IP address.
    /// </summary>
    /// <remarks>
    /// Format: YYY.YYY.YYY.YYY where each YYY is 0-255.
    /// For RS-485 bridging to RemoteTRAK devices, use format: YYY.YYY.YYY.YYY.ZZZ
    /// where ZZZ is the station number (1-247).
    /// </remarks>
    string DeviceId { get; set; }

    /// <summary>
    /// Gets or sets the TCP/IP port that the remote device is configured to use.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-65535. Default: 502.
    /// </remarks>
    int PortNumber { get; set; }

    /// <summary>
    /// Gets or sets the number of output coils (bits) that the driver will read in one read request.
    /// </summary>
    /// <remarks>
    /// Valid range: 8-800. Default: 32.
    /// </remarks>
    int OutputDiscretes { get; set; }

    /// <summary>
    /// Gets or sets the number of input coils (bits) that the driver will read in one read request.
    /// </summary>
    /// <remarks>
    /// Valid range: 8-800. Default: 32.
    /// </remarks>
    int InputDiscretes { get; set; }

    /// <summary>
    /// Gets or sets the number of output registers (words) that the driver will read in one read request.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-120. Default: 32.
    /// </remarks>
    int OutputRegisters { get; set; }

    /// <summary>
    /// Gets or sets the number of input registers (words) that the driver will read in one read request.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-120. Default: 32.
    /// </remarks>
    int InputRegisters { get; set; }
}
