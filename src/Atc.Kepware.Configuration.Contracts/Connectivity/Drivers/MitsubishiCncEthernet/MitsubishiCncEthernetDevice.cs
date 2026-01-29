namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.MitsubishiCncEthernet;

/// <summary>
/// Mitsubishi CNC Ethernet device.
/// </summary>
public class MitsubishiCncEthernetDevice : DeviceBase, IMitsubishiCncEthernetDevice
{
    /// <inheritdoc />
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    public MitsubishiCncEthernetDeviceModelType Model { get; set; } = MitsubishiCncEthernetDeviceModelType.C64;

    /// <inheritdoc />
    public bool FirstWordLow { get; set; } = true;

    /// <inheritdoc />
    public int PortNumber { get; set; } = 5001;

    /// <inheritdoc />
    public int SourceNetwork { get; set; } = 1;

    /// <inheritdoc />
    public int SourceStation { get; set; } = 1;

    /// <inheritdoc />
    public int DestinationNetwork { get; set; } = 1;

    /// <inheritdoc />
    public int DestinationStation { get; set; } = 2;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Model)}: {Model}";
}