namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.OmronFinsEthernet;

/// <summary>
/// Represents an Omron FINS Ethernet device creation request.
/// </summary>
public class OmronFinsEthernetDeviceRequest : DeviceRequestBase, IOmronFinsEthernetDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OmronFinsEthernetDeviceRequest"/> class.
    /// </summary>
    public OmronFinsEthernetDeviceRequest()
        : base(DriverType.OmronFinsEthernet)
    {
    }

    /// <inheritdoc />
    [Required]
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    public OmronFinsEthernetDeviceModelType Model { get; set; } = OmronFinsEthernetDeviceModelType.CS1;

    /// <inheritdoc />
    [Range(0, 127)]
    public int SourceNetworkAddress { get; set; }

    /// <inheritdoc />
    [Range(0, 254)]
    public int SourceNode { get; set; }

    /// <inheritdoc />
    [Range(0, 127)]
    public int DestinationNetworkAddress { get; set; }

    /// <inheritdoc />
    [Range(0, 254)]
    public int DestinationNode { get; set; }

    /// <inheritdoc />
    [Range(0, 255)]
    public int DestinationUnit { get; set; }

    /// <inheritdoc />
    public OmronFinsEthernetCsTsWritesModeType CsTsWritesMode { get; set; } = OmronFinsEthernetCsTsWritesModeType.FailWriteLogMessage;

    /// <inheritdoc />
    public OmronFinsEthernetRequestSizeType RequestSize { get; set; } = OmronFinsEthernetRequestSizeType.Bytes512;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Model)}: {Model}";
}