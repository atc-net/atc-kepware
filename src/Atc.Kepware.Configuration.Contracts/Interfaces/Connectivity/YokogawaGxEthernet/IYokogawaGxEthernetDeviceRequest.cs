namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.YokogawaGxEthernet;

/// <summary>
/// Interface for Yokogawa GX Ethernet device request.
/// </summary>
public interface IYokogawaGxEthernetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the device model.
    /// </summary>
    YokogawaGxEthernetModel Model { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether AS1 security option is enabled.
    /// </summary>
    bool As1SecurityOption { get; set; }

    /// <summary>
    /// Gets or sets the username.
    /// </summary>
    string Username { get; set; }

    /// <summary>
    /// Gets or sets the password.
    /// </summary>
    string Password { get; set; }

    /// <summary>
    /// Gets or sets the user ID for AS1 security.
    /// </summary>
    string UserId { get; set; }
}