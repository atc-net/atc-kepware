namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.MitsubishiCncEthernet;

/// <summary>
/// Defines the Mitsubishi CNC Ethernet device request properties.
/// </summary>
public interface IMitsubishiCncEthernetDeviceRequest : IDeviceRequestBase
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
    MitsubishiCncEthernetDeviceModelType Model { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the first word is low for 32-bit data types.
    /// </summary>
    bool FirstWordLow { get; set; }

    /// <summary>
    /// Gets or sets the UDP port for the destination CNC.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-65535. Default: 5001.
    /// </remarks>
    int PortNumber { get; set; }

    /// <summary>
    /// Gets or sets the network number on which the PC resides.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-239. Default: 1.
    /// </remarks>
    int SourceNetwork { get; set; }

    /// <summary>
    /// Gets or sets the station number assigned to the PC.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-239. Default: 1.
    /// </remarks>
    int SourceStation { get; set; }

    /// <summary>
    /// Gets or sets the network number on which the CNC resides.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-239. Default: 1.
    /// </remarks>
    int DestinationNetwork { get; set; }

    /// <summary>
    /// Gets or sets the station number assigned to CNC.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-239. Default: 2.
    /// </remarks>
    int DestinationStation { get; set; }
}
