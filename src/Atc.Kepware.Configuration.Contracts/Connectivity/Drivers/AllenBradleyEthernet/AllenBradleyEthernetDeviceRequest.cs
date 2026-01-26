namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AllenBradleyEthernet;

/// <summary>
/// Represents an Allen-Bradley Ethernet device creation request.
/// </summary>
public class AllenBradleyEthernetDeviceRequest : DeviceRequestBase, IAllenBradleyEthernetDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AllenBradleyEthernetDeviceRequest"/> class.
    /// </summary>
    public AllenBradleyEthernetDeviceRequest()
        : base(DriverType.AllenBradleyEthernet)
    {
    }

    /// <summary>
    /// Gets or sets the device IP address.
    /// </summary>
    [Required]
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    public AllenBradleyEthernetDeviceModelType Model { get; set; } = AllenBradleyEthernetDeviceModelType.Slc505Open;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int Port { get; set; } = 2222;

    /// <inheritdoc />
    public AllenBradleyEthernetRequestSizeType RequestSize { get; set; } = AllenBradleyEthernetRequestSizeType.Bytes512;

    /// <inheritdoc />
    [Range(0, 255)]
    public int DestinationNodeAddress { get; set; }

    /// <inheritdoc />
    public IList<AllenBradleyEthernetSlotConfiguration>? SlotConfiguration { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Model)}: {Model}, {nameof(Port)}: {Port}, {nameof(RequestSize)}: {RequestSize}";
}
