namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.AllenBradleyServerEthernet;

/// <summary>
/// Defines the Allen-Bradley Server Ethernet device request properties.
/// </summary>
public interface IAllenBradleyServerEthernetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the TCP/IP port number this device should use.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-65535. Default: 2222.
    /// </remarks>
    int Port { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the first word is low for 32-bit data types.
    /// </summary>
    /// <remarks>
    /// Specifies the word order for 32-bit data types.
    /// </remarks>
    bool FirstWordLow { get; set; }
}
