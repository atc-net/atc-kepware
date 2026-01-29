namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AromatEthernet;

/// <summary>
/// Aromat Ethernet device request.
/// </summary>
public class AromatEthernetDeviceRequest : DeviceRequestBase, IAromatEthernetDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AromatEthernetDeviceRequest"/> class.
    /// </summary>
    public AromatEthernetDeviceRequest()
        : base(DriverType.AromatEthernet)
    {
    }

    /// <inheritdoc />
    [Required]
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    public AromatEthernetDeviceModelType Model { get; set; } = AromatEthernetDeviceModelType.FP;

    /// <inheritdoc />
    public AromatEthernetDeviceIdFormatType IdFormat { get; set; } = AromatEthernetDeviceIdFormatType.Octal;

    /// <inheritdoc />
    public AromatEthernetProtocolType Protocol { get; set; } = AromatEthernetProtocolType.TcpIp;

    /// <inheritdoc />
    public AromatEthernetOpenMethodType OpenMethod { get; set; } = AromatEthernetOpenMethodType.Unpassive;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int SourcePort { get; set; } = 1025;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int DestinationPort { get; set; } = 1025;

    /// <inheritdoc />
    [Range(1, 64)]
    public int SourceStation { get; set; } = 1;

    /// <inheritdoc />
    [Range(1, 64)]
    public int DestinationStation { get; set; } = 1;

    /// <inheritdoc />
    public AromatEthernetRequestSizeType RequestSize { get; set; } = AromatEthernetRequestSizeType.Bytes64;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Model)}: {Model}, {nameof(Protocol)}: {Protocol}";
}
