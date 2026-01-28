namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.AromatEthernet;

/// <summary>
/// Defines the Aromat Ethernet device request properties.
/// </summary>
public interface IAromatEthernetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the device IP address.
    /// </summary>
    /// <remarks>
    /// Format: IP.Address (e.g., "255.255.255.255").
    /// </remarks>
    string DeviceId { get; set; }

    /// <summary>
    /// Gets or sets the device model type.
    /// </summary>
    AromatEthernetDeviceModelType Model { get; set; }

    /// <summary>
    /// Gets or sets the protocol used by the device.
    /// </summary>
    AromatEthernetProtocolType Protocol { get; set; }

    /// <summary>
    /// Gets or sets the open method that the ET-LAN unit is configured to use.
    /// </summary>
    /// <remarks>
    /// Only applicable when using TCP/IP protocol.
    /// </remarks>
    AromatEthernetOpenMethodType OpenMethod { get; set; }

    /// <summary>
    /// Gets or sets the port the driver should use to send and receive messages.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-65535. Default: 1025.
    /// </remarks>
    int SourcePort { get; set; }

    /// <summary>
    /// Gets or sets the port on which the ET-LAN has been configured to send and receive messages.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-65535. Default: 1025.
    /// </remarks>
    int DestinationPort { get; set; }

    /// <summary>
    /// Gets or sets the source station number for the driver's connection point to the device.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-64. Default: 1.
    /// </remarks>
    int SourceStation { get; set; }

    /// <summary>
    /// Gets or sets the target device's station number.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-64. Default: 1.
    /// </remarks>
    int DestinationStation { get; set; }

    /// <summary>
    /// Gets or sets the request size in bytes.
    /// </summary>
    /// <remarks>
    /// This determines the maximum number of bytes the driver can request in a transaction.
    /// </remarks>
    AromatEthernetRequestSizeType RequestSize { get; set; }
}
