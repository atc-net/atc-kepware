namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.OmronFinsEthernet;

/// <summary>
/// Represents an Omron FINS Ethernet device.
/// </summary>
public class OmronFinsEthernetDevice : DeviceBase, IOmronFinsEthernetDevice
{
    /// <inheritdoc />
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    public OmronFinsEthernetDeviceModelType Model { get; set; } = OmronFinsEthernetDeviceModelType.CS1;

    /// <inheritdoc />
    public int SourceNetworkAddress { get; set; }

    /// <inheritdoc />
    public int SourceNode { get; set; }

    /// <inheritdoc />
    public int DestinationNetworkAddress { get; set; }

    /// <inheritdoc />
    public int DestinationNode { get; set; }

    /// <inheritdoc />
    public int DestinationUnit { get; set; }

    /// <inheritdoc />
    public OmronFinsEthernetCsTsWritesModeType CsTsWritesMode { get; set; } = OmronFinsEthernetCsTsWritesModeType.FailWriteLogMessage;

    /// <inheritdoc />
    public OmronFinsEthernetRequestSizeType RequestSize { get; set; } = OmronFinsEthernetRequestSizeType.Bytes512;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Model)}: {Model}";
}
