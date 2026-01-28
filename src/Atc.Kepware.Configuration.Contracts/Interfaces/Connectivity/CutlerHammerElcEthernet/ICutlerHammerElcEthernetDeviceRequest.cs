namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.CutlerHammerElcEthernet;

/// <summary>
/// Defines the Cutler-Hammer ELC Ethernet device request properties.
/// </summary>
public interface ICutlerHammerElcEthernetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the device model.
    /// </summary>
    CutlerHammerElcEthernetDeviceModelType Model { get; set; }

    /// <summary>
    /// Gets or sets the device ID format.
    /// </summary>
    CutlerHammerElcEthernetDeviceIdFormatType IdFormat { get; set; }

    /// <summary>
    /// Gets or sets the device IP address and unit ID.
    /// </summary>
    /// <remarks>
    /// Format: &lt;IP_Address&gt;.&lt;Unit_ID&gt; (e.g., "192.168.1.1.0").
    /// </remarks>
    string DeviceId { get; set; }

    /// <summary>
    /// Gets or sets the TCP/IP port number.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-65535. Default: 502.
    /// </remarks>
    int PortNumber { get; set; }

    /// <summary>
    /// Gets or sets the number of discrete outputs to read in a single request.
    /// </summary>
    /// <remarks>
    /// Valid range: 8-1024. Must be a multiple of 8. Default: 1024.
    /// </remarks>
    int OutputCoils { get; set; }

    /// <summary>
    /// Gets or sets the number of discrete inputs to read in a single request.
    /// </summary>
    /// <remarks>
    /// Valid range: 8-1024. Must be a multiple of 8. Default: 1024.
    /// </remarks>
    int InputCoils { get; set; }

    /// <summary>
    /// Gets or sets the number of holding registers to read in a single request.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-120. Default: 120.
    /// </remarks>
    int HoldingRegisters { get; set; }

    /// <summary>
    /// Gets or sets whether the first word is the low word of a 32-bit value.
    /// </summary>
    bool FirstWordLow { get; set; }
}
