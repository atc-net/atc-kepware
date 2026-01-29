namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.CutlerHammerElcEthernet;

/// <summary>
/// Represents a Cutler-Hammer ELC Ethernet device creation request.
/// </summary>
public class CutlerHammerElcEthernetDeviceRequest : DeviceRequestBase, ICutlerHammerElcEthernetDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CutlerHammerElcEthernetDeviceRequest"/> class.
    /// </summary>
    public CutlerHammerElcEthernetDeviceRequest()
        : base(DriverType.CutlerHammerElcEthernet)
    {
    }

    /// <inheritdoc />
    public CutlerHammerElcEthernetDeviceModelType Model { get; set; } = CutlerHammerElcEthernetDeviceModelType.Pv28Series;

    /// <inheritdoc />
    public CutlerHammerElcEthernetDeviceIdFormatType IdFormat { get; set; } = CutlerHammerElcEthernetDeviceIdFormatType.Octal;

    /// <inheritdoc />
    [Required]
    public string DeviceId { get; set; } = "<255.255.255.255>.0";

    /// <inheritdoc />
    [Range(0, 65535)]
    public int PortNumber { get; set; } = 502;

    /// <inheritdoc />
    [Range(8, 1024)]
    public int OutputCoils { get; set; } = 1024;

    /// <inheritdoc />
    [Range(8, 1024)]
    public int InputCoils { get; set; } = 1024;

    /// <inheritdoc />
    [Range(1, 120)]
    public int HoldingRegisters { get; set; } = 120;

    /// <inheritdoc />
    public bool FirstWordLow { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}";
}