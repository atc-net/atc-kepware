namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.YokogawaDxEthernet;

/// <summary>
/// Interface for Yokogawa DX Ethernet device request.
/// </summary>
public interface IYokogawaDxEthernetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the device model.
    /// </summary>
    YokogawaDxEthernetModel Model { get; set; }

    /// <summary>
    /// Gets or sets the data handling for out of range and error conditions.
    /// </summary>
    YokogawaDxEthernetDataHandling DataHandling { get; set; }

    /// <summary>
    /// Gets or sets the polling interval in milliseconds.
    /// </summary>
    int PollingInterval { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to start math computation on communication startup.
    /// </summary>
    bool StartMath { get; set; }

    /// <summary>
    /// Gets or sets the source of the date and time data.
    /// </summary>
    YokogawaDxEthernetDateTimeSource DateAndTime { get; set; }

    /// <summary>
    /// Gets or sets the date format for the return string.
    /// </summary>
    YokogawaDxEthernetDateFormat DateFormat { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to set the device clock on communication startup.
    /// </summary>
    bool SetClock { get; set; }

    /// <summary>
    /// Gets or sets the tag database generation source.
    /// </summary>
    YokogawaDxEthernetTagDatabaseSource TagDatabaseSource { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether AS1 security option is enabled.
    /// </summary>
    bool As1SecurityOption { get; set; }

    /// <summary>
    /// Gets or sets the username for AS1 security.
    /// </summary>
    string Username { get; set; }

    /// <summary>
    /// Gets or sets the password for AS1 security.
    /// </summary>
    string Password { get; set; }

    /// <summary>
    /// Gets or sets the user ID for AS1 security.
    /// </summary>
    string UserId { get; set; }

    /// <summary>
    /// Gets or sets the user function for AS1 security.
    /// </summary>
    YokogawaDxEthernetUserFunction UserFunction { get; set; }
}