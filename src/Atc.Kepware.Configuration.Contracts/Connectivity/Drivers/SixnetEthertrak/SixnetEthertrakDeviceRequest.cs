namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.SixnetEthertrak;

/// <summary>
/// Represents a SIXNET EtherTRAK device creation request.
/// </summary>
public class SixnetEthertrakDeviceRequest : DeviceRequestBase, ISixnetEthertrakDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SixnetEthertrakDeviceRequest"/> class.
    /// </summary>
    public SixnetEthertrakDeviceRequest()
        : base(DriverType.SixnetEthertrak)
    {
    }

    /// <summary>
    /// Gets or sets the device IP address.
    /// </summary>
    /// <remarks>
    /// Format: YYY.YYY.YYY.YYY where each YYY is 0-255.
    /// For RS-485 bridging to RemoteTRAK devices, use format: YYY.YYY.YYY.YYY.ZZZ
    /// where ZZZ is the station number (1-247).
    /// </remarks>
    [Required]
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    [Range(0, 65535)]
    public int PortNumber { get; set; } = 502;

    /// <inheritdoc />
    [Range(8, 800)]
    public int OutputDiscretes { get; set; } = 32;

    /// <inheritdoc />
    [Range(8, 800)]
    public int InputDiscretes { get; set; } = 32;

    /// <inheritdoc />
    [Range(1, 120)]
    public int OutputRegisters { get; set; } = 32;

    /// <inheritdoc />
    [Range(1, 120)]
    public int InputRegisters { get; set; } = 32;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}, {nameof(OutputDiscretes)}: {OutputDiscretes}, {nameof(InputDiscretes)}: {InputDiscretes}, {nameof(OutputRegisters)}: {OutputRegisters}, {nameof(InputRegisters)}: {InputRegisters}";
}
