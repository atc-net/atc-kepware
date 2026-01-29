namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.OmronFinsEthernet;

/// <summary>
/// Defines the Omron FINS Ethernet device request properties.
/// </summary>
public interface IOmronFinsEthernetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the device IP address.
    /// </summary>
    string DeviceId { get; set; }

    /// <summary>
    /// Gets or sets the device model type.
    /// </summary>
    OmronFinsEthernetDeviceModelType Model { get; set; }

    /// <summary>
    /// Gets or sets the source network address.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-127.
    /// </remarks>
    int SourceNetworkAddress { get; set; }

    /// <summary>
    /// Gets or sets the source node number.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-254.
    /// </remarks>
    int SourceNode { get; set; }

    /// <summary>
    /// Gets or sets the destination network address (DNA).
    /// </summary>
    /// <remarks>
    /// 0 is the local network. Valid range: 0-127.
    /// </remarks>
    int DestinationNetworkAddress { get; set; }

    /// <summary>
    /// Gets or sets the destination node number (DA1).
    /// </summary>
    /// <remarks>
    /// Valid range: 0-254.
    /// </remarks>
    int DestinationNode { get; set; }

    /// <summary>
    /// Gets or sets the destination unit number (DA2).
    /// </summary>
    /// <remarks>
    /// Valid range: 0-255.
    /// </remarks>
    int DestinationUnit { get; set; }

    /// <summary>
    /// Gets or sets the behavior for CS and TS writes in Run Mode.
    /// </summary>
    OmronFinsEthernetCsTsWritesModeType CsTsWritesMode { get; set; }

    /// <summary>
    /// Gets or sets the maximum request size in bytes.
    /// </summary>
    OmronFinsEthernetRequestSizeType RequestSize { get; set; }
}