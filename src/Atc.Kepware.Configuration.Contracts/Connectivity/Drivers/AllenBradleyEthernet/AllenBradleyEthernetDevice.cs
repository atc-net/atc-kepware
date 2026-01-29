namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AllenBradleyEthernet;

/// <summary>
/// Represents an Allen-Bradley Ethernet device.
/// </summary>
public class AllenBradleyEthernetDevice : DeviceBase, IAllenBradleyEthernetDevice
{
    /// <inheritdoc />
    public AllenBradleyEthernetDeviceModelType Model { get; set; } = AllenBradleyEthernetDeviceModelType.Slc505Open;

    /// <inheritdoc />
    public int Port { get; set; } = 2222;

    /// <inheritdoc />
    public AllenBradleyEthernetRequestSizeType RequestSize { get; set; } = AllenBradleyEthernetRequestSizeType.Bytes512;

    /// <inheritdoc />
    public int DestinationNodeAddress { get; set; }

    /// <inheritdoc />
    public IReadOnlyList<AllenBradleyEthernetSlotConfiguration>? SlotConfiguration { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(Port)}: {Port}, {nameof(RequestSize)}: {RequestSize}";
}