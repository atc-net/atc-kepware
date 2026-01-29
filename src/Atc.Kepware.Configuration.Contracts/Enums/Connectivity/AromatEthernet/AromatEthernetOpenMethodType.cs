namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.AromatEthernet;

/// <summary>
/// Aromat Ethernet open method type.
/// </summary>
/// <remarks>
/// Specifies the method that the ET-LAN unit is configured to use in order to process connection open requests.
/// Only applicable when using TCP/IP protocol.
/// </remarks>
public enum AromatEthernetOpenMethodType
{
    /// <summary>
    /// Full Passive open method.
    /// </summary>
    FullPassive = 0,

    /// <summary>
    /// Unpassive open method.
    /// </summary>
    Unpassive = 1,
}