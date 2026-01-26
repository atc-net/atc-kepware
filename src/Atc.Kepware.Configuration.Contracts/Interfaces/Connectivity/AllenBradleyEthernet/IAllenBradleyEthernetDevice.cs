namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.AllenBradleyEthernet;

/// <summary>
/// Defines the Allen-Bradley Ethernet device properties.
/// </summary>
public interface IAllenBradleyEthernetDevice : IDeviceBase
{
    /// <summary>
    /// Gets the device model type.
    /// </summary>
    AllenBradleyEthernetDeviceModelType Model { get; }

    /// <summary>
    /// Gets the TCP/IP port number the device is configured to use.
    /// </summary>
    /// <remarks>
    /// Default is 2222. Valid range: 0-65535.
    /// </remarks>
    int Port { get; }

    /// <summary>
    /// Gets the maximum request size in bytes.
    /// </summary>
    AllenBradleyEthernetRequestSizeType RequestSize { get; }

    /// <summary>
    /// Gets the destination node address (DST) for DF1 gateway applications.
    /// </summary>
    /// <remarks>
    /// Specifies the network location number of the target device (e.g. DH+ or DH-485 node).
    /// For non-DF1 gateway applications, this should be 0.
    /// Valid range: 0-255.
    /// </remarks>
    int DestinationNodeAddress { get; }

    /// <summary>
    /// Gets the slot configuration array.
    /// </summary>
    /// <remarks>
    /// Only applicable for SLC 5/05 Open model devices.
    /// Contains up to 30 slot configurations.
    /// </remarks>
    IReadOnlyList<AllenBradleyEthernetSlotConfiguration>? SlotConfiguration { get; }
}
