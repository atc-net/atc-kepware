namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.OmronNjEthernet;

/// <summary>
/// Omron NJ Ethernet device.
/// </summary>
public class OmronNjEthernetDevice : DeviceBase, IOmronNjEthernetDevice
{
    /// <inheritdoc />
    public OmronNjEthernetModel Model { get; set; } = OmronNjEthernetModel.OmronNj;

    /// <inheritdoc />
    public int Port { get; set; } = 44818;

    /// <inheritdoc />
    public int ConnectionSize { get; set; } = 1996;

    /// <inheritdoc />
    public OmronNjEthernetInactivityWatchdog InactivityWatchdog { get; set; } = OmronNjEthernetInactivityWatchdog.Seconds32;

    /// <inheritdoc />
    public OmronNjEthernetArrayBlockSize ArrayBlockSize { get; set; } = OmronNjEthernetArrayBlockSize.Elements120;

    /// <inheritdoc />
    public bool PerformanceStatistics { get; set; }

    /// <inheritdoc />
    public OmronNjEthernetTagHierarchy TagHierarchy { get; set; } = OmronNjEthernetTagHierarchy.Expanded;
}