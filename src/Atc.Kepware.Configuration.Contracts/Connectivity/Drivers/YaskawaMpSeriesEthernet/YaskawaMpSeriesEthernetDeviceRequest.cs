namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.YaskawaMpSeriesEthernet;

/// <summary>
/// Represents a Yaskawa MP Series Ethernet device creation request.
/// </summary>
public class YaskawaMpSeriesEthernetDeviceRequest : DeviceRequestBase, IYaskawaMpSeriesEthernetDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="YaskawaMpSeriesEthernetDeviceRequest"/> class.
    /// </summary>
    public YaskawaMpSeriesEthernetDeviceRequest()
        : base(DriverType.YaskawaMpSeriesEthernet)
    {
    }

    /// <summary>
    /// Gets or sets the device IP address.
    /// </summary>
    /// <remarks>
    /// Format: IP.Address (e.g., "192.168.1.1").
    /// </remarks>
    [Required]
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    [Range(0, 65535)]
    public int PortNumber { get; set; } = 502;

    /// <inheritdoc />
    [Range(8, 800)]
    public int InputBits { get; set; } = 32;

    /// <inheritdoc />
    [Range(8, 800)]
    public int OutputBits { get; set; } = 32;

    /// <inheritdoc />
    [Range(1, 120)]
    public int InputWords { get; set; } = 32;

    /// <inheritdoc />
    [Range(1, 120)]
    public int OutputWords { get; set; } = 32;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}, {nameof(InputBits)}: {InputBits}, {nameof(OutputBits)}: {OutputBits}, {nameof(InputWords)}: {InputWords}, {nameof(OutputWords)}: {OutputWords}";
}